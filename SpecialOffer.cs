using System;
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
    public partial class SpecialOffer : Form
    {
        public SpecialOffer()
        {
            InitializeComponent();
        }

        private void addManufacturer_Click(object sender, EventArgs e)
        {
            ManufacturerForm form = new ManufacturerForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                int index = 0;
                string[] values = new string[4];
                values[index++] = "";
                values[index++] = form.txtBxName.Text;
                values[index++] = form.txtBxOfficialSite.Text;
                values[index++] = form.txtBxContactInfo.Text;
                SQLQuery.Add("manufacturers", values);
                List<string[]> manufacturers = SQLQuery.ReadManufacturers();
                cmbBxManufacturer.Items.Clear();
                foreach (string[] item in manufacturers)
                {
                    cmbBxManufacturer.Items.Add(item[1]);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
