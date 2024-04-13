namespace ChoosingBuildingMaterials
{
    partial class SubcatalogForm
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
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.catalog = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.subcatalog = new System.Windows.Forms.Label();
            this.catalogCmbBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBxName
            // 
            this.txtBxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxName.Location = new System.Drawing.Point(172, 220);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(616, 34);
            this.txtBxName.TabIndex = 60;
            // 
            // catalog
            // 
            this.catalog.AutoSize = true;
            this.catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalog.Location = new System.Drawing.Point(53, 165);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(111, 29);
            this.catalog.TabIndex = 59;
            this.catalog.Text = "Каталог:";
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(534, 394);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(124, 44);
            this.Ok.TabIndex = 58;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(664, 394);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 44);
            this.Cancel.TabIndex = 57;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // subcatalog
            // 
            this.subcatalog.AutoSize = true;
            this.subcatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subcatalog.Location = new System.Drawing.Point(12, 223);
            this.subcatalog.Name = "subcatalog";
            this.subcatalog.Size = new System.Drawing.Size(152, 29);
            this.subcatalog.TabIndex = 61;
            this.subcatalog.Text = "Подкаталог:";
            // 
            // catalogCmbBx
            // 
            this.catalogCmbBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogCmbBx.FormattingEnabled = true;
            this.catalogCmbBx.Location = new System.Drawing.Point(172, 165);
            this.catalogCmbBx.Name = "catalogCmbBx";
            this.catalogCmbBx.Size = new System.Drawing.Size(616, 33);
            this.catalogCmbBx.TabIndex = 62;
            // 
            // SubcatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catalogCmbBx);
            this.Controls.Add(this.subcatalog);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Name = "SubcatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubcatalogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label catalog;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label subcatalog;
        public System.Windows.Forms.ComboBox catalogCmbBx;
    }
}