
namespace SpecificationManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expSeparatedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expSingleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.detailOperationsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editRastexMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editRafixMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editScrewsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsBazisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timeSpanFild = new System.Windows.Forms.TextBox();
            this.ContractNumberField = new System.Windows.Forms.TextBox();
            this.addToProjectButton = new System.Windows.Forms.Button();
            this.expSeparatedButton = new System.Windows.Forms.Button();
            this.impExcelButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.suppliersList = new System.Windows.Forms.CheckedListBox();
            this.appendExcelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.expSingleButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.toolsMenu,
            this.settingsMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.impExcelMenuItem,
            this.appendExcelMenu,
            this.expSeparatedMenuItem,
            this.expSingleMenuItem,
            this.addToProjectMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Tag = "fa";
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.ToolTipText = "Операції з файлами";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Enabled = false;
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(351, 22);
            this.openMenuItem.Text = "Відкрити специфікацію";
            this.openMenuItem.ToolTipText = "Відкрити специфікацію";
            this.openMenuItem.Visible = false;
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(351, 22);
            this.saveMenuItem.Text = "Зберегти специфікацію";
            this.saveMenuItem.ToolTipText = "Зберегти специфікацію";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(351, 22);
            this.saveAsMenuItem.Text = "Зберегти специфікацію як";
            this.saveAsMenuItem.ToolTipText = "Зберегти специфікацію як";
            this.saveAsMenuItem.Visible = false;
            // 
            // impExcelMenuItem
            // 
            this.impExcelMenuItem.Name = "impExcelMenuItem";
            this.impExcelMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.impExcelMenuItem.Size = new System.Drawing.Size(351, 22);
            this.impExcelMenuItem.Text = "Імпортувати загальну специфікацію";
            this.impExcelMenuItem.ToolTipText = "Імпорт файлу специфікації";
            this.impExcelMenuItem.Click += new System.EventHandler(this.impExcelMenuItem_Click);
            // 
            // expSeparatedMenuItem
            // 
            this.expSeparatedMenuItem.Name = "expSeparatedMenuItem";
            this.expSeparatedMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.expSeparatedMenuItem.Size = new System.Drawing.Size(351, 22);
            this.expSeparatedMenuItem.Text = "Експортувати специфікації по виробникам";
            this.expSeparatedMenuItem.ToolTipText = "Експортувати специфікації по виробникам";
            this.expSeparatedMenuItem.Click += new System.EventHandler(this.expSeparatedMenuItem_Click);
            // 
            // expSingleMenuItem
            // 
            this.expSingleMenuItem.Name = "expSingleMenuItem";
            this.expSingleMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.expSingleMenuItem.Size = new System.Drawing.Size(351, 22);
            this.expSingleMenuItem.Text = "Експортувати загальну специфікацію";
            this.expSingleMenuItem.ToolTipText = "Експортувати загальну специфікацію";
            this.expSingleMenuItem.Click += new System.EventHandler(this.expSingleMenuItem_Click);
            // 
            // addToProjectMenuItem
            // 
            this.addToProjectMenuItem.Name = "addToProjectMenuItem";
            this.addToProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.addToProjectMenuItem.Size = new System.Drawing.Size(351, 22);
            this.addToProjectMenuItem.Text = "Додати фурнітуру у файл ViyarPRO";
            this.addToProjectMenuItem.ToolTipText = "Додати фурнітуру у файл ViyarPRO";
            this.addToProjectMenuItem.Click += new System.EventHandler(this.addToProjectMenuItem_Click);
            // 
            // appendExcelMenu
            // 
            this.appendExcelMenu.Name = "appendExcelMenu";
            this.appendExcelMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.appendExcelMenu.Size = new System.Drawing.Size(351, 22);
            this.appendExcelMenu.Text = "Додати загальну специфікацію";
            this.appendExcelMenu.ToolTipText = "Додати специфікацію до відкритої";
            this.appendExcelMenu.Click += new System.EventHandler(this.appendExcelMenu_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailOperationsMenu});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.toolsMenu.Size = new System.Drawing.Size(87, 20);
            this.toolsMenu.Tag = "to";
            this.toolsMenu.Text = "Інструменти";
            this.toolsMenu.ToolTipText = "Інструменти редагування специфікації";
            // 
            // detailOperationsMenu
            // 
            this.detailOperationsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRastexMenu,
            this.editRafixMenu,
            this.editScrewsMenu});
            this.detailOperationsMenu.Name = "detailOperationsMenu";
            this.detailOperationsMenu.Size = new System.Drawing.Size(185, 22);
            this.detailOperationsMenu.Text = "Операції з деталями";
            // 
            // editRastexMenu
            // 
            this.editRastexMenu.AccessibleDescription = "";
            this.editRastexMenu.AccessibleName = "";
            this.editRastexMenu.Name = "editRastexMenu";
            this.editRastexMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.editRastexMenu.Size = new System.Drawing.Size(268, 22);
            this.editRastexMenu.Tag = "rastex";
            this.editRastexMenu.Text = "Замінити муфти Rastex";
            this.editRastexMenu.ToolTipText = "Заміна муфт Rastex";
            this.editRastexMenu.Click += new System.EventHandler(this.editRastexMenu_Click);
            // 
            // editRafixMenu
            // 
            this.editRafixMenu.Name = "editRafixMenu";
            this.editRafixMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.editRafixMenu.Size = new System.Drawing.Size(268, 22);
            this.editRafixMenu.Tag = "rafix";
            this.editRafixMenu.Text = "Замінити муфти Rafix";
            this.editRafixMenu.ToolTipText = "Заміна муфт Rafix";
            this.editRafixMenu.Click += new System.EventHandler(this.editRafixMenu_Click);
            // 
            // editScrewsMenu
            // 
            this.editScrewsMenu.Name = "editScrewsMenu";
            this.editScrewsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.editScrewsMenu.Size = new System.Drawing.Size(268, 22);
            this.editScrewsMenu.Tag = "screw_frn";
            this.editScrewsMenu.Text = "Замінити гвинти Конфірмат";
            this.editScrewsMenu.ToolTipText = "Заміна гвинтів Конфірмат";
            this.editScrewsMenu.Click += new System.EventHandler(this.editScrewsMenu_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPathMenuItem,
            this.settingsBazisMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.settingsMenuItem.Size = new System.Drawing.Size(101, 20);
            this.settingsMenuItem.Tag = "se";
            this.settingsMenuItem.Text = "Налаштування";
            this.settingsMenuItem.ToolTipText = "Налаштування і довідка";
            // 
            // setPathMenuItem
            // 
            this.setPathMenuItem.Name = "setPathMenuItem";
            this.setPathMenuItem.Size = new System.Drawing.Size(322, 22);
            this.setPathMenuItem.Text = "Шлях до файлів";
            this.setPathMenuItem.ToolTipText = "Шлях до теки шаблонів заміни";
            this.setPathMenuItem.Click += new System.EventHandler(this.setPathMenuItem_Click);
            // 
            // settingsBazisMenuItem
            // 
            this.settingsBazisMenuItem.Name = "settingsBazisMenuItem";
            this.settingsBazisMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.settingsBazisMenuItem.Size = new System.Drawing.Size(322, 22);
            this.settingsBazisMenuItem.Text = "Налаштування у \"Базис Мебельщик\"";
            this.settingsBazisMenuItem.ToolTipText = "Налаштування в програмі \"Базис Мебельщик\" \r\nдля подальшого експорту специфікацій\r" +
    "\nу форматі *.xlsx";
            this.settingsBazisMenuItem.Click += new System.EventHandler(this.settingsBazisMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Артикул (номер замовлення):";
            // 
            // timeSpanFild
            // 
            this.timeSpanFild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeSpanFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeSpanFild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeSpanFild.Location = new System.Drawing.Point(6, 662);
            this.timeSpanFild.Name = "timeSpanFild";
            this.timeSpanFild.ReadOnly = true;
            this.timeSpanFild.Size = new System.Drawing.Size(244, 23);
            this.timeSpanFild.TabIndex = 3;
            // 
            // ContractNumberField
            // 
            this.ContractNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContractNumberField.Location = new System.Drawing.Point(6, 32);
            this.ContractNumberField.Name = "ContractNumberField";
            this.ContractNumberField.ReadOnly = true;
            this.ContractNumberField.Size = new System.Drawing.Size(249, 23);
            this.ContractNumberField.TabIndex = 2;
            this.ContractNumberField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addToProjectButton
            // 
            this.addToProjectButton.Location = new System.Drawing.Point(6, 554);
            this.addToProjectButton.Name = "addToProjectButton";
            this.addToProjectButton.Size = new System.Drawing.Size(247, 33);
            this.addToProjectButton.TabIndex = 7;
            this.addToProjectButton.Text = "Додати фурнітуру у файл ViyarPRO";
            this.addToProjectButton.UseVisualStyleBackColor = true;
            this.addToProjectButton.Click += new System.EventHandler(this.addToProjectButton_Click);
            // 
            // expSeparatedButton
            // 
            this.expSeparatedButton.Location = new System.Drawing.Point(6, 476);
            this.expSeparatedButton.Name = "expSeparatedButton";
            this.expSeparatedButton.Size = new System.Drawing.Size(247, 33);
            this.expSeparatedButton.TabIndex = 5;
            this.expSeparatedButton.Text = "Зберегти специфікації по виробникам";
            this.expSeparatedButton.UseVisualStyleBackColor = true;
            this.expSeparatedButton.Click += new System.EventHandler(this.expSeparatedButton_Click);
            // 
            // impExcelButton
            // 
            this.impExcelButton.Location = new System.Drawing.Point(7, 437);
            this.impExcelButton.Name = "impExcelButton";
            this.impExcelButton.Size = new System.Drawing.Size(247, 33);
            this.impExcelButton.TabIndex = 4;
            this.impExcelButton.Text = "Відкрити загальну специфікацію";
            this.impExcelButton.UseVisualStyleBackColor = true;
            this.impExcelButton.Click += new System.EventHandler(this.impExcelButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(3, 16);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(778, 669);
            this.dataGrid.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(1044, 701);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGrid);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 688);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.suppliersList);
            this.groupBox3.Controls.Add(this.timeSpanFild);
            this.groupBox3.Controls.Add(this.ContractNumberField);
            this.groupBox3.Controls.Add(this.appendExcelButton);
            this.groupBox3.Controls.Add(this.addToProjectButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.expSingleButton);
            this.groupBox3.Controls.Add(this.expSeparatedButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.impExcelButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(784, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 688);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // suppliersList
            // 
            this.suppliersList.CheckOnClick = true;
            this.suppliersList.FormattingEnabled = true;
            this.suppliersList.Location = new System.Drawing.Point(7, 96);
            this.suppliersList.Name = "suppliersList";
            this.suppliersList.Size = new System.Drawing.Size(247, 184);
            this.suppliersList.TabIndex = 3;
            this.suppliersList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.suppliersList_ItemCheck);
            // 
            // appendExcelButton
            // 
            this.appendExcelButton.Location = new System.Drawing.Point(7, 593);
            this.appendExcelButton.Name = "appendExcelButton";
            this.appendExcelButton.Size = new System.Drawing.Size(247, 33);
            this.appendExcelButton.TabIndex = 8;
            this.appendExcelButton.Text = "Додати загальну специфікацію";
            this.appendExcelButton.UseVisualStyleBackColor = true;
            this.appendExcelButton.Click += new System.EventHandler(this.appendExcelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Виробники:";
            // 
            // expSingleButton
            // 
            this.expSingleButton.Location = new System.Drawing.Point(7, 515);
            this.expSingleButton.Name = "expSingleButton";
            this.expSingleButton.Size = new System.Drawing.Size(247, 33);
            this.expSingleButton.TabIndex = 6;
            this.expSingleButton.Text = "Зберегти загальну специфікацію";
            this.expSingleButton.UseVisualStyleBackColor = true;
            this.expSingleButton.Click += new System.EventHandler(this.expSingleMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 701);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecificationManager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToProjectButton;
        private System.Windows.Forms.Button expSeparatedButton;
        private System.Windows.Forms.Button impExcelButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ContractNumberField;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsBazisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impExcelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expSeparatedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToProjectMenuItem;
        private System.Windows.Forms.TextBox timeSpanFild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem appendExcelMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem detailOperationsMenu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox suppliersList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem editRastexMenu;
        private System.Windows.Forms.ToolStripMenuItem editRafixMenu;
        private System.Windows.Forms.ToolStripMenuItem editScrewsMenu;
        private System.Windows.Forms.ToolStripMenuItem setPathMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.Button appendExcelButton;
        private System.Windows.Forms.ToolStripMenuItem expSingleMenuItem;
        private System.Windows.Forms.Button expSingleButton;
    }
}

