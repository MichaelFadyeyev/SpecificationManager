using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpecificationManager.Operations;
using SpecificationManager.Models;
using SpecificationManager.Formatting;
using SpecificationManager.Configuration;
using System.Collections.Generic;

namespace SpecificationManager
{
    public partial class Form1 : Form
    {
        OperationManager om = new OperationManager();
        Specification specification;
        bool specificationIsLoaded;
        List<string> checkedSuppliers;

        public Form1()
        {
            InitializeComponent();
            om.GetLibrary();
            timeSpanFild.ForeColor = Color.Red;

            for (int i = 0; i < DataGridFormatter.ColumnsNumber; i++)
            {
                dataGrid.Columns.Add(DataGridFormatter.ColumnName[i], DataGridFormatter.HeaderText[i]);
                dataGrid.Columns[i].Width = DataGridFormatter.ColumnWitdh[i];
                dataGrid.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGrid.Columns[2].Width = dataGrid.Width - DataGridFormatter.FixedColumnsWidth;
            dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        #region Menu Events
        private void saveSpecMenuItem_Click(object sender, EventArgs e)
        {
            SaveSpec(SaveFileMode.SaveSingle);
        }

        void imporExcelMenuItem_Click(object sender, EventArgs e)
        {
            ImporExcel();
        }
        void splitAndSaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveSpec(SaveFileMode.SaveSeparated);
        }
        void exportToProjectMenuItem_Click(object sender, EventArgs e)
        {
            ExportToProject();
        }
        void mergeGeneralSpecMenu_Click(object sender, EventArgs e)
        {
            MergeGeneralSpec();
        }
        void editRastexMenu_Click(object sender, EventArgs e)
        {
            EditItems(sender as ToolStripItem);
        }
        void editRafixMenu_Click(object sender, EventArgs e)
        {
            EditItems(sender as ToolStripItem);
        }
        void editScrewsMenu_Click(object sender, EventArgs e)
        {
            EditItems(sender as ToolStripItem);
        }
        void settingsBazisMenuItem_Click(object sender, EventArgs e)
        {
            ManualForm manualForm = new ManualForm();
            if (manualForm.ShowDialog() == DialogResult.OK)
            {
                return;
            }
        }
        void setPathMenuItem_Click(object sender, EventArgs e)
        {
            SetPathForm pathForm = new SetPathForm();
            pathForm.Path_ = Config.ReplaceProdListCurrentPath;

            if (pathForm.ShowDialog() == DialogResult.OK)
            {
                Config.ReplaceProdListCurrentPath = pathForm.Path_;
                om.GetLibrary();
                return;
            }
        }
        #endregion

        #region Buttons Events
        void importExcelButton_Click(object sender, EventArgs e)
        {
            ImporExcel();
        }
        void splitAndSaveButton_Click(object sender, EventArgs e)
        {
            SaveSpec(SaveFileMode.SaveSeparated);
        }
        void exportToProjectButton_Click(object sender, EventArgs e)
        {
            ExportToProject();
        }
        void mergeToProjectButton_Click(object sender, EventArgs e)
        {
            MergeGeneralSpec();
        }
        #endregion

        #region IO Methodes
        void ImporExcel()
        {
            try
            {
                dataGrid.Rows.Clear();
                timeSpanFild.Clear();
                specification = om.LoadSpecification();
                FillDataGrid();

            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void SaveSpec(SaveFileMode mode)
        {
            if (dataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Відсутня основна специфікація.\nПеред збереженням імпортуйте основну специфікацію.", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (om.WriteExcel(checkedSuppliers, mode))
                {
                    MessageBox.Show("Файли специфікацій успішно збережено", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файли не збережено", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void ExportToProject()
        {
            if (dataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Відсутня основна специфікація.\nПеред експортом імпортуйте основну специфікацію.", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                if (om.ExporToProject())
                {
                    MessageBox.Show("Деталі успішно експортовано", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Деталі не експортовано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void MergeGeneralSpec()
        {
            try
            {
                specification = om.MergeSpecifications();
                dataGrid.Rows.Clear();
                FillDataGrid();
                timeSpanFild.Text = "Time Span: " + om.TimeSpan + " ms";
            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        #endregion

        #region Tools Methodes
        void EditItems(ToolStripItem currenMenuItem)
        {
            string productType = currenMenuItem.Tag.ToString();

            var existdItems = om.GetExistItems(productType);
            if (existdItems != null)
            {
                ProductOperationsForm productOperations = new ProductOperationsForm();
                productOperations.Text = currenMenuItem.ToolTipText;
                productOperations.Specification = specification;
                productOperations.Type_ = productType;
                productOperations.ReplaceItems = om.GetReplaceItems();
                productOperations.ExistItems = existdItems;


                if (productOperations.ShowDialog() == DialogResult.OK)
                {
                    var targetType = productOperations.TargetProduct;
                    var alterType = productOperations.ReplaceProduct;

                    if (targetType.Article != alterType.Article)
                    {
                        dataGrid.Rows.Clear();
                        om.ReplaceProductOperation(targetType, alterType);
                        FillDataGrid();
                        return;
                    }
                    else
                        MessageBox.Show("Обрані для заміни деталі - ідентичні.\nЗаміна не виконана!",
                            "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region General Methodes
        void FillDataGrid()
        {
            specificationIsLoaded = false;
            int i = 0;
            if (suppliersList.Items.Count > 0) suppliersList.Items.Clear();
            checkedSuppliers = new List<string>();
            foreach (var supplier in specification.Suppliers)
            {
                if (supplier.Products.Any())
                {
                    foreach (var detail in supplier.Products)
                    {
                        dataGrid.Rows.Add(
                            ++i,
                            detail.Article,
                            detail.Name,
                            detail.Quantity,
                            detail.Units,
                            detail.Code,
                            supplier.Name);
                    }
                    suppliersList.Items.Add(supplier.Name + "\t- " + supplier.Products.Count + " поз.", true);
                    checkedSuppliers.Add(supplier.Name);
                }
            }
            ContractNumberFild.Text = specification.Article;
            specificationIsLoaded = true;
            timeSpanFild.Text = "Time Span: " + om.TimeSpan + " ms";
        }
        void FilterDataGrid()
        {
            int i = 0;
            foreach (var supplier in specification.Suppliers)
            {
                if (checkedSuppliers.Any(sn => sn == supplier.Name))
                {
                    if (supplier.Products.Any())
                    {
                        foreach (var detail in supplier.Products)
                        {
                            dataGrid.Rows.Add(
                                ++i,
                                detail.Article,
                                detail.Name,
                                detail.Quantity,
                                detail.Units,
                                detail.Code,
                                supplier.Name);
                        }
                    }
                }
            }
        }
        void suppliersList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (specificationIsLoaded)
            {
                dataGrid.Rows.Clear();

                string itemText = (sender as CheckedListBox).SelectedItem.ToString();
                string name = itemText.Substring(0, itemText.IndexOf("\t"));

                if (e.NewValue == CheckState.Unchecked)
                    checkedSuppliers.Remove(name);
                else if (e.NewValue == CheckState.Checked)
                    checkedSuppliers.Add(name);

                FilterDataGrid();
            }
        }


        #endregion

        #region Messaging Methodes
        static void ShowExceptionMessage(Exception exeption)
        {
            MessageBox.Show(exeption.Message, "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion


    }
}
