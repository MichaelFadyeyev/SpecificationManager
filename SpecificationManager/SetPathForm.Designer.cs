namespace SpecificationManager
{
    partial class SetPathForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPathForm));
            this.setButton = new System.Windows.Forms.Button();
            this.pathField1 = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.choiceButton = new System.Windows.Forms.Button();
            this.resetCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // setButton
            // 
            this.setButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setButton.Location = new System.Drawing.Point(242, 157);
            this.setButton.Margin = new System.Windows.Forms.Padding(4);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(150, 30);
            this.setButton.TabIndex = 0;
            this.setButton.Text = "Застосувати";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // pathField1
            // 
            this.pathField1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pathField1.Enabled = false;
            this.pathField1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pathField1.Location = new System.Drawing.Point(31, 43);
            this.pathField1.Multiline = true;
            this.pathField1.Name = "pathField1";
            this.pathField1.Size = new System.Drawing.Size(423, 64);
            this.pathField1.TabIndex = 1;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(28, 24);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(202, 16);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Шлях до файлу списків заміни";
            // 
            // choiceButton
            // 
            this.choiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiceButton.Location = new System.Drawing.Point(84, 157);
            this.choiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.choiceButton.Name = "choiceButton";
            this.choiceButton.Size = new System.Drawing.Size(150, 30);
            this.choiceButton.TabIndex = 0;
            this.choiceButton.Text = "Обрати";
            this.choiceButton.UseVisualStyleBackColor = true;
            this.choiceButton.Click += new System.EventHandler(this.choiceButton_Click);
            // 
            // resetCheck
            // 
            this.resetCheck.AutoSize = true;
            this.resetCheck.Location = new System.Drawing.Point(31, 114);
            this.resetCheck.Name = "resetCheck";
            this.resetCheck.Size = new System.Drawing.Size(218, 20);
            this.resetCheck.TabIndex = 3;
            this.resetCheck.Text = "Вернути шлях за замоченням";
            this.resetCheck.UseVisualStyleBackColor = true;
            this.resetCheck.CheckedChanged += new System.EventHandler(this.resetCheck_CheckedChanged);
            // 
            // SetPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.resetCheck);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathField1);
            this.Controls.Add(this.choiceButton);
            this.Controls.Add(this.setButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetPathForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetPathForm";
            this.Load += new System.EventHandler(this.SetPathForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox pathField1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button choiceButton;
        private System.Windows.Forms.CheckBox resetCheck;
    }
}