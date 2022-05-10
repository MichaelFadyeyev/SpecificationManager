namespace SpecificationManager
{
    partial class ProductOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOperationsForm));
            this.productTargetCombo = new System.Windows.Forms.ComboBox();
            this.currentLable = new System.Windows.Forms.Label();
            this.productReplaseCombo = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productTargetCombo
            // 
            this.productTargetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTargetCombo.FormattingEnabled = true;
            this.productTargetCombo.Location = new System.Drawing.Point(19, 46);
            this.productTargetCombo.Margin = new System.Windows.Forms.Padding(4);
            this.productTargetCombo.Name = "productTargetCombo";
            this.productTargetCombo.Size = new System.Drawing.Size(551, 24);
            this.productTargetCombo.TabIndex = 0;
            // 
            // currentLable
            // 
            this.currentLable.AutoSize = true;
            this.currentLable.Location = new System.Drawing.Point(16, 26);
            this.currentLable.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.currentLable.Name = "currentLable";
            this.currentLable.Size = new System.Drawing.Size(91, 16);
            this.currentLable.TabIndex = 1;
            this.currentLable.Text = "Що замінити:";
            // 
            // productReplaseCombo
            // 
            this.productReplaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productReplaseCombo.FormattingEnabled = true;
            this.productReplaseCombo.Location = new System.Drawing.Point(19, 113);
            this.productReplaseCombo.Margin = new System.Windows.Forms.Padding(4);
            this.productReplaseCombo.Name = "productReplaseCombo";
            this.productReplaseCombo.Size = new System.Drawing.Size(551, 24);
            this.productReplaseCombo.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(132, 166);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 30);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(299, 166);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(150, 30);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "Виконати";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Чим замінити:";
            // 
            // ProductOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 221);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentLable);
            this.Controls.Add(this.productReplaseCombo);
            this.Controls.Add(this.productTargetCombo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductOperationsForm";
            this.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заміна фурнітури ...";
            this.Load += new System.EventHandler(this.DetailOperationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox productTargetCombo;
        private System.Windows.Forms.Label currentLable;
        private System.Windows.Forms.ComboBox productReplaseCombo;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label label1;
    }
}