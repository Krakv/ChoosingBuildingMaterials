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
    public partial class ManufacturerInfo : Form
    {
        DataGridViewRow Row {  get; set; }
        public ManufacturerInfo(DataGridViewRow row)
        {
            InitializeComponent();
            Row = row;
            InitializeInfo();
        }

        private void InitializeInfo()
        {
            List<string[]> manufacturers = SQLQuery.ReadManufacturers($" AND manufacturer_number = {Row.Cells[9].Value} ");
            textBox1.Text = manufacturers[0][1];
            linkLabel.Text = manufacturers[0][2];
            textBox2.Text = manufacturers[0][3];
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://" + linkLabel.Text);
        }
    }
}
