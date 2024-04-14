namespace ChoosingBuildingMaterials
{
    partial class StoreForm
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
            this.components = new System.ComponentModel.Container();
            this.txtBxSecondName = new System.Windows.Forms.TextBox();
            this.secondName = new System.Windows.Forms.Label();
            this.txtBxRealAddress = new System.Windows.Forms.TextBox();
            this.realAddress = new System.Windows.Forms.Label();
            this.txtBxLegalAddress = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.legalAddress = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.fatherName = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxFatherName = new System.Windows.Forms.TextBox();
            this.director = new System.Windows.Forms.Label();
            this.txtBxPhoneNumber = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxSecondName
            // 
            this.txtBxSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxSecondName.Location = new System.Drawing.Point(157, 217);
            this.txtBxSecondName.MaxLength = 25;
            this.txtBxSecondName.Name = "txtBxSecondName";
            this.txtBxSecondName.Size = new System.Drawing.Size(575, 34);
            this.txtBxSecondName.TabIndex = 35;
            // 
            // secondName
            // 
            this.secondName.AutoSize = true;
            this.secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondName.Location = new System.Drawing.Point(21, 220);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(130, 29);
            this.secondName.TabIndex = 34;
            this.secondName.Text = "Фамилия:";
            this.secondName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBxRealAddress
            // 
            this.txtBxRealAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxRealAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxRealAddress.Location = new System.Drawing.Point(276, 86);
            this.txtBxRealAddress.MaxLength = 50;
            this.txtBxRealAddress.Name = "txtBxRealAddress";
            this.txtBxRealAddress.Size = new System.Drawing.Size(456, 34);
            this.txtBxRealAddress.TabIndex = 33;
            this.txtBxRealAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxName_Validating);
            // 
            // realAddress
            // 
            this.realAddress.AutoSize = true;
            this.realAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realAddress.Location = new System.Drawing.Point(36, 89);
            this.realAddress.Name = "realAddress";
            this.realAddress.Size = new System.Drawing.Size(235, 29);
            this.realAddress.TabIndex = 32;
            this.realAddress.Text = "Физический адрес:";
            this.realAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBxLegalAddress
            // 
            this.txtBxLegalAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxLegalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxLegalAddress.Location = new System.Drawing.Point(276, 46);
            this.txtBxLegalAddress.MaxLength = 50;
            this.txtBxLegalAddress.Name = "txtBxLegalAddress";
            this.txtBxLegalAddress.Size = new System.Drawing.Size(456, 34);
            this.txtBxLegalAddress.TabIndex = 31;
            // 
            // txtBxName
            // 
            this.txtBxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxName.Location = new System.Drawing.Point(276, 6);
            this.txtBxName.MaxLength = 50;
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(456, 34);
            this.txtBxName.TabIndex = 30;
            this.txtBxName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxName_Validating);
            // 
            // legalAddress
            // 
            this.legalAddress.AutoSize = true;
            this.legalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.legalAddress.Location = new System.Drawing.Point(20, 49);
            this.legalAddress.Name = "legalAddress";
            this.legalAddress.Size = new System.Drawing.Size(251, 29);
            this.legalAddress.TabIndex = 29;
            this.legalAddress.Text = "Юридический адрес:";
            this.legalAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(79, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(191, 29);
            this.name.TabIndex = 28;
            this.name.Text = "Наименование:";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.Location = new System.Drawing.Point(81, 257);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(70, 29);
            this.firstName.TabIndex = 36;
            this.firstName.Text = "Имя:";
            this.firstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatherName.Location = new System.Drawing.Point(23, 297);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(128, 29);
            this.fatherName.TabIndex = 37;
            this.fatherName.Text = "Отчество:";
            this.fatherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxFirstName.Location = new System.Drawing.Point(157, 257);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(575, 34);
            this.txtBxFirstName.TabIndex = 25;
            // 
            // txtBxFatherName
            // 
            this.txtBxFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxFatherName.Location = new System.Drawing.Point(157, 297);
            this.txtBxFatherName.Name = "txtBxFatherName";
            this.txtBxFatherName.Size = new System.Drawing.Size(575, 34);
            this.txtBxFatherName.TabIndex = 25;
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.director.Location = new System.Drawing.Point(24, 179);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(127, 29);
            this.director.TabIndex = 40;
            this.director.Text = "Директор";
            this.director.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBxPhoneNumber
            // 
            this.txtBxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxPhoneNumber.Location = new System.Drawing.Point(276, 126);
            this.txtBxPhoneNumber.MaxLength = 12;
            this.txtBxPhoneNumber.Name = "txtBxPhoneNumber";
            this.txtBxPhoneNumber.Size = new System.Drawing.Size(456, 34);
            this.txtBxPhoneNumber.TabIndex = 42;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(51, 126);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(219, 29);
            this.phoneNumber.TabIndex = 41;
            this.phoneNumber.Text = "Номер телефона:";
            this.phoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(478, 435);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(124, 44);
            this.Ok.TabIndex = 52;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(608, 435);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 44);
            this.Cancel.TabIndex = 51;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StoreForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(744, 490);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtBxPhoneNumber);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.director);
            this.Controls.Add(this.txtBxFatherName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.txtBxSecondName);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.txtBxRealAddress);
            this.Controls.Add(this.realAddress);
            this.Controls.Add(this.txtBxLegalAddress);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.legalAddress);
            this.Controls.Add(this.name);
            this.MinimumSize = new System.Drawing.Size(762, 537);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label secondName;
        private System.Windows.Forms.Label realAddress;
        private System.Windows.Forms.Label legalAddress;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label fatherName;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox txtBxSecondName;
        public System.Windows.Forms.TextBox txtBxRealAddress;
        public System.Windows.Forms.TextBox txtBxLegalAddress;
        public System.Windows.Forms.TextBox txtBxName;
        public System.Windows.Forms.TextBox txtBxFirstName;
        public System.Windows.Forms.TextBox txtBxFatherName;
        public System.Windows.Forms.TextBox txtBxPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}