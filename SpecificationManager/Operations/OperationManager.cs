using System.Diagnostics;
using System.Configuration;
using System;
using System.Linq;
using SpecificationManager.Models;
using SpecificationManager.Models.Settings;
using System.Collections.Generic;
using SpecificationManager.Configuration;

namespace SpecificationManager.Operations
{

    public class OperationManager
    {
        readonly Stopwatch stopwatch = new Stopwatch();
        readonly ExcelOperations excelOperations;
        readonly XmlOperations xmlOperations;
        public string TimeSpan { get; set; }
        Specification specification;
        readonly List<ProductType> existItems = new List<ProductType>();
        List<ProductType> replaceItems;
        public string Article { get => specification.Article; }
        public string FilePath;

        public OperationManager()
        {
            xmlOperations = new XmlOperations(this);
            excelOperations = new ExcelOperations(this);
        }

        public void GetLibrary()
        {
            try
            {
                if (!xmlOperations.LoadProductsLibrary(out replaceItems))
                {
                    xmlOperations.InitializeProductLibrary();
                    xmlOperations.LoadProductsLibrary(out replaceItems);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Specification Open()
        {
            try
            {
                specification = xmlOperations.OpenXML();
                return specification;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Save(Specification specification, bool saveAsMode)
        {
            try
            {
                return xmlOperations.SaveXML(specification, saveAsMode);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Specification ImportExcel()
        {
            stopwatch.Start();

            specification = excelOperations.Import(null);

            stopwatch.Stop();
            TimeSpan = stopwatch.ElapsedMilliseconds.ToString();
            stopwatch.Reset();

            return specification;
        }

        public bool ExportExcel(List<string> chekedSuppliers, ExportExcelMode mode)
        {
            try
            {
                switch (mode)
                {
                    case ExportExcelMode.Single:
                        return excelOperations.ExportSingle(specification, chekedSuppliers);
                    case ExportExcelMode.Separated:
                        return excelOperations.ExportSeparated(specification, chekedSuppliers);
                    default:
                        return false;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool AddToProject()
        {
            return xmlOperations.ExportProjectData(specification);
        }

        public Specification AppendExcel()
        {
            stopwatch.Start();
            var result = excelOperations.Import(specification);
            stopwatch.Stop();
            TimeSpan = stopwatch.ElapsedMilliseconds.ToString();
            stopwatch.Reset();

            return result;
        }

        public List<ProductType> GetReplaceItems()
        {
            return replaceItems;
        }

        public List<ProductType> GetExistItems(string item_type)
        {
            if (specification == null) return null;

            existItems.Clear();

            foreach (var supplier in specification.Suppliers)
            {
                foreach (var detail in supplier.Products)
                {
                    if (item_type == "rastex")
                    {
                        switch (detail.Article)
                        {
                            case "51760":
                            case "59042":
                            case "61281":
                            case "83199":
                                AddItem(detail);
                                break;
                        }
                    }
                    else if (item_type == "rafix")
                    {
                        switch (detail.Article)
                        {
                            case "263.10.405":
                            case "263.10.205":
                            case "263.10.305":
                            case "263.10.705":
                            case "13015":
                            case "84629":
                            case "82759":
                            case "84628":
                                AddItem(detail);
                                break;
                        }
                    }
                    else
                    {
                        switch (detail.Article)
                        {
                            case "60837":
                            case "52559":
                            case "52560":
                                AddItem(detail);
                                break;
                        }
                    }
                }
            }
            return existItems;

            void AddItem(Product detail)
            {
                existItems.Add(new ProductType(item_type, detail.Article,
                    detail.Name, detail.Code));
            }
        }

        public bool ReplaceProductOperation(ProductType targetType, ProductType alterType)
        {
            //altered product instance
            Product alteredProduct = GetProducts(alterType.Code)
                .Where(rp => rp.Article == alterType.Article).FirstOrDefault();

            //targeted product instance
            Product targetedProduct = GetProducts(targetType.Code)
                .Single(ap => ap.Article == targetType.Article);

            if (alteredProduct == null)
            {
                Product newProduct = new Product()
                {
                    Article = alterType.Article,
                    Name = alterType.Name,
                    Code = alterType.Code,
                    Units = targetedProduct.Units,
                    Quantity = targetedProduct.Quantity,
                };

                GetProducts(targetType.Code).Remove(targetedProduct);
                GetProducts(alterType.Code).Add(newProduct);
            }
            else
            {
                alteredProduct.Quantity =
                    ParseSum(alteredProduct.Quantity, targetedProduct.Quantity);
                GetProducts(targetType.Code).Remove(targetedProduct);
            }

            return true;

            List<Product> GetProducts(string gettingProductCode)
            {
                return specification
                                .Suppliers.Single(s => s.SupplierId == gettingProductCode
                                .Substring(gettingProductCode.IndexOf("SP"), 3))
                                .Products;
            }
        }

        private static string ParseSum(string value1, string value2)
        {
            return (float.Parse(value1) + float.Parse(value2)).ToString();
        }
    }
}
