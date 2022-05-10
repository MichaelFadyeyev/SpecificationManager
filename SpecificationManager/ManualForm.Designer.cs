
namespace SpecificationManager
{
    partial class ManualForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titleText = new System.Windows.Forms.Label();
            this.stageText = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SpecificationManager.Properties.Resources.settings_bazis_1;
            this.pictureBox.Location = new System.Drawing.Point(12, 65);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(712, 439);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.titleText.Location = new System.Drawing.Point(148, 19);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(452, 25);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Налаштування експорту фурнітури у файл *.xls";
            // 
            // stageText
            // 
            this.stageText.AutoSize = true;
            this.stageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.stageText.Location = new System.Drawing.Point(318, 538);
            this.stageText.Name = "stageText";
            this.stageText.Size = new System.Drawing.Size(98, 31);
            this.stageText.TabIndex = 1;
            this.stageText.Text = "Крок 1";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.Location = new System.Drawing.Point(163, 534);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "<<<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.forwardButton.Location = new System.Drawing.Point(435, 534);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(130, 40);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = ">>>";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 601);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.stageText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Налаштування експорту";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label stageText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
    }
}