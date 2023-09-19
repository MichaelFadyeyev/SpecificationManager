using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using SpecificationManager.Services;
using SpecificationManager.Models;
using SpecificationManager.Models.Settings;
using SpecificationManager.Formatting;
using System.Windows.Forms;


namespace SpecificationManager.Operations
{
    public class ExcelOperations
    {
        string code;
        string currentId;
        int col;
        int row;
        readonly int headerHeight = WorksheetFormatter.HeaderRowHeight;

        OperationManager om;

        public ExcelOperations(OperationManager om)
        {
            this.om = om;
        }
        internal Specification Import(Specification s)
        {
            Specification specification = s ?? InitSpecification();
            Excel.Application xlApp = new Excel.Application();

            string[] files = FileDialogService.OpenFile("xls", true);
            if (files == null) throw new Exception("Файл не був обраний!");

            try
            {
                om.FilePath = files[0];

                if (files != null)
                {
                    Workbook xlWorkbook;
                    Worksheet xlWorksheet;
                    Range xlRange;

                    foreach (string file in files)
                    {
                        xlWorkbook = xlApp.Workbooks.Open(file);
                        xlWorksheet = xlWorkbook.Sheets[1];
                        xlRange = xlWorksheet.UsedRange;

                        col = WorksheetFormatter.StartColumn;
                        row = WorksheetFormatter.StartRow;
                        try
                        {
                            // fill specification model object from exel specification
                            while (xlRange.Cells[row, col] != null && xlRange.Cells[row, col].Value2 != null)
                            {
                                if (xlRange.Cells[row, col + 4].Value2.ToString().Contains("SP") &&
                                    !xlRange.Cells[row, col + 4].Value2.ToString().Contains("T0") &&
                                    !xlRange.Cells[row, col + 4].Value2.ToString().Contains("T1") &&
                                    !xlRange.Cells[row, col + 4].Value2.ToString().Contains("M1 ") &&
                                    !xlRange.Cells[row, col + 4].Value2.ToString().Contains("M5 "))
                                {
                                    code = xlRange.Cells[row, col + 4].Value2.ToString();
                                    currentId = code.Substring(code.IndexOf("SP"), 3);

                                    var newProduct = new Product(
                                            xlRange.Cells[row, col].Value2.ToString(),
                                            xlRange.Cells[row, col + 1].Value2.ToString(),
                                            xlRange.Cells[row, col + 2].Value2.ToString(),
                                            xlRange.Cells[row, col + 3].Value2.ToString(),
                                            xlRange.Cells[row, col + 4].Value2.ToString());

                                    var existProduct = specification.FindProduct(currentId, newProduct.Article);
                                    if (existProduct != null)
                                    {
                                        specification.SumProducts(existProduct, newProduct);
                                    }
                                    else
                                    {
                                        specification.Suppliers
                                        .Single(sid => sid.SupplierId == currentId)
                                        .Products.Add(newProduct);
                                    }
                                }
                                row++;
                            }
                            specification.Article = xlRange.Cells[6, 2].Value2.ToString();
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        finally
                        {
                            ExcelCloseWorkbook(xlWorkbook, xlWorksheet, xlRange);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            return specification;
        }

        internal bool ExportSeparated(Specification specification, List<string> chekedSuppliers)
        {
            //write separate specifications to *.xlsx
            bool result = default;

            Excel.Application xlApp = new Excel.Application();

            try
            {
                Workbook xlWorkbook;
                Worksheet xlWorksheet;
                Range xlRange;

                foreach (var supplier in specification.Suppliers)
                {
                    if (supplier.Products.Count != 0 && chekedSuppliers.Any(sn => sn == supplier.Name))
                    {
                        string supplierName = supplier.Name;
                        xlWorkbook = xlApp.Workbooks.Add();
                        xlWorksheet = xlWorkbook.Sheets[1];
                        xlRange = xlWorksheet.Cells[1, 1];

                        xlRange.RowHeight = headerHeight;

                        for (col = 1; col <= WorksheetFormatter.ColumnsRange1; col++)
                        {
                            xlRange.Cells[1, col] = WorksheetFormatter.HeaderText[col - 1];
                            xlRange = xlWorksheet.Columns[col];
                            xlRange.ColumnWidth = WorksheetFormatter.ColumnWitdh[col - 1];
                            xlRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                            xlRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
                            xlRange.WrapText = true;
                            xlRange = xlWorksheet.Cells[1, 1];
                        }

                        // SET CELL FORMAT TO "TEXT" FOR "Article"
                        xlWorksheet.Cells.Columns[2].NumberFormat = "@";

                        row = 2;
                        col = 0;

                        foreach (var detail in supplier.Products)
                        {
                            xlRange.Cells[row, ++col] = row - 1;
                            xlRange.Cells[row, ++col] = detail.Article;
                            xlRange.Cells[row, ++col] = detail.Name;
                            xlWorksheet.Cells[row, col].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                            xlRange.Cells[row, ++col] = detail.Quantity;
                            xlRange.Cells[row, ++col] = detail.Units;
                            row++;
                            col = 0;
                        }
                        try
                        {
                            xlWorkbook.SaveAs(
                                Path.GetDirectoryName(om.FilePath) + @"\" +
                                specification.Article + "-" +
                                supplier.Name +
                                ".xlsx");
                            result = true;
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        finally
                        {
                            ExcelCloseWorkbook(xlWorkbook, xlWorksheet, xlRange);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            return result;
        }

        internal bool ExportSingle(Specification specification, List<string> chekedSuppliers)
        {
            //write single specification to *.xlsx
            bool result = default;

            Excel.Application xlApp = new Excel.Application();

            try
            {
                Workbook xlWorkbook = xlApp.Workbooks.Add();
                Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Range xlRange = xlWorksheet.Cells[1, 1];

                //-> ФОРМУЄМО ХЕДЕР
                xlRange.RowHeight = headerHeight;

                for (col = 1; col <= WorksheetFormatter.ColumnsRange2; col++)
                {
                    xlRange.Cells[1, col] = WorksheetFormatter.HeaderText[col - 1];
                    xlRange = xlWorksheet.Columns[col];
                    xlRange.ColumnWidth = WorksheetFormatter.ColumnWitdh[col - 1];
                    xlRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    xlRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
                    xlRange.WrapText = true;
                    xlRange = xlWorksheet.Cells[1, 1];
                }

                // SET CELL FORMAT TO "TEXT" FOR "Article"
                xlWorksheet.Cells.Columns[2].NumberFormat = "@";
                //*

                row = 2;
                foreach (var supplier in specification.Suppliers)
                {
                    if (supplier.Products.Count != 0 && chekedSuppliers.Any(sn => sn == supplier.Name))
                    {
                        //string supplierName = supplier.Name;
                        col = 0;

                        foreach (var detail in supplier.Products)
                        {
                            xlRange.Cells[row, ++col] = row - 1;
                            xlRange.Cells[row, ++col] = detail.Article;
                            xlRange.Cells[row, ++col] = detail.Name;
                            xlWorksheet.Cells[row, col].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                            xlRange.Cells[row, ++col] = detail.Quantity;
                            xlRange.Cells[row, ++col] = detail.Units;
                            xlRange.Cells[row, ++col] = supplier.Name;
                            row++;
                            col = 0;
                        }
                    }
                }
                //-> ПЕРЕВІРИТИ ЧИ ПОТРІБНИЙ TRY
                try
                {
                    xlWorkbook.SaveAs(
                        Path.GetDirectoryName(om.FilePath) + @"\" +
                        specification.Article + "-" +
                        "ЗВЕДЕНА" +
                        ".xlsx");
                    result = true;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    ExcelCloseWorkbook(xlWorkbook, xlWorksheet, xlRange);
                }
                //*
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            return result;
        }

        static void ExcelCloseWorkbook(Workbook xlWorkbook, Worksheet xlWorksheet, Range xlRange)
        {
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
        }

        static Specification InitSpecification()
        {
            var specification = new Specification()
            {
                Suppliers = new List<Supplier>()
            };
            foreach (var item in SuppliersSetting.Naming)
            {
                specification.Suppliers.Add(new Supplier(item.Key, item.Value));
            }
            return specification;
        }
    }

}

