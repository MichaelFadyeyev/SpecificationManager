
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
            this.openSpecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSpecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsSpecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitAndSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeGeneralSpecMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ContractNumberFild = new System.Windows.Forms.TextBox();
            this.exportToProjectButton = new System.Windows.Forms.Button();
            this.splitAndSaveButton = new System.Windows.Forms.Button();
            this.importExcelButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.suppliersList = new System.Windows.Forms.CheckedListBox();
            this.mergeToProjectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.openSpecMenuItem,
            this.saveSpecMenuItem,
            this.saveAsSpecMenuItem,
            this.openExcelMenuItem,
            this.splitAndSaveMenuItem,
            this.exportToProjectMenuItem,
            this.mergeGeneralSpecMenu});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Tag = "fa";
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.ToolTipText = "Операції з файлами";
            // 
            // openSpecMenuItem
            // 
            this.openSpecMenuItem.Enabled = false;
            this.openSpecMenuItem.Name = "openSpecMenuItem";
            this.openSpecMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openSpecMenuItem.Size = new System.Drawing.Size(336, 22);
            this.openSpecMenuItem.Text = "Відкрити специфікацію";
            this.openSpecMenuItem.Visible = false;
            // 
            // saveSpecMenuItem_Click
            // 
            this.saveSpecMenuItem.Name = "saveSpecMenuItem_Click";
            this.saveSpecMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveSpecMenuItem.Size = new System.Drawing.Size(336, 22);
            this.saveSpecMenuItem.Text = "Зберегти специфікацію";
            this.saveSpecMenuItem.ToolTipText = "Зберегти специфікацію";
            this.saveSpecMenuItem.Click += new System.EventHandler(this.saveSpecMenuItem_Click);
            // 
            // saveAsSpecMenuItem
            // 
            this.saveAsSpecMenuItem.Enabled = false;
            this.saveAsSpecMenuItem.Name = "saveAsSpecMenuItem";
            this.saveAsSpecMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsSpecMenuItem.Size = new System.Drawing.Size(336, 22);
            this.saveAsSpecMenuItem.Text = "Зберегти специфікацію, як";
            this.saveAsSpecMenuItem.Visible = false;
            // 
            // openExcelMenuItem
            // 
            this.openExcelMenuItem.Name = "openExcelMenuItem";
            this.openExcelMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.openExcelMenuItem.Size = new System.Drawing.Size(336, 22);
            this.openExcelMenuItem.Text = "Імпортувати загальну специфікацію";
            this.openExcelMenuItem.ToolTipText = "Імпорт файлу специфікації";
            this.openExcelMenuItem.Click += new System.EventHandler(this.imporExcelMenuItem_Click);
            // 
            // splitAndSaveMenuItem
            // 
            this.splitAndSaveMenuItem.Name = "splitAndSaveMenuItem";
            this.splitAndSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.splitAndSaveMenuItem.Size = new System.Drawing.Size(336, 22);
            this.splitAndSaveMenuItem.Text = "Зберегти специфікації по виробникам";
            this.splitAndSaveMenuItem.ToolTipText = "Зберегти специфікації в окремі файли";
            this.splitAndSaveMenuItem.Click += new System.EventHandler(this.splitAndSaveMenuItem_Click);
            // 
            // exportToProjectMenuItem
            // 
            this.exportToProjectMenuItem.Name = "exportToProjectMenuItem";
            this.exportToProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exportToProjectMenuItem.Size = new System.Drawing.Size(336, 22);
            this.exportToProjectMenuItem.Text = "Експрт фурнітури у файл ViyarPRO";
            this.exportToProjectMenuItem.ToolTipText = "Експортувати фурнітуру у файл ViyarPRO";
            this.exportToProjectMenuItem.Click += new System.EventHandler(this.exportToProjectMenuItem_Click);
            // 
            // mergeGeneralSpecMenu
            // 
            this.mergeGeneralSpecMenu.Name = "mergeGeneralSpecMenu";
            this.mergeGeneralSpecMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mergeGeneralSpecMenu.Size = new System.Drawing.Size(336, 22);
            this.mergeGeneralSpecMenu.Text = "Додати загальну специфікацію";
            this.mergeGeneralSpecMenu.ToolTipText = "Додати специфікацію до відкритої";
            this.mergeGeneralSpecMenu.Click += new System.EventHandler(this.mergeGeneralSpecMenu_Click);
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
            // ContractNumberFild
            // 
            this.ContractNumberFild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractNumberFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ContractNumberFild.Location = new System.Drawing.Point(6, 32);
            this.ContractNumberFild.Name = "ContractNumberFild";
            this.ContractNumberFild.ReadOnly = true;
            this.ContractNumberFild.Size = new System.Drawing.Size(249, 23);
            this.ContractNumberFild.TabIndex = 2;
            this.ContractNumberFild.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exportToProjectButton
            // 
            this.exportToProjectButton.Location = new System.Drawing.Point(6, 515);
            this.exportToProjectButton.Name = "exportToProjectButton";
            this.exportToProjectButton.Size = new System.Drawing.Size(247, 33);
            this.exportToProjectButton.TabIndex = 6;
            this.exportToProjectButton.Text = "Експрт фурнітури у файл ViyarPRO";
            this.exportToProjectButton.UseVisualStyleBackColor = true;
            this.exportToProjectButton.Click += new System.EventHandler(this.exportToProjectButton_Click);
            // 
            // splitAndSaveButton
            // 
            this.splitAndSaveButton.Location = new System.Drawing.Point(6, 476);
            this.splitAndSaveButton.Name = "splitAndSaveButton";
            this.splitAndSaveButton.Size = new System.Drawing.Size(247, 33);
            this.splitAndSaveButton.TabIndex = 5;
            this.splitAndSaveButton.Text = "Зберегти специфікації по виробникам";
            this.splitAndSaveButton.UseVisualStyleBackColor = true;
            this.splitAndSaveButton.Click += new System.EventHandler(this.splitAndSaveButton_Click);
            // 
            // importExcelButton
            // 
            this.importExcelButton.Location = new System.Drawing.Point(7, 437);
            this.importExcelButton.Name = "importExcelButton";
            this.importExcelButton.Size = new System.Drawing.Size(247, 33);
            this.importExcelButton.TabIndex = 4;
            this.importExcelButton.Text = "Відкрити загальну специфікацію";
            this.importExcelButton.UseVisualStyleBackColor = true;
            this.importExcelButton.Click += new System.EventHandler(this.importExcelButton_Click);
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
            this.groupBox3.Controls.Add(this.ContractNumberFild);
            this.groupBox3.Controls.Add(this.mergeToProjectButton);
            this.groupBox3.Controls.Add(this.exportToProjectButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.splitAndSaveButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.importExcelButton);
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
            // mergeToProjectButton
            // 
            this.mergeToProjectButton.Location = new System.Drawing.Point(7, 554);
            this.mergeToProjectButton.Name = "mergeToProjectButton";
            this.mergeToProjectButton.Size = new System.Drawing.Size(247, 33);
            this.mergeToProjectButton.TabIndex = 7;
            this.mergeToProjectButton.Text = "Додати загальну специфікацію";
            this.mergeToProjectButton.UseVisualStyleBackColor = true;
            this.mergeToProjectButton.Click += new System.EventHandler(this.mergeToProjectButton_Click);
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
        private System.Windows.Forms.Button exportToProjectButton;
        private System.Windows.Forms.Button splitAndSaveButton;
        private System.Windows.Forms.Button importExcelButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ContractNumberFild;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsBazisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExcelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitAndSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToProjectMenuItem;
        private System.Windows.Forms.TextBox timeSpanFild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mergeGeneralSpecMenu;
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
        private System.Windows.Forms.ToolStripMenuItem openSpecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSpecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsSpecMenuItem;
        private System.Windows.Forms.Button mergeToProjectButton;
    }
}

