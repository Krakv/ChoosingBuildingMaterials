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
            this.treeView = new System.Windows.Forms.TreeView();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DataBaseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeViewDataBase = new System.Windows.Forms.TreeView();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMaterialBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addStoreButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addManufacturerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpecialOfferBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.иерархияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 28);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(1511, 739);
            this.treeView.TabIndex = 1;
            // 
            // mainTable
            // 
            this.mainTable.AllowUserToAddRows = false;
            this.mainTable.AllowUserToDeleteRows = false;
            this.mainTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTable.ColumnHeadersHeight = 29;
            this.mainTable.Location = new System.Drawing.Point(329, 28);
            this.mainTable.Name = "mainTable";
            this.mainTable.ReadOnly = true;
            this.mainTable.RowHeadersVisible = false;
            this.mainTable.RowHeadersWidth = 51;
            this.mainTable.RowTemplate.Height = 24;
            this.mainTable.Size = new System.Drawing.Size(1182, 739);
            this.mainTable.TabIndex = 2;
            this.mainTable.DoubleClick += new System.EventHandler(this.mainTable_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view,
            this.DataBaseButton,
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1511, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DataBaseButton
            // 
            this.DataBaseButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataBase});
            this.DataBaseButton.Name = "DataBaseButton";
            this.DataBaseButton.Size = new System.Drawing.Size(111, 24);
            this.DataBaseButton.Text = "База данных";
            // 
            // loadDataBase
            // 
            this.loadDataBase.Name = "loadDataBase";
            this.loadDataBase.Size = new System.Drawing.Size(160, 26);
            this.loadDataBase.Text = "Загрузить";
            this.loadDataBase.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // TreeViewDataBase
            // 
            this.TreeViewDataBase.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeViewDataBase.Location = new System.Drawing.Point(0, 28);
            this.TreeViewDataBase.Name = "TreeViewDataBase";
            this.TreeViewDataBase.Size = new System.Drawing.Size(331, 739);
            this.TreeViewDataBase.TabIndex = 4;
            this.TreeViewDataBase.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDataBase_AfterCollapse);
            this.TreeViewDataBase.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewDataBase_BeforeSelect);
            this.TreeViewDataBase.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewDataBase_AfterSelect);
            this.TreeViewDataBase.DoubleClick += new System.EventHandler(this.TreeViewDataBase_DoubleClick);
            this.TreeViewDataBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMaterialBtn,
            this.addStoreButton,
            this.addManufacturerBtn,
            this.addSpecialOfferBtn});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // addMaterialBtn
            // 
            this.addMaterialBtn.Name = "addMaterialBtn";
            this.addMaterialBtn.Size = new System.Drawing.Size(286, 26);
            this.addMaterialBtn.Text = "Материал";
            this.addMaterialBtn.Click += new System.EventHandler(this.addMaterialBtn_Click);
            // 
            // addStoreButton
            // 
            this.addStoreButton.Name = "addStoreButton";
            this.addStoreButton.Size = new System.Drawing.Size(286, 26);
            this.addStoreButton.Text = "Магазин";
            this.addStoreButton.Click += new System.EventHandler(this.addStoreButton_Click);
            // 
            // addManufacturerBtn
            // 
            this.addManufacturerBtn.Name = "addManufacturerBtn";
            this.addManufacturerBtn.Size = new System.Drawing.Size(286, 26);
            this.addManufacturerBtn.Text = "Производитель";
            this.addManufacturerBtn.Click += new System.EventHandler(this.addManufacturerBtn_Click);
            // 
            // addSpecialOfferBtn
            // 
            this.addSpecialOfferBtn.Name = "addSpecialOfferBtn";
            this.addSpecialOfferBtn.Size = new System.Drawing.Size(286, 26);
            this.addSpecialOfferBtn.Text = "Специальное предложение";
            this.addSpecialOfferBtn.Click += new System.EventHandler(this.addSpecialOfferBtn_Click);
            // 
            // view
            // 
            this.view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иерархияToolStripMenuItem});
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(49, 24);
            this.view.Text = "Вид";
            // 
            // иерархияToolStripMenuItem
            // 
            this.иерархияToolStripMenuItem.Name = "иерархияToolStripMenuItem";
            this.иерархияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.иерархияToolStripMenuItem.Text = "Иерархия";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 767);
            this.Controls.Add(this.TreeViewDataBase);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Строительные материалы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DataBaseButton;
        private System.Windows.Forms.ToolStripMenuItem loadDataBase;
        private System.Windows.Forms.TreeView TreeViewDataBase;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMaterialBtn;
        private System.Windows.Forms.ToolStripMenuItem addStoreButton;
        private System.Windows.Forms.ToolStripMenuItem addManufacturerBtn;
        private System.Windows.Forms.ToolStripMenuItem addSpecialOfferBtn;
        private System.Windows.Forms.ToolStripMenuItem view;
        private System.Windows.Forms.ToolStripMenuItem иерархияToolStripMenuItem;
    }
}

