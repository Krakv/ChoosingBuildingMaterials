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
            textBox.Text += $"Область применения: {text} \r\n";
            text = Row.Cells[3].Value.ToString() != "" ? Row.Cells[3].Value.ToString() : "Отсутствует";
            textBox.Text += $"Упаковка: {text} \r\n";
            text = Row.Cells[4].Value.ToString() != "" ? Row.Cells[4].Value.ToString() : "Отсутствует";
            textBox.Text += $"Характеристики: {text} \r\n";
            text = Row.Cells[5].Value.ToString() != "" ? Row.Cells[5].Value.ToString() : "Отсутствует";
            textBox.Text += $"Инструкции к использованию: {text} \r\n";
            text = Row.Cells[6].Value.ToString() != "" ? Row.Cells[6].Value.ToString() : "Отсутствует";
            textBox.Text += $"Предосторожности: {text} \r\n";
            text = Row.Cells[7].Value.ToString() != "" ? Row.Cells[7].Value.ToString() : "Отсутствует";
            textBox.Text += $"Хранение и транспортировка: {text} \r\n";
            text = Row.Cells[8].Value.ToString() != "" ? Row.Cells[8].Value.ToString() : "Отсутствует";
            textBox.Text += $"Сертификаты: {text} \r\n";
            //Height = textBox.Location.Y + textBox.Height + 5;
        }
    }
}
