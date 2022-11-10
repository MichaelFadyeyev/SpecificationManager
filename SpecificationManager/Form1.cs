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
        bool specificationIsSaved;
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

        void openMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        void saveMenuItem_Click(object sender, EventArgs e)
        {
            Save(specification, false);
        }
        void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            Save(specification, true);
        }
        void impExcelMenuItem_Click(object sender, EventArgs e)
        {
            ImportExcel();
        }
        void expSeparatedMenuItem_Click(object sender, EventArgs e)
        {
            Export(ExportExcelMode.Separated);
        }
        void expSingleMenuItem_Click(object sender, EventArgs e)
        {
            Export(ExportExcelMode.Single);
        }
        void addToProjectMenuItem_Click(object sender, EventArgs e)
        {
            AddToProject();
        }
        void appendExcelMenu_Click(object sender, EventArgs e)
        {
            AppendExcel();
        }
        void editRastexMenu_Click(object sender, EventArgs e)
        {
            //if (specification != null)
                EditItems(sender as ToolStripItem);
        }
        void editRafixMenu_Click(object sender, EventArgs e)
        {
            //if (specification != null)
                EditItems(sender as ToolStripItem);
        }
        void editScrewsMenu_Click(object sender, EventArgs e)
        {
            //if (specification != null)
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
        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            if (!specificationIsLoaded)
            {
                SpecificationNotLoadedMessege();
                return;
            }

            if (!specificationIsSaved)
            {
                if (MessageBox.Show("Зберегти зміни до специфікації?", "Увага!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    Save(specification, false);
            }
            dataGrid.Rows.Clear();
            suppliersList.Items.Clear();
            articleField.Clear();
            articleEditBtn.Enabled = false;

            specification = null;
        }
        #endregion

        #region Buttons Events
        void impExcelButton_Click(object sender, EventArgs e)
        {
            ImportExcel();
        }
        void expSeparatedButton_Click(object sender, EventArgs e)
        {
            Export(ExportExcelMode.Separated);
        }
        void addToProjectButton_Click(object sender, EventArgs e)
        {
            AddToProject();
        }
        void appendExcelButton_Click(object sender, EventArgs e)
        {
            AppendExcel();
        }
        private void articleEditBtn_Click(object sender, EventArgs e)
        {
            if (specificationIsLoaded)
            {
                articleField.ReadOnly = false;

                menuStrip.Enabled = false;
                dataGrid.Enabled = false;
                suppliersList.Enabled = false;
                buttonsGroup.Enabled = false;

                articleSaveBtn.Enabled = true;
                articleEditBtn.Enabled = false;
            }
            else
                MessageBox.Show("Відсутня основна специфікація!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void articleSaveBtn_Click(object sender, EventArgs e)
        {
            specification.Article = articleField.Text;
            articleField.ReadOnly = true;

            menuStrip.Enabled = true;
            dataGrid.Enabled = true;
            suppliersList.Enabled = true;
            buttonsGroup.Enabled = true;

            articleSaveBtn.Enabled = false;
            articleEditBtn.Enabled = true;

            specificationIsSaved = false;
        }
        #endregion

        #region IO Methodes
        void Open()
        {
            try
            {
                var result = om.Open();
                if (result == null)
                {
                    MessageBox.Show("Файл не завантажений", "Помилка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                specification = result;
                dataGrid.Rows.Clear();
                FillDataGrid();

            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void Save(Specification specification, bool saveAsMode)
        {
            if (dataGrid.Rows.Count == 0)
            {
                SpecificationNotLoadedMessege();
                return;
            }
            try
            {
                if (om.Save(specification, saveAsMode))
                {
                    specificationIsSaved = true;
                    MessageBox.Show("Файл специфікацій успішно збережено", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Файл не збережено", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void ImportExcel()
        {
            try
            {
                dataGrid.Rows.Clear();
                timeSpanFild.Clear();
                specification = om.ImportExcel();
                FillDataGrid();

            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void Export(ExportExcelMode mode)
        {
            if (dataGrid.Rows.Count == 0)
            {
                SpecificationNotLoadedMessege();
                return;
            }
            try
            {
                if (om.ExportExcel(checkedSuppliers, mode))
                {
                    MessageBox.Show("Файли специфікацій успішно збережено", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Файли не збережено", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void AddToProject()
        {
            if (dataGrid.Rows.Count == 0)
            {
                MessageBox.Show("Відсутня основна специфікація.\nПеред експортом імпортуйте основну специфікацію.", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                if (om.AddToProject())
                {
                    MessageBox.Show("Деталі успішно експортовано", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Деталі не експортовано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exeption)
            {
                ShowExceptionMessage(exeption);
            }
        }
        void AppendExcel()
        {
            try
            {
                specification = om.AppendExcel();
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
            if (specification == null)
            {
                SpecificationNotLoadedMessege();
                return;
            }

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
            articleField.Text = specification.Article;
            specificationIsLoaded = true;
            specificationIsSaved = false;
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

        static void SpecificationNotLoadedMessege()
        {
            MessageBox.Show("Відсутня основна специфікація.\nДодайте основну специфікацію.", "Увага!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
