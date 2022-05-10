using System;
using System.Windows.Forms;
using SpecificationManager.Configuration;
using SpecificationManager.Services;
using System.IO;

namespace SpecificationManager
{
    public partial class SetPathForm : Form
    {
        public string Path_ { get; set; }
        public SetPathForm()
        {
            InitializeComponent();
        }

        private void SetPathForm_Load(object sender, EventArgs e)
        {
            pathField1.Text = Path_;
            if (Path_ != Config.ReplaceProdListDefaultPath)
            {
                resetCheck.Enabled = true;
                resetCheck.Checked = false;
            }
            else
            {
                resetCheck.Enabled = false;
                resetCheck.Checked = true;
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            Path_ = pathField1.Text;
            DialogResult = DialogResult.OK;
        }

        private void choiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                pathField1.Text = Path.Combine(FileDialogService.OpenDirectory(),
                        Config.ReplaceProdListDefaultPath);
                Config.ReplaceProdListCurrentPath = "";
                resetCheck.Enabled = true;
                resetCheck.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Шлях не встановлений!", "Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetCheck_CheckedChanged(object sender, EventArgs e)
        {
            //pathField1.Text = Path.Combine(Directory.GetCurrentDirectory(),
            //Config.ReplaceProdListDefaultPath);
            pathField1.Text = Config.ReplaceProdListDefaultPath;
            resetCheck.Enabled = false;
        }
    }
}
