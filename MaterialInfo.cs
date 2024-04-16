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
    public partial class MaterialInfo : Form
    {
        DataGridViewRow Row {  get; set; }

        public MaterialInfo(DataGridViewRow row)
        {
            InitializeComponent();
            Row = row;
            InitializeInfo();
        }

        private void InitializeInfo()
        {
            string text = Row.Cells[1].Value.ToString() != "" ? Row.Cells[1].Value.ToString() : "Отсутствует";
            textBox.Text = $"Наименование: {text} \r\n";
            text = Row.Cells[2].Value.ToString() != "" ? Row.Cells[2].Value.ToString() : "Отсутствует";
            textBox.Text += $"\r\nОбласть применения: \r\n{text} \r\n";
            text = Row.Cells[3].Value.ToString() != "" ? Row.Cells[3].Value.ToString() : "Отсутствует";
            textBox.Text += $"\r\nУпаковка: \r\n{text} \r\n";
            text = Row.Cells[4].Value.ToString() != "" ? Row.Cells[4].Value.ToString() : "Отсутствует";
            textBox.Text += $"\r\nХарактеристики: \r\n{text} \r\n";
            text = Row.Cells[5].Value.ToString() != "" ? Row.Cells[5].Value.ToString() : "Отсутствует";
            textBox.Text += $"\r\nИнструкции к использованию: \r\n{text} \r\n";
            text = Row.Cells[6].Value.ToString() != "" ? Row.Cells[6].Value.ToString() : "Отсутствует";
            textBox.Text += $"\r\nПредосторожности: \r\n{text} \r\n";
            text = Row.Cells[7].Value.ToString() != "" ? Row.Cells[7].Value.ToString() : "Отсутствует";
            textBox.Text += $"\r\nХранение и транспортировка: \r\n{text} \r\n";
            text = Row.Cells[8].Value.ToString() != "" ? Row.Cells[8].Value.ToString() : "Отсутствует";
            textBox.Text += $"\r\nСертификаты: \r\n{text} \r\n";
            //Height = textBox.Location.Y + textBox.Height + 5;
        }
    }
}
