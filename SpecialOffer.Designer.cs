namespace ChoosingBuildingMaterials
{
    partial class SpecialOffer
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
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.Label();
            this.cmbBxManufacturer = new System.Windows.Forms.ComboBox();
            this.addManufacturer = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxDescription.Location = new System.Drawing.Point(12, 88);
            this.txtBxDescription.MaxLength = 1000;
            this.txtBxDescription.Multiline = true;
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(772, 300);
            this.txtBxDescription.TabIndex = 54;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(12, 56);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(131, 29);
            this.description.TabIndex = 53;
            this.description.Text = "Описание:";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSize = true;
            this.manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturer.Location = new System.Drawing.Point(12, 14);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(196, 29);
            this.manufacturer.TabIndex = 49;
            this.manufacturer.Text = "Производитель:";
            this.manufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBxManufacturer
            // 
            this.cmbBxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBxManufacturer.FormattingEnabled = true;
            this.cmbBxManufacturer.Location = new System.Drawing.Point(209, 11);
            this.cmbBxManufacturer.Name = "cmbBxManufacturer";
            this.cmbBxManufacturer.Size = new System.Drawing.Size(456, 37);
            this.cmbBxManufacturer.TabIndex = 55;
            // 
            // addManufacturer
            // 
            this.addManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addManufacturer.Location = new System.Drawing.Point(671, 11);
            this.addManufacturer.Name = "addManufacturer";
            this.addManufacturer.Size = new System.Drawing.Size(113, 37);
            this.addManufacturer.TabIndex = 56;
            this.addManufacturer.Text = "Добавить";
            this.addManufacturer.UseVisualStyleBackColor = true;
            this.addManufacturer.Click += new System.EventHandler(this.addManufacturer_Click);
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(530, 394);
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
            this.Cancel.Location = new System.Drawing.Point(660, 394);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 44);
            this.Cancel.TabIndex = 57;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SpecialOffer
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.addManufacturer);
            this.Controls.Add(this.cmbBxManufacturer);
            this.Controls.Add(this.txtBxDescription);
            this.Controls.Add(this.description);
            this.Controls.Add(this.manufacturer);
            this.Name = "SpecialOffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Специальное предложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label manufacturer;
        public System.Windows.Forms.TextBox txtBxDescription;
        public System.Windows.Forms.ComboBox cmbBxManufacturer;
        private System.Windows.Forms.Button addManufacturer;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}