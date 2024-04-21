using Org.BouncyCastle.Pqc.Crypto.Frodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChoosingBuildingMaterials
{
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            //InputText frm = new InputText();
            //frm.ShowDialog();
        }

        private void changeFieldOfApplication_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxFieldOfApplication.Text);
            frm.textBox1.MaxLength = txtBxFieldOfApplication.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxFieldOfApplication.Text = frm.textBox1.Text;
            }
        }

        private void changePackaging_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxPackaging.Text);
            frm.textBox1.MaxLength = txtBxPackaging.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxPackaging.Text = frm.textBox1.Text;
            }
        }

        private void changeUnit_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxUnit.Text);
            frm.textBox1.MaxLength = txtBxUnit.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxPackaging.Text = frm.textBox1.Text;
            }
        }

        private void changeTechnicalCharacteristics_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxTechnicalCharacteristics.Text);
            frm.textBox1.MaxLength = txtBxTechnicalCharacteristics.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxTechnicalCharacteristics.Text = frm.textBox1.Text;
            }
        }

        private void changeInstructionForUse_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxInstructionForUse.Text);
            frm.textBox1.MaxLength = txtBxInstructionForUse.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxInstructionForUse.Text = frm.textBox1.Text;
            }
        }

        private void changePrecautions_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxPrecautions.Text);
            frm.textBox1.MaxLength = txtBxPrecautions.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxPrecautions.Text = frm.textBox1.Text;
            }
        }

        private void changeStorageAndTransportation_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxStorageAndTransportation.Text);
            frm.textBox1.MaxLength = txtBxStorageAndTransportation.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxStorageAndTransportation.Text = frm.textBox1.Text;
            }
        }

        private void changeSertificates_Click(object sender, EventArgs e)
        {
            InputText frm = new InputText(txtBxCertificates.Text);
            frm.textBox1.MaxLength = txtBxCertificates.MaxLength;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtBxCertificates.Text = frm.textBox1.Text;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void storeSearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < storesPanel.RowCount; i++)
            {
                CheckBoxWithId bx = storesPanel.Controls[i * 3] as CheckBoxWithId;
                
                if (bx.Text.Contains(storeSearchBox.Text))
                {
                    bx.Visible = true;
                    storesPanel.Controls[i * 3 + 1].Visible = true;
                    storesPanel.Controls[i * 3 + 2].Visible = true;
                }
                else
                {
                    bx.Visible = false;
                    storesPanel.Controls[i * 3 + 1].Visible = false;
                    storesPanel.Controls[i * 3 + 2].Visible = false;
                }
            }
        }

        private void tagSearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tagsPanel.Controls.Count; i++)
            {
                CheckBoxWithId bx = tagsPanel.Controls[i] as CheckBoxWithId;
                if (bx.Text.Contains(tagSearchBox.Text))
                    bx.Visible = true;
                else
                    bx.Visible = false;
            }
        }

        private void subcatalogSearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < subcatalogsPanel.Controls.Count; i++)
            {
                CheckBoxWithId bx = subcatalogsPanel.Controls[i] as CheckBoxWithId;
                if (bx.Text.Contains(subcatalogSearchBox.Text))
                    bx.Visible = true;
                else
                    bx.Visible = false;
            }
        }

        private void txtBxName_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox bx = sender as System.Windows.Forms.TextBox;
            if (bx != null)
            {
                if (bx.Text == "")
                {
                    errorProvider1.SetError(bx, "Поле должно быть непустое");
                    //e.Cancel = true;
                }
                else
                    errorProvider1.SetError(bx, "");
            }
        }

        private void cmbBxManufacturer_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox bx = sender as System.Windows.Forms.ComboBox;
            if (bx != null)
            {
                if (bx.Text == "")
                {
                    errorProvider1.SetError(bx, "Поле должно быть непустое");
                    //e.Cancel = true;
                }
                else
                    errorProvider1.SetError(bx, "");
            }
        }

        private void MaterialForm_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {

        }

        private void MaterialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtBxName.Text == "" && DialogResult == DialogResult.OK)
            {
                MessageBox.Show(@"Не заполнено поле ""Наименование"" ", "Ошибка");
                e.Cancel = true;
            }
            else if ((cmbBxManufacturer.Text == "" || cmbBxManufacturer.SelectedItem == null) && DialogResult == DialogResult.OK)
            {
                MessageBox.Show(@"Не заполнено поле ""Производитель"" ", "Ошибка");
                e.Cancel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
