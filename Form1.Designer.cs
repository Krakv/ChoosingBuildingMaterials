namespace ChoosingBuildingMaterials
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.filterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTablesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMaterialsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTagButton = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStores = new System.Windows.Forms.ToolStripMenuItem();
            this.changeManufacturers = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCatalogs = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSubcatalogs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.adminEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.helper = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeViewDataBase = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.filterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.acceptButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.materialInfoPanel = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.closeMaterialInfoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.materialInfoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerInfoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.storesInfoBtn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.filterTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.materialInfoPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 32);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(1515, 732);
            this.treeView.TabIndex = 1;
            // 
            // mainTable
            // 
            this.mainTable.AllowUserToAddRows = false;
            this.mainTable.AllowUserToDeleteRows = false;
            this.mainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTable.ColumnHeadersHeight = 29;
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.MultiSelect = false;
            this.mainTable.Name = "mainTable";
            this.mainTable.ReadOnly = true;
            this.mainTable.RowHeadersVisible = false;
            this.mainTable.RowHeadersWidth = 51;
            this.mainTable.RowTemplate.Height = 24;
            this.mainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTable.Size = new System.Drawing.Size(1102, 732);
            this.mainTable.TabIndex = 6;
            this.mainTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTable_CellDoubleClick);
            this.mainTable.Click += new System.EventHandler(this.mainTable_Click);
            this.mainTable.DoubleClick += new System.EventHandler(this.mainTable_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.catalogsButton,
            this.filterButton,
            this.changeTablesButton,
            this.toolStripTextBox2,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.searchBox,
            this.searchButton,
            this.adminEnter,
            this.exitButton,
            this.aboutProgram,
            this.helper});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1515, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportButton});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 28);
            this.fileMenuItem.Text = "Файл";
            // 
            // exportButton
            // 
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(148, 26);
            this.exportButton.Text = "Экспорт";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // catalogsButton
            // 
            this.catalogsButton.Name = "catalogsButton";
            this.catalogsButton.Size = new System.Drawing.Size(86, 28);
            this.catalogsButton.Text = "Каталоги";
            this.catalogsButton.Click += new System.EventHandler(this.catalogsButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(74, 28);
            this.filterButton.Text = "Фильтр";
            this.filterButton.Click += new System.EventHandler(this.фильтрToolStripMenuItem_Click);
            // 
            // changeTablesButton
            // 
            this.changeTablesButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeMaterialsButton,
            this.changeTagButton,
            this.changeStores,
            this.changeManufacturers,
            this.changeCatalogs,
            this.changeSubcatalogs});
            this.changeTablesButton.Enabled = false;
            this.changeTablesButton.Name = "changeTablesButton";
            this.changeTablesButton.Size = new System.Drawing.Size(188, 28);
            this.changeTablesButton.Text = "Внести изменения в БД";
            this.changeTablesButton.Visible = false;
            // 
            // changeMaterialsButton
            // 
            this.changeMaterialsButton.Name = "changeMaterialsButton";
            this.changeMaterialsButton.Size = new System.Drawing.Size(202, 26);
            this.changeMaterialsButton.Text = "Материалы";
            this.changeMaterialsButton.Click += new System.EventHandler(this.changeMaterialsButton_Click);
            // 
            // changeTagButton
            // 
            this.changeTagButton.Name = "changeTagButton";
            this.changeTagButton.Size = new System.Drawing.Size(202, 26);
            this.changeTagButton.Text = "Теги";
            this.changeTagButton.Click += new System.EventHandler(this.changeTagButton_Click);
            // 
            // changeStores
            // 
            this.changeStores.Name = "changeStores";
            this.changeStores.Size = new System.Drawing.Size(202, 26);
            this.changeStores.Text = "Магазины";
            this.changeStores.Click += new System.EventHandler(this.changeStores_Click);
            // 
            // changeManufacturers
            // 
            this.changeManufacturers.Name = "changeManufacturers";
            this.changeManufacturers.Size = new System.Drawing.Size(202, 26);
            this.changeManufacturers.Text = "Производители";
            this.changeManufacturers.Click += new System.EventHandler(this.changeManufacturers_Click);
            // 
            // changeCatalogs
            // 
            this.changeCatalogs.Name = "changeCatalogs";
            this.changeCatalogs.Size = new System.Drawing.Size(202, 26);
            this.changeCatalogs.Text = "Каталоги";
            this.changeCatalogs.Click += new System.EventHandler(this.changeCatalogs_Click);
            // 
            // changeSubcatalogs
            // 
            this.changeSubcatalogs.Name = "changeSubcatalogs";
            this.changeSubcatalogs.Size = new System.Drawing.Size(202, 26);
            this.changeSubcatalogs.Text = "Подкаталоги";
            this.changeSubcatalogs.Click += new System.EventHandler(this.changeSubcatalogs_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox2.Text = "Сортировка:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox1.DropDownWidth = 270;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Название",
            "Минимальная стоимость (по возр)",
            "Минимальная стоимость (по убыв)",
            "Количество (по возр)",
            "Количество (по убыв)"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(100, 28);
            this.toolStripComboBox1.Text = "Название";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 28);
            this.toolStripTextBox1.Text = "Поиск:";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 28);
            this.searchBox.ToolTipText = "Введите ключевое слово";
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(34, 28);
            this.searchButton.Text = "Поиск";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // adminEnter
            // 
            this.adminEnter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminEnter.Name = "adminEnter";
            this.adminEnter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminEnter.Size = new System.Drawing.Size(103, 28);
            this.adminEnter.Text = "Сотруднику";
            this.adminEnter.Click += new System.EventHandler(this.adminEnter_Click);
            // 
            // exitButton
            // 
            this.exitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitButton.Enabled = false;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(67, 28);
            this.exitButton.Text = "Выход";
            this.exitButton.Visible = false;
            // 
            // aboutProgram
            // 
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(118, 28);
            this.aboutProgram.Text = "О программе";
            // 
            // helper
            // 
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(81, 28);
            this.helper.Text = "Справка";
            // 
            // TreeViewDataBase
            // 
            this.TreeViewDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeViewDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeViewDataBase.Location = new System.Drawing.Point(0, 0);
            this.TreeViewDataBase.Name = "TreeViewDataBase";
            this.TreeViewDataBase.ShowPlusMinus = false;
            this.TreeViewDataBase.ShowRootLines = false;
            this.TreeViewDataBase.Size = new System.Drawing.Size(200, 732);
            this.TreeViewDataBase.TabIndex = 4;
            this.TreeViewDataBase.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDataBase_AfterCollapse);
            this.TreeViewDataBase.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewDataBase_BeforeExpand);
            this.TreeViewDataBase.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDataBase_AfterExpand);
            this.TreeViewDataBase.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewDataBase_BeforeSelect);
            this.TreeViewDataBase.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDataBase_AfterSelect);
            this.TreeViewDataBase.DoubleClick += new System.EventHandler(this.TreeViewDataBase_DoubleClick);
            this.TreeViewDataBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 800;
            this.splitContainer1.Size = new System.Drawing.Size(1515, 732);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.TreeViewDataBase);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.filterTableLayoutPanel);
            this.splitContainer3.Size = new System.Drawing.Size(409, 732);
            this.splitContainer3.SplitterDistance = 200;
            this.splitContainer3.TabIndex = 0;
            // 
            // filterTableLayoutPanel
            // 
            this.filterTableLayoutPanel.ColumnCount = 1;
            this.filterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterTableLayoutPanel.Controls.Add(this.acceptButton, 0, 1);
            this.filterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.filterTableLayoutPanel.Name = "filterTableLayoutPanel";
            this.filterTableLayoutPanel.RowCount = 2;
            this.filterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.filterTableLayoutPanel.Size = new System.Drawing.Size(205, 732);
            this.filterTableLayoutPanel.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptButton.Location = new System.Drawing.Point(3, 685);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(199, 44);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.MinimumSize = new System.Drawing.Size(526, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.mainTable);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.materialInfoPanel);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Panel2MinSize = 500;
            this.splitContainer2.Size = new System.Drawing.Size(1102, 732);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 7;
            // 
            // materialInfoPanel
            // 
            this.materialInfoPanel.Controls.Add(this.menuStrip2);
            this.materialInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.materialInfoPanel.MinimumSize = new System.Drawing.Size(530, 530);
            this.materialInfoPanel.Name = "materialInfoPanel";
            this.materialInfoPanel.Size = new System.Drawing.Size(530, 530);
            this.materialInfoPanel.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMaterialInfoBtn,
            this.materialInfoBtn,
            this.manufacturerInfoBtn,
            this.storesInfoBtn});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(530, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // closeMaterialInfoBtn
            // 
            this.closeMaterialInfoBtn.Name = "closeMaterialInfoBtn";
            this.closeMaterialInfoBtn.Size = new System.Drawing.Size(80, 24);
            this.closeMaterialInfoBtn.Text = "Закрыть";
            this.closeMaterialInfoBtn.Click += new System.EventHandler(this.closeMaterialInfoBtn_Click);
            // 
            // materialInfoBtn
            // 
            this.materialInfoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.materialInfoBtn.Name = "materialInfoBtn";
            this.materialInfoBtn.Size = new System.Drawing.Size(208, 24);
            this.materialInfoBtn.Text = "Информация о материале";
            this.materialInfoBtn.Click += new System.EventHandler(this.materialInfoBtn_Click);
            // 
            // manufacturerInfoBtn
            // 
            this.manufacturerInfoBtn.Name = "manufacturerInfoBtn";
            this.manufacturerInfoBtn.Size = new System.Drawing.Size(132, 24);
            this.manufacturerInfoBtn.Text = "Производитель";
            this.manufacturerInfoBtn.Click += new System.EventHandler(this.manufacturerInfoBtn_Click);
            // 
            // storesInfoBtn
            // 
            this.storesInfoBtn.Name = "storesInfoBtn";
            this.storesInfoBtn.Size = new System.Drawing.Size(94, 24);
            this.storesInfoBtn.Text = "Магазины";
            this.storesInfoBtn.Click += new System.EventHandler(this.storesInfoBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1515, 764);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Строительные материалы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.filterTableLayoutPanel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.materialInfoPanel.ResumeLayout(false);
            this.materialInfoPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView TreeViewDataBase;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel materialInfoPanel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem closeMaterialInfoBtn;
        private System.Windows.Forms.ToolStripMenuItem materialInfoBtn;
        private System.Windows.Forms.ToolStripMenuItem manufacturerInfoBtn;
        private System.Windows.Forms.ToolStripMenuItem storesInfoBtn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem searchButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStripMenuItem filterButton;
        private System.Windows.Forms.ToolStripMenuItem catalogsButton;
        private System.Windows.Forms.TableLayoutPanel filterTableLayoutPanel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ToolStripMenuItem changeTablesButton;
        private System.Windows.Forms.ToolStripMenuItem changeMaterialsButton;
        private System.Windows.Forms.ToolStripMenuItem changeTagButton;
        private System.Windows.Forms.ToolStripMenuItem changeStores;
        private System.Windows.Forms.ToolStripMenuItem changeManufacturers;
        private System.Windows.Forms.ToolStripMenuItem changeCatalogs;
        private System.Windows.Forms.ToolStripMenuItem changeSubcatalogs;
        private System.Windows.Forms.ToolStripMenuItem adminEnter;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportButton;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram;
        private System.Windows.Forms.ToolStripMenuItem helper;
    }
}

