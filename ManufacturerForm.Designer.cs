namespace ChoosingBuildingMaterials
{
    partial class ManufacturerForm
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
            this.txtBxContactInfo = new System.Windows.Forms.TextBox();
            this.contactInfo = new System.Windows.Forms.Label();
            this.txtBxOfficialSite = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.officialSite = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxContactInfo
            // 
            this.txtBxContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxContactInfo.Location = new System.Drawing.Point(12, 127);
            this.txtBxContactInfo.MaxLength = 500;
            this.txtBxContactInfo.Multiline = true;
            this.txtBxContactInfo.Name = "txtBxContactInfo";
            this.txtBxContactInfo.Size = new System.Drawing.Size(928, 293);
            this.txtBxContactInfo.TabIndex = 48;
            // 
            // contactInfo
            // 
            this.contactInfo.AutoSize = true;
            this.contactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactInfo.Location = new System.Drawing.Point(12, 95);
            this.contactInfo.Name = "contactInfo";
            this.contactInfo.Size = new System.Drawing.Size(306, 29);
            this.contactInfo.TabIndex = 47;
            this.contactInfo.Text = "Контактная информация:";
            this.contactInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBxOfficialSite
            // 
            this.txtBxOfficialSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxOfficialSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxOfficialSite.Location = new System.Drawing.Point(268, 52);
            this.txtBxOfficialSite.MaxLength = 255;
            this.txtBxOfficialSite.Name = "txtBxOfficialSite";
            this.txtBxOfficialSite.Size = new System.Drawing.Size(672, 34);
            this.txtBxOfficialSite.TabIndex = 46;
            // 
            // txtBxName
            // 
            this.txtBxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxName.Location = new System.Drawing.Point(268, 12);
            this.txtBxName.MaxLength = 255;
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(672, 34);
            this.txtBxName.TabIndex = 45;
            // 
            // officialSite
            // 
            this.officialSite.AutoSize = true;
            this.officialSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.officialSite.Location = new System.Drawing.Point(23, 55);
            this.officialSite.Name = "officialSite";
            this.officialSite.Size = new System.Drawing.Size(239, 29);
            this.officialSite.TabIndex = 44;
            this.officialSite.Text = "Официальный сайт:";
            this.officialSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(71, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(191, 29);
            this.name.TabIndex = 43;
            this.name.Text = "Наименование:";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(686, 423);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(124, 44);
            this.Ok.TabIndex = 50;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(816, 423);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 44);
            this.Cancel.TabIndex = 49;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 479);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtBxContactInfo);
            this.Controls.Add(this.contactInfo);
            this.Controls.Add(this.txtBxOfficialSite);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.officialSite);
            this.Controls.Add(this.name);
            this.Name = "ManufacturerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Производитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label contactInfo;
        private System.Windows.Forms.Label officialSite;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox txtBxContactInfo;
        public System.Windows.Forms.TextBox txtBxOfficialSite;
        public System.Windows.Forms.TextBox txtBxName;
    }
}