
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
            this.OpenExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SlitAndSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeGeneralSpecMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.detailOperationsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editRastexMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editRafixMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editScrewsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPathMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsBazisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeSpanFild = new System.Windows.Forms.TextBox();
            this.ContractNumberFild = new System.Windows.Forms.TextBox();
            this.ExportToProjectButton = new System.Windows.Forms.Button();
            this.SplitAndSaveButton = new System.Windows.Forms.Button();
            this.ImportExcelButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.suppliersList = new System.Windows.Forms.CheckedListBox();
            this.MergeToProjectButton = new System.Windows.Forms.Button();
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
            this.OpenExcelMenuItem,
            this.SlitAndSaveMenuItem,
            this.ExportToProjectMenuItem,
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
            // saveSpecMenuItem
            // 
            this.saveSpecMenuItem.Enabled = false;
            this.saveSpecMenuItem.Name = "saveSpecMenuItem";
            this.saveSpecMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveSpecMenuItem.Size = new System.Drawing.Size(336, 22);
            this.saveSpecMenuItem.Text = "Зберегти специфікацію";
            this.saveSpecMenuItem.Visible = false;
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
            // OpenExcelMenuItem
            // 
            this.OpenExcelMenuItem.Name = "OpenExcelMenuItem";
            this.OpenExcelMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.OpenExcelMenuItem.Size = new System.Drawing.Size(336, 22);
            this.OpenExcelMenuItem.Text = "Імпортувати загальну специфікацію";
            this.OpenExcelMenuItem.ToolTipText = "Імпорт файлу специфікації";
            this.OpenExcelMenuItem.Click += new System.EventHandler(this.ImporExcelMenuItem_Click);
            // 
            // SlitAndSaveMenuItem
            // 
            this.SlitAndSaveMenuItem.Name = "SlitAndSaveMenuItem";
            this.SlitAndSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.SlitAndSaveMenuItem.Size = new System.Drawing.Size(336, 22);
            this.SlitAndSaveMenuItem.Text = "Зберегти специфікації по виробникам";
            this.SlitAndSaveMenuItem.ToolTipText = "Зберегти специфікації в окремі файли";
            this.SlitAndSaveMenuItem.Click += new System.EventHandler(this.SlitAndSaveMenuItem_Click);
            // 
            // ExportToProjectMenuItem
            // 
            this.ExportToProjectMenuItem.Name = "ExportToProjectMenuItem";
            this.ExportToProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.ExportToProjectMenuItem.Size = new System.Drawing.Size(336, 22);
            this.ExportToProjectMenuItem.Text = "Експрт фурнітури у файл ViyarPRO";
            this.ExportToProjectMenuItem.ToolTipText = "Експортувати фурнітуру у файл ViyarPRO";
            this.ExportToProjectMenuItem.Click += new System.EventHandler(this.ExportToProjectMenuItem_Click);
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
            this.SetPathMenuItem,
            this.SettingsBazisMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.settingsMenuItem.Size = new System.Drawing.Size(101, 20);
            this.settingsMenuItem.Tag = "se";
            this.settingsMenuItem.Text = "Налаштування";
            this.settingsMenuItem.ToolTipText = "Налаштування і довідка";
            // 
            // SetPathMenuItem
            // 
            this.SetPathMenuItem.Name = "SetPathMenuItem";
            this.SetPathMenuItem.Size = new System.Drawing.Size(322, 22);
            this.SetPathMenuItem.Text = "Шлях до файлів";
            this.SetPathMenuItem.ToolTipText = "Шлях до теки шаблонів заміни";
            this.SetPathMenuItem.Click += new System.EventHandler(this.SetPathMenuItem_Click);
            // 
            // SettingsBazisMenuItem
            // 
            this.SettingsBazisMenuItem.Name = "SettingsBazisMenuItem";
            this.SettingsBazisMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.SettingsBazisMenuItem.Size = new System.Drawing.Size(322, 22);
            this.SettingsBazisMenuItem.Text = "Налаштування у \"Базис Мебельщик\"";
            this.SettingsBazisMenuItem.ToolTipText = "Налаштування в програмі \"Базис Мебельщик\" \r\nдля подальшого експорту специфікацій\r" +
    "\nу форматі *.xlsx";
            this.SettingsBazisMenuItem.Click += new System.EventHandler(this.SettingsBazisMenuItem_Click);
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
            // TimeSpanFild
            // 
            this.TimeSpanFild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeSpanFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TimeSpanFild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeSpanFild.Location = new System.Drawing.Point(6, 662);
            this.TimeSpanFild.Name = "TimeSpanFild";
            this.TimeSpanFild.ReadOnly = true;
            this.TimeSpanFild.Size = new System.Drawing.Size(244, 23);
            this.TimeSpanFild.TabIndex = 3;
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
            // ExportToProjectButton
            // 
            this.ExportToProjectButton.Location = new System.Drawing.Point(6, 515);
            this.ExportToProjectButton.Name = "ExportToProjectButton";
            this.ExportToProjectButton.Size = new System.Drawing.Size(247, 33);
            this.ExportToProjectButton.TabIndex = 6;
            this.ExportToProjectButton.Text = "Експрт фурнітури у файл ViyarPRO";
            this.ExportToProjectButton.UseVisualStyleBackColor = true;
            this.ExportToProjectButton.Click += new System.EventHandler(this.ExportToProjectButton_Click);
            // 
            // SplitAndSaveButton
            // 
            this.SplitAndSaveButton.Location = new System.Drawing.Point(6, 476);
            this.SplitAndSaveButton.Name = "SplitAndSaveButton";
            this.SplitAndSaveButton.Size = new System.Drawing.Size(247, 33);
            this.SplitAndSaveButton.TabIndex = 5;
            this.SplitAndSaveButton.Text = "Зберегти специфікації по виробникам";
            this.SplitAndSaveButton.UseVisualStyleBackColor = true;
            this.SplitAndSaveButton.Click += new System.EventHandler(this.SplitAndSaveButton_Click);
            // 
            // ImportExcelButton
            // 
            this.ImportExcelButton.Location = new System.Drawing.Point(7, 437);
            this.ImportExcelButton.Name = "ImportExcelButton";
            this.ImportExcelButton.Size = new System.Drawing.Size(247, 33);
            this.ImportExcelButton.TabIndex = 4;
            this.ImportExcelButton.Text = "Відкрити загальну специфікацію";
            this.ImportExcelButton.UseVisualStyleBackColor = true;
            this.ImportExcelButton.Click += new System.EventHandler(this.ImportExcelButton_Click);
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
            this.groupBox3.Controls.Add(this.TimeSpanFild);
            this.groupBox3.Controls.Add(this.ContractNumberFild);
            this.groupBox3.Controls.Add(this.MergeToProjectButton);
            this.groupBox3.Controls.Add(this.ExportToProjectButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.SplitAndSaveButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ImportExcelButton);
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
            // MergeToProjectButton
            // 
            this.MergeToProjectButton.Location = new System.Drawing.Point(7, 554);
            this.MergeToProjectButton.Name = "MergeToProjectButton";
            this.MergeToProjectButton.Size = new System.Drawing.Size(247, 33);
            this.MergeToProjectButton.TabIndex = 7;
            this.MergeToProjectButton.Text = "Додати загальну специфікацію";
            this.MergeToProjectButton.UseVisualStyleBackColor = true;
            this.MergeToProjectButton.Click += new System.EventHandler(this.MergeToProjectButton_Click);
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
        private System.Windows.Forms.Button ExportToProjectButton;
        private System.Windows.Forms.Button SplitAndSaveButton;
        private System.Windows.Forms.Button ImportExcelButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ContractNumberFild;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsBazisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenExcelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SlitAndSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToProjectMenuItem;
        private System.Windows.Forms.TextBox TimeSpanFild;
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
        private System.Windows.Forms.ToolStripMenuItem SetPathMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSpecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSpecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsSpecMenuItem;
        private System.Windows.Forms.Button MergeToProjectButton;
    }
}

