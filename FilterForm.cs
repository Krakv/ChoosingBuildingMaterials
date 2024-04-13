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
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void InitializeCheckBoxes()
        {
            foreach (string[] item in SQLQuery.ReadTags(" AND tags.tag_id = materials_tags.tag_id ", " , materials_tags "))
            {
                if (Int32.TryParse(item[0], out int value))
                {
                    CheckBoxWithId bx = new CheckBoxWithId(value);
                    bx.Text = item[1];
                    bx.Dock = DockStyle.Fill;
                    tagPanel.Controls.Add(bx, 0, 1);
                }
            }
            foreach (string[] item in SQLQuery.ReadManufacturers())
            {
                if (Int32.TryParse(item[0], out int value))
                {
                    CheckBoxWithId bx = new CheckBoxWithId(value);
                    bx.Text = item[1];
                    bx.Dock = DockStyle.Fill;
                    manufacturerPanel.Controls.Add(bx, 0, 1);
                }
            }
            foreach (string[] item in SQLQuery.ReadMaterialsAvailableStores(" GROUP BY stores.store_number "))
            {
                if (Int32.TryParse(item[2], out int value))
                {
                    CheckBoxWithId bx = new CheckBoxWithId(value);
                    bx.Text = item[3] + " | " + item[4];
                    bx.Dock = DockStyle.Fill;
                    storePanel.Controls.Add(bx, 0, 1);
                }
            }
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            InitializeCheckBoxes();
        }

        private void searchButtonTag_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < tagPanel.Controls.Count; i++)
            {
                CheckBoxWithId bx = tagPanel.Controls[i] as CheckBoxWithId;
                if (bx.Text.Contains(searchBoxTag.Text))
                    bx.Visible = true;
                else
                    bx.Visible = false;
            }
        }

        private void searchButtonManufacturer_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < manufacturerPanel.Controls.Count; i++)
            {
                CheckBoxWithId bx = manufacturerPanel.Controls[i] as CheckBoxWithId;
                if (bx.Text.Contains(searchBoxManufacturer.Text))
                    bx.Visible = true;
                else
                    bx.Visible = false;
            }
        }

        private void searchButtonStore_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < storePanel.Controls.Count; i++)
            {
                CheckBoxWithId bx = storePanel.Controls[i] as CheckBoxWithId;
                if (bx.Text.Contains(searchBoxStore.Text))
                    bx.Visible = true;
                else
                    bx.Visible = false;
            }
        }
    }
}
