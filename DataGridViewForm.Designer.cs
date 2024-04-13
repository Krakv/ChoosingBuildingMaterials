namespace ChoosingBuildingMaterials
{
    partial class DataGridViewForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchLabel = new System.Windows.Forms.ToolStripTextBox();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.countBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.offsetBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(932, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchLabel,
            this.searchBox,
            this.toolStripTextBox1,
            this.countBox,
            this.toolStripTextBox2,
            this.offsetBox,
            this.searchButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.ReadOnly = true;
            this.searchLabel.Size = new System.Drawing.Size(52, 27);
            this.searchLabel.Text = "Поиск:";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(170, 27);
            this.toolStripTextBox1.Text = "Количество элементов:";
            // 
            // countBox
            // 
            this.countBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(100, 27);
            this.countBox.Text = "50";
            this.countBox.Validating += new System.ComponentModel.CancelEventHandler(this.countBox_Validating);
            this.countBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(85, 27);
            this.toolStripTextBox2.Text = "Смещение:";
            // 
            // offsetBox
            // 
            this.offsetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offsetBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.offsetBox.Name = "offsetBox";
            this.offsetBox.Size = new System.Drawing.Size(100, 27);
            this.offsetBox.Text = "0";
            this.offsetBox.Validating += new System.ComponentModel.CancelEventHandler(this.countBox_Validating);
            this.offsetBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(165, 27);
            this.searchButton.Text = "Осуществить запрос";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(304, 62);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(623, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(306, 62);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(313, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(304, 62);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 512);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 68);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // DataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(787, 497);
            this.Name = "DataGridViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataGridViewForm";
            this.Load += new System.EventHandler(this.DataGridViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox searchLabel;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem searchButton;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox countBox;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox offsetBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}