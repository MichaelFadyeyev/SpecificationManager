
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.impExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendExcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.expSeparatedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expSingleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addToProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.articleField = new System.Windows.Forms.TextBox();
            this.addToProjectButton = new System.Windows.Forms.Button();
            this.expSeparatedButton = new System.Windows.Forms.Button();
            this.impExcelButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.articleSaveBtn = new System.Windows.Forms.Button();
            this.articleEditBtn = new System.Windows.Forms.Button();
            this.suppliersList = new System.Windows.Forms.CheckedListBox();
            this.appendExcelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.expSingleButton = new System.Windows.Forms.Button();
            this.buttonsGroup = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.buttonsGroup.SuspendLayout();
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
            this.toolStripSeparator1,
            this.impExcelMenuItem,
            this.appendExcelMenu,
            this.expSeparatedMenuItem,
            this.expSingleMenuItem,
            this.toolStripSeparator2,
            this.addToProjectMenuItem,
            this.toolStripSeparator3,
            this.closeMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Tag = "fa";
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.ToolTipText = "Операції з файлами";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(354, 22);
            this.openMenuItem.Text = "Відкрити специфікацію";
            this.openMenuItem.ToolTipText = "Відкрити специфікацію";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(354, 22);
            this.saveMenuItem.Text = "Зберегти специфікацію";
            this.saveMenuItem.ToolTipText = "Зберегти специфікацію";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(354, 22);
            this.saveAsMenuItem.Text = "Зберегти специфікацію як";
            this.saveAsMenuItem.ToolTipText = "Зберегти специфікацію як";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(351, 6);
            // 
            // impExcelMenuItem
            // 
            this.impExcelMenuItem.Name = "impExcelMenuItem";
            this.impExcelMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.impExcelMenuItem.Size = new System.Drawing.Size(354, 22);
            this.impExcelMenuItem.Text = "Імпортувати загальну специфікацію";
            this.impExcelMenuItem.ToolTipText = "Імпорт файлу специфікації";
            this.impExcelMenuItem.Click += new System.EventHandler(this.impExcelMenuItem_Click);
            // 
            // appendExcelMenu
            // 
            this.appendExcelMenu.Name = "appendExcelMenu";
            this.appendExcelMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.appendExcelMenu.Size = new System.Drawing.Size(354, 22);
            this.appendExcelMenu.Text = "Додати загальну специфікацію";
            this.appendExcelMenu.ToolTipText = "Додати специфікацію до відкритої";
            this.appendExcelMenu.Click += new System.EventHandler(this.appendExcelMenu_Click);
            // 
            // expSeparatedMenuItem
            // 
            this.expSeparatedMenuItem.Name = "expSeparatedMenuItem";
            this.expSeparatedMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.expSeparatedMenuItem.Size = new System.Drawing.Size(354, 22);
            this.expSeparatedMenuItem.Text = "Експортувати специфікації за виробниками";
            this.expSeparatedMenuItem.ToolTipText = "Експортувати специфікації по виробникам";
            this.expSeparatedMenuItem.Click += new System.EventHandler(this.expSeparatedMenuItem_Click);
            // 
            // expSingleMenuItem
            // 
            this.expSingleMenuItem.Name = "expSingleMenuItem";
            this.expSingleMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.expSingleMenuItem.Size = new System.Drawing.Size(354, 22);
            this.expSingleMenuItem.Text = "Експортувати загальну специфікацію";
            this.expSingleMenuItem.ToolTipText = "Експортувати загальну специфікацію";
            this.expSingleMenuItem.Click += new System.EventHandler(this.expSingleMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(351, 6);
            // 
            // addToProjectMenuItem
            // 
            this.addToProjectMenuItem.Name = "addToProjectMenuItem";
            this.addToProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.addToProjectMenuItem.Size = new System.Drawing.Size(354, 22);
            this.addToProjectMenuItem.Text = "Додати фурнітуру у файл ViyarPRO";
            this.addToProjectMenuItem.ToolTipText = "Додати фурнітуру у файл ViyarPRO";
            this.addToProjectMenuItem.Click += new System.EventHandler(this.addToProjectMenuItem_Click);
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
            this.timeSpanFild.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeSpanFild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeSpanFild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeSpanFild.Location = new System.Drawing.Point(3, 662);
            this.timeSpanFild.Name = "timeSpanFild";
            this.timeSpanFild.ReadOnly = true;
            this.timeSpanFild.Size = new System.Drawing.Size(254, 23);
            this.timeSpanFild.TabIndex = 3;
            // 
            // articleField
            // 
            this.articleField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.articleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.articleField.Location = new System.Drawing.Point(6, 32);
            this.articleField.Name = "articleField";
            this.articleField.ReadOnly = true;
            this.articleField.Size = new System.Drawing.Size(249, 23);
            this.articleField.TabIndex = 2;
            this.articleField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addToProjectButton
            // 
            this.addToProjectButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addToProjectButton.Location = new System.Drawing.Point(3, 300);
            this.addToProjectButton.Name = "addToProjectButton";
            this.addToProjectButton.Size = new System.Drawing.Size(248, 33);
            this.addToProjectButton.TabIndex = 7;
            this.addToProjectButton.Text = "Додати фурнітуру у файл ViyarPRO";
            this.addToProjectButton.UseVisualStyleBackColor = true;
            this.addToProjectButton.Click += new System.EventHandler(this.addToProjectButton_Click);
            // 
            // expSeparatedButton
            // 
            this.expSeparatedButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expSeparatedButton.Location = new System.Drawing.Point(3, 234);
            this.expSeparatedButton.Name = "expSeparatedButton";
            this.expSeparatedButton.Size = new System.Drawing.Size(248, 33);
            this.expSeparatedButton.TabIndex = 5;
            this.expSeparatedButton.Text = "Експортувати специфікації за виробниками";
            this.expSeparatedButton.UseVisualStyleBackColor = true;
            this.expSeparatedButton.Click += new System.EventHandler(this.expSeparatedButton_Click);
            // 
            // impExcelButton
            // 
            this.impExcelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.impExcelButton.Location = new System.Drawing.Point(3, 168);
            this.impExcelButton.Name = "impExcelButton";
            this.impExcelButton.Size = new System.Drawing.Size(248, 33);
            this.impExcelButton.TabIndex = 4;
            this.impExcelButton.Text = "Імпортувати загальну специфікацію";
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
            this.groupBox3.Controls.Add(this.buttonsGroup);
            this.groupBox3.Controls.Add(this.articleSaveBtn);
            this.groupBox3.Controls.Add(this.articleEditBtn);
            this.groupBox3.Controls.Add(this.suppliersList);
            this.groupBox3.Controls.Add(this.timeSpanFild);
            this.groupBox3.Controls.Add(this.articleField);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(784, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 688);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // articleSaveBtn
            // 
            this.articleSaveBtn.Enabled = false;
            this.articleSaveBtn.Location = new System.Drawing.Point(146, 61);
            this.articleSaveBtn.Name = "articleSaveBtn";
            this.articleSaveBtn.Size = new System.Drawing.Size(110, 33);
            this.articleSaveBtn.TabIndex = 101;
            this.articleSaveBtn.Text = "Зберегти";
            this.articleSaveBtn.UseVisualStyleBackColor = true;
            this.articleSaveBtn.Click += new System.EventHandler(this.articleSaveBtn_Click);
            // 
            // articleEditBtn
            // 
            this.articleEditBtn.Location = new System.Drawing.Point(5, 61);
            this.articleEditBtn.Name = "articleEditBtn";
            this.articleEditBtn.Size = new System.Drawing.Size(110, 33);
            this.articleEditBtn.TabIndex = 101;
            this.articleEditBtn.Text = "Редагувати";
            this.articleEditBtn.UseVisualStyleBackColor = true;
            this.articleEditBtn.Click += new System.EventHandler(this.articleEditBtn_Click);
            // 
            // suppliersList
            // 
            this.suppliersList.CheckOnClick = true;
            this.suppliersList.FormattingEnabled = true;
            this.suppliersList.Location = new System.Drawing.Point(7, 136);
            this.suppliersList.Name = "suppliersList";
            this.suppliersList.Size = new System.Drawing.Size(247, 184);
            this.suppliersList.TabIndex = 3;
            this.suppliersList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.suppliersList_ItemCheck);
            // 
            // appendExcelButton
            // 
            this.appendExcelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appendExcelButton.Location = new System.Drawing.Point(3, 201);
            this.appendExcelButton.Name = "appendExcelButton";
            this.appendExcelButton.Size = new System.Drawing.Size(248, 33);
            this.appendExcelButton.TabIndex = 8;
            this.appendExcelButton.Text = "Додати загальну специфікацію";
            this.appendExcelButton.UseVisualStyleBackColor = true;
            this.appendExcelButton.Click += new System.EventHandler(this.appendExcelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Виробники:";
            // 
            // expSingleButton
            // 
            this.expSingleButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expSingleButton.Location = new System.Drawing.Point(3, 267);
            this.expSingleButton.Name = "expSingleButton";
            this.expSingleButton.Size = new System.Drawing.Size(248, 33);
            this.expSingleButton.TabIndex = 6;
            this.expSingleButton.Text = "Експортувати загальну специфікацію";
            this.expSingleButton.UseVisualStyleBackColor = true;
            this.expSingleButton.Click += new System.EventHandler(this.expSingleMenuItem_Click);
            // 
            // buttonsGroup
            // 
            this.buttonsGroup.Controls.Add(this.impExcelButton);
            this.buttonsGroup.Controls.Add(this.appendExcelButton);
            this.buttonsGroup.Controls.Add(this.expSeparatedButton);
            this.buttonsGroup.Controls.Add(this.expSingleButton);
            this.buttonsGroup.Controls.Add(this.addToProjectButton);
            this.buttonsGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsGroup.Location = new System.Drawing.Point(3, 326);
            this.buttonsGroup.Name = "buttonsGroup";
            this.buttonsGroup.Size = new System.Drawing.Size(254, 336);
            this.buttonsGroup.TabIndex = 102;
            this.buttonsGroup.TabStop = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(351, 6);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeMenuItem.Size = new System.Drawing.Size(354, 22);
            this.closeMenuItem.Text = "Закрити Специфікацію";
            this.closeMenuItem.ToolTipText = "Закрити Специфікацію";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
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
            this.buttonsGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToProjectButton;
        private System.Windows.Forms.Button expSeparatedButton;
        private System.Windows.Forms.Button impExcelButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox articleField;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button articleSaveBtn;
        private System.Windows.Forms.Button articleEditBtn;
        private System.Windows.Forms.GroupBox buttonsGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
    }
}

