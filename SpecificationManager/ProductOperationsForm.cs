using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecificationManager.Operations;
using SpecificationManager.Models;

namespace SpecificationManager
{
    public partial class ProductOperationsForm : Form
    {
        public ProductType ReplaceProduct { get; set; }

        public ProductType TargetProduct { get; set; }

        public Specification Specification { get; set; }

        public List<ProductType> ReplaceItems { get; set; }

        public List<ProductType> ExistItems { get; set; }
        public string TitleLable { get; set; }

        public string Type_ { get; set; }
        public ProductOperationsForm()
        {
            InitializeComponent();
            ReplaceItems = new List<ProductType>();
            ExistItems = new List<ProductType>();
        }
        private void DetailOperationsForm_Load(object sender, EventArgs e)
        {
            
            productTargetCombo.DataSource = ExistItems;
            productTargetCombo.DisplayMember = "Name";

            productReplaseCombo.DataSource = ReplaceItems
                .Where(product => product.Type_ == Type_).ToList();
            productReplaseCombo.DisplayMember = "Name";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            productTargetCombo.SelectedIndex = -1;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            TargetProduct = productTargetCombo.SelectedItem as ProductType;      //targeted product attributes
            ReplaceProduct = productReplaseCombo.SelectedItem as ProductType;    //replaced product attributes

            DialogResult = DialogResult.OK;
        }
    }
}
