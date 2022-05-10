using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecificationManager.Properties;

namespace SpecificationManager
{
    public partial class ManualForm : Form
    {
        int counter = 0;
        Bitmap[] pages = new Bitmap[] 
        { 
            Resources.settings_bazis_1, 
            Resources.settings_bazis_2, 
            Resources.settings_bazis_3 
        };
        public ManualForm()
        {
            InitializeComponent();

            pictureBox.Image = pages[counter];
            backButton.Enabled = false;
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            counter++;
            
            if (counter < pages.Length)
            {
                stageText.Text = "Крок " + $"{counter + 1}";
                pictureBox.Image = pages[counter];
                _ = counter == pages.Length - 1 ? forwardButton.Enabled = false : forwardButton.Enabled = true;
            }
            else
                counter--;
            if(counter > 0)
                backButton.Enabled = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter > -1)
            {
                stageText.Text = "Крок " + $"{counter + 1}";
                pictureBox.Image = pages[counter];
                _ = counter == 0 ? backButton.Enabled = false : backButton.Enabled = true;
            }
            else
                counter++;
            if (counter < pages.Length - 1)
                forwardButton.Enabled = true;
        }
    }
}
