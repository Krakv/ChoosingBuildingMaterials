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
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void txtBxName_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox bx = sender as System.Windows.Forms.TextBox;
            if (bx != null)
            {
                if (bx.Text == "")
                {
                    errorProvider1.SetError(bx, "Поле должно быть непустое");
                    e.Cancel = true;
                }
                else
                    errorProvider1.SetError(bx, "");
            }
        }
    }
}