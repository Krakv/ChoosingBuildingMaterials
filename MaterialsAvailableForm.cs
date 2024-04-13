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
    public partial class MaterialsAvailableForm : Form
    {
        DataGridViewRow Row {  get; set; }
        public MaterialsAvailableForm(DataGridViewRow row)
        {
            InitializeComponent();
            Row = row;
            InitializeStores();
        }

        private void InitializeStores()
        {
            List<string[]> materialsAvailable = SQLQuery.ReadMaterialsAvailableStores($" AND material_number = {Row.Cells[0].Value} ");
            Height = materialsAvailable.Count * 100;
            tableLayoutPanel.RowCount = materialsAvailable.Count;
            for ( int i = 0; i < materialsAvailable.Count; i++ )
            {
                ButtonWithId btn = new ButtonWithId(materialsAvailable[i][2]);
                btn.Click += Btn_Click;
                btn.Dock = DockStyle.Fill;
                btn.Text = "Подробная информация";
                tableLayoutPanel.Controls.Add(btn, 0, i);
                TextBox txt = new TextBox();
                txt.Multiline = true;
                txt.Dock = DockStyle.Fill;
                txt.ReadOnly = true;
                txt.BorderStyle = BorderStyle.None;
                txt.Text += materialsAvailable[i][3] + "\r\n";
                txt.Text += materialsAvailable[i][4] + "\r\n";
                txt.Text += "Кол-во" + materialsAvailable[i][5] + "\r\n";
                txt.Text += "Стоимость " + materialsAvailable[i][6] + "\r\n";
                tableLayoutPanel.Controls.Add(txt, 1, i);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Controls.Remove(tableLayoutPanel);
            TextBox txt = new TextBox();
            txt.Multiline = true;
            txt.ScrollBars = ScrollBars.Vertical;
            //txt.Dock = DockStyle.Fill;
            txt.Location = new Point(0, 30);
            txt.Width = 530;
            txt.Height = Height - 30;
            txt.ReadOnly = true;
            txt.BorderStyle = BorderStyle.None;
            ButtonWithId btn = sender as ButtonWithId;
            List<string[]> store = SQLQuery.ReadStores($" WHERE store_number = {btn.Id} ");
            txt.Text += $"Наименование: {store[0][1]} \r\n";
            txt.Text += $"Юридический адрес: {store[0][2]} \r\n";
            txt.Text += $"Физический адрес: {store[0][3]} \r\n";
            txt.Text += $"Имя директора: {store[0][4]} \r\n";
            txt.Text += $"Фамилия директора: {store[0][5]} \r\n";
            txt.Text += $"Отчество директора: {store[0][6]} \r\n";
            txt.Text += $"Номер телефона: {store[0][7]} \r\n";
            Controls.Add(txt);
        }
    }
}
