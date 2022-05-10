using System.Diagnostics;
using System.Configuration;
using System;
using System.Linq;
using SpecificationManager.Models;
using SpecificationManager.Models.Settings;
using System.Collections.Generic;

namespace SpecificationManager.Operations
{

    public class OperationManager
    {
        Stopwatch stopwatch = new Stopwatch();
        ExcelOperations excelOperations = new ExcelOperations();
        XmlOperations xmlOperations = new XmlOperations();
        public string TimeSpan { get; set; }
        Specification specification;
        List<ProductType> existItems = new List<ProductType>();
        List<ProductType> replaceItems = new List<ProductType>();

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

        public Specification LoadSpecification()
        {
            stopwatch.Start();

            specification = excelOperations.ImportExcelData();

            stopwatch.Stop();
            TimeSpan = stopwatch.ElapsedMilliseconds.ToString();
            stopwatch.Reset();

            return specification;
        }

        public bool WriteExelFiles(List<string> chekedSuppliers)
        {
            try
            {
                return excelOperations.ExportExcelData(specification, chekedSuppliers);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ExporToProject()
        {
            return xmlOperations.ExportProjectData(specification);
        }

        public Specification MergeSpecifications()
        {
            if (specification != null)
            {
                stopwatch.Start();
                Specification importedSpecification = excelOperations.ImportExcelData();

                Product importedDetail;
                Product detail;

                for (int i = 0; i < SuppliersSetting.Naming.Count; i++)
                {
                    for (int j = 0; j < importedSpecification.Suppliers[i].Products.Count; j++)
                    {
                        bool operationKey = true;
                        importedDetail = importedSpecification.Suppliers[i].Products[j];

                        for (int k = 0; k < specification.Suppliers[i].Products.Count; k++)
                        {
                            detail = specification.Suppliers[i].Products[k];

                            if (importedDetail.Article == detail.Article)
                            {
                                detail.Quantity =
                                    ParseSum(importedDetail.Quantity, detail.Quantity);
                                operationKey = false;
                            }
                        }
                        if (operationKey)
                        {
                            specification.Suppliers[i].Products.Add(importedDetail);
                        }
                    }
                }

                stopwatch.Stop();
                TimeSpan = stopwatch.ElapsedMilliseconds.ToString();
                stopwatch.Reset();

                return specification;
            }
            else
            {
                throw new Exception("Відсутня основна специфікація.\nПеред об'єднанням імпортуйте основну специфікацію.");
            }

        }

        public List<ProductType> GetReplaceItems()
        {
            return replaceItems;
        }

        public List<ProductType> GetExistItems(string item_type)
        {
            existItems.Clear();
            if (specification != null)
            {
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
            }
            return null;

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
