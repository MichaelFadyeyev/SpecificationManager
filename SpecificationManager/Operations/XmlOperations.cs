using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using SpecificationManager.Services;
using SpecificationManager.Models;
using SpecificationManager.Configuration;


namespace SpecificationManager.Operations
{
    public class XmlOperations
    {
        string filePath;
        bool result;

        XDocument doc;
        XElement root;

        public bool LoadProductsLibrary(out List<ProductType> operateItems)
        {
            operateItems = new List<ProductType>();
            result = default;
            try
            {
                filePath = Config.ReplaceProdListCurrentPath;
                if (File.Exists(filePath))
                {
                    doc = XDocument.Load(filePath);
                    root = doc.Element("root");
                    foreach (var products in root.Elements())
                    {
                        foreach (var product in products.Elements())
                        {
                            operateItems.Add(new ProductType()
                            {
                                Type_ = products.Attribute("type").Value,
                                Article = product.Attribute("article").Value,
                                Name = product.Attribute("name").Value,
                                Code = product.Attribute("code").Value
                            });
                        }
                    }
                    result = true;
                }
            }
            catch (Exception)
            {
                throw new Exception("Файл не був прочитаний!");
            }
            return result;
        }

        public bool InitializeProductLibrary()
        {
            string workingPath;

            if (Config.ReplaceProdListCurrentPath == "")
            {
                workingPath = Config.ReplaceProdListDefaultPath;
                Config.ReplaceProdListCurrentPath = 
                    Config.ReplaceProdListDefaultPath;
            }
            else
            {
                workingPath = Config.ReplaceProdListCurrentPath;
                //File.Delete(Config.ReplaceProdListDefaultPath);
                //Directory.Delete(Directory.GetParent(Config.ReplaceProdListDefaultPath).FullName);
                //string s = Directory.GetParent(Config.ReplaceProdListDefaultPath).FullName;
            }

            result = default;

            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(workingPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(workingPath));
                }

                filePath = workingPath;
                using (_ = File.Create(filePath)) { };

                /* POSSIBLE VARIANT
                //var file = File.Create(filePath); 
                //file.Close();
                */

                if (File.Exists(filePath))
                {
                    doc = new XDocument(
                    new XElement("root",
                    new XElement("products", new XAttribute("type", "screw_frn"),
                    new XElement("product",
                        new XAttribute("article", "60837"),
                        new XAttribute("name", "Конфірмат 6,4х50 мм"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "52559"),
                        new XAttribute("name", "Конфірмат 7х50 мм"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "52560"),
                        new XAttribute("name", "Конфірмат 7х70 мм"),
                        new XAttribute("code", "M3 SP1"))),
                    //
                    new XElement("products", new XAttribute("type", "rastex"),
                    new XElement("product",
                        new XAttribute("article", "51760"),
                        new XAttribute("name", "Ексцентрикова стяжка Rastex 15/12 (20053) Hettich"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "59042"),
                        new XAttribute("name", "Ексцентрикова стяжка Rastex 15/15 (9059487) Hettich"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "61281"),
                        new XAttribute("name", "Ексцентрикова стяжка Rastex 15/18 (9056599) Hettich"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "83199"),
                        new XAttribute("name", "Ексцентрикова стяжка Rastex 15/22 (1048254) Hettich"),
                        new XAttribute("code", "M3 SP1"))),
                    //
                    new XElement("products", new XAttribute("type", "rafix"),
                    new XElement("product",
                        new XAttribute("article", "263.10.405"),
                        new XAttribute("name", "RAFIX SE D20х14.2 мм бежевий"),
                        new XAttribute("code", "M3 SP4")),
                    new XElement("product",
                        new XAttribute("article", "263.10.205"),
                        new XAttribute("name", "RAFIX SE D20х14.2 мм сірий"),
                        new XAttribute("code", "M3 SP4")),
                    new XElement("product",
                        new XAttribute("article", "263.10.305"),
                        new XAttribute("name", "RAFIX SE D20х14.2 мм чорний"),
                        new XAttribute("code", "M3 SP4")),
                    new XElement("product",
                        new XAttribute("article", "263.10.705"),
                        new XAttribute("name", "RAFIX SE D20х14.2 мм білий"),
                        new XAttribute("code", "M3 SP4")),
                    //
                    new XElement("product",
                        new XAttribute("article", "13015"),
                        new XAttribute("name", "Стяжка VB 35/18, цинк (9117725) Hettich"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "84629"),
                        new XAttribute("name", "Стяжка VB 35/18, черная (79641) Hettich"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "82759"),
                        new XAttribute("name", "Стяжка VB 35/18, коричневая (9116945) Hettich"),
                        new XAttribute("code", "M3 SP1")),
                    new XElement("product",
                        new XAttribute("article", "84628"),
                        new XAttribute("name", "Стяжка VB 35/18, белая (9116944) Hettich"),
                        new XAttribute("code", "M3 SP1")))
                    ));

                    doc.Save(filePath);
                    result = true;
                }
            }
            catch (Exception)
            {
                throw new Exception("Файл не був созданий!");
            }
            return result;
        }

        internal bool ExportProjectData(Specification specification)
        {
            result = default;
            try
            {
                filePath = FileDialogService.OpenFile("project", false)[0];

                Supplier viyar = specification.Suppliers.Where(s => s.Name == "Viyar").First();
                doc = XDocument.Load(filePath);
                root = doc.Element("project");

                if ((root.Element("viyar").Elements()
                        .Where(r => r.Name == "products")).Any())
                {
                    root.Element("viyar").Element("products").Remove();
                }
                root.Element("viyar").Add(new XElement("products"));

                int i = 0;
                foreach (var detail in viyar.Products)
                {
                    root.Element("viyar")
                    .Element("products")
                    .Add(new XElement("product",
                    new XAttribute("id", ++i),
                    new XAttribute("article", detail.Article),
                    new XAttribute("name", detail.Name),
                    new XAttribute("amount", detail.Quantity)));
                }
                string fileNameUpdated =
                    Path.GetDirectoryName(filePath) + @"\" +
                    Path.GetFileNameWithoutExtension(filePath) +
                    "_updated" +
                    Path.GetExtension(filePath);

                doc.Save(fileNameUpdated);

                result = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
    }
}
