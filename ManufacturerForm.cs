﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosingBuildingMaterials
{
    public partial class ManufacturerForm : Form
    {
        public ManufacturerForm()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxName_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox bx = sender as System.Windows.Forms.TextBox;
            if (bx != null)
            {
                if (bx.Text == "")
                {
                    errorProvider1.SetError(bx, "Поле должно быть непустое");
                }
                else
                    errorProvider1.SetError(bx, "");
            }
        }

        private void ManufacturerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtBxName.Text == "" && DialogResult == DialogResult.OK)
            {
                MessageBox.Show(@"Не заполнено поле ""Название"" ", "Ошибка");
                e.Cancel = true;
            }
        }
    }
}
