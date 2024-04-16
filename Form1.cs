using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChoosingBuildingMaterials
{
    public partial class MainForm : Form
    {
        private int X { get; set; }
        private int Y { get; set; }
        private DataGridViewRow Row { get; set; }
        private int Offset { get; set; }
        private string Condition { get; set; }
        private string Tables { get; set; }
        private string Search { get; set; }
        private string Order { get; set; }
        static private string password = "";
        static private string user = "user";

        public MainForm()
        {
            InitializeComponent();
            Condition = string.Empty;
            Tables = string.Empty;
            Search = string.Empty;
            Order = "materials.name";
            SQLQuery.user = user;
            SQLQuery.password = password;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TreeNodeWithExtraInfo nodeMaterials = new TreeNodeWithExtraInfo("Материалы", TreeViewDataBase.Nodes.Count + 1, "materials");
            TreeViewDataBase.Nodes.Add(nodeMaterials);
            TreeNodeWithExtraInfo nodeCatalogs = new TreeNodeWithExtraInfo("Каталог", TreeViewDataBase.Nodes.Count + 1, "catalogs");
            nodeCatalogs.Nodes.Add("...");
            TreeViewDataBase.Nodes.Add(nodeCatalogs);
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNodeWithExtraInfo node = TreeViewDataBase.Nodes[0] as TreeNodeWithExtraInfo;
            node.Expand();
        }

        private void LoadCatalogs(TreeNode mainNode)
        {
            var cs = $"server=krakv.tplinkdns.com;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    "FROM catalogs ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var node = new TreeNodeWithExtraInfo(dr["name"].ToString(), (int)dr["id"], "subcatalogs", "id");
                        node.Nodes.Add(new Node("..."));
                        mainNode.Nodes.Add(node);
                    }
                    if (mainNode.Nodes.Count > 1)
                    {
                        mainNode.Nodes.RemoveAt(0);
                    }
                }
            }
        }

        private void LoadSubcatalogs(TreeNodeWithExtraInfo inputNode)
        {
            var cs = $"server=krakv.tplinkdns.com;user={user};database=is_building_materials;password={password};CharSet=utf8;";

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM subcatalogs " +
                    $"WHERE catalog_id = {inputNode.Id} ", con);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var node = new TreeNodeWithExtraInfo($"{dr[$"name"]}", (int)dr[$"id"], "materials_subcatalog", "");
                        inputNode.Nodes.Add(node);
                    }
                    if (inputNode.Nodes.Count > 1)
                    {
                        inputNode.Nodes.RemoveAt(0);
                    }
                }
            }
        }

        private void TreeViewDataBase_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            TreeNodeWithExtraInfo node = e.Node as TreeNodeWithExtraInfo;
            if (node != null && node.IsExpanded && node.Table != "materials" && node.Table != "materials_catalog")
            {
                Condition = string.Empty;
                Tables = string.Empty;
                Search = string.Empty;
                PrintTable(node);
            }
            else
            {
                if (node.Table == "materials")
                {
                    Condition = string.Empty;
                    Tables = string.Empty;
                    PrintTable(node, SQLQuery.ReadMaterialsAvailable(order : Order));
                }
                else if (node.Table == "materials_subcatalog")
                {
                    Condition = string.Empty;
                    Tables = string.Empty;
                    PrintTable(node, SQLQuery.ReadMaterialsCatalog(node.Id.ToString(), order : Order));
                }
                else
                {
                    node.Expand();
                }
            }
        }

        private void TreeViewDataBase_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
        }

        private void TreeViewDataBase_AfterExpand(object sender, TreeViewEventArgs e)
        {
            TreeNodeWithExtraInfo node = e.Node as TreeNodeWithExtraInfo;
            TreeViewDataBase.SelectedNode = node;
            if (node != null)
            {
                if (node.Table == "catalogs")
                {
                    LoadCatalogs(node);
                    PrintTable(node);
                }
                else if (node.Table == "subcatalogs")
                {
                    LoadSubcatalogs(node);
                    PrintTable(node);
                }

            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y;
        }

        private void TreeViewDataBase_DoubleClick(object sender, EventArgs e)
        {
        }

        private void PrintTable(TreeNodeWithExtraInfo node, IEnumerable<string[]> values = null)
        {
            
            if (node.Table == "materials" || node.Table == "materials_subcatalog")
            {
                if (mainTable.Columns.Count != 11)
                {
                    mainTable.Columns.Clear();
                    DataGridViewColumn col;
                    col = new DataGridViewColumn(); col.HeaderText = "Number"; col.Name = "Number";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Наименование"; col.Name = "Name";
                    col.Visible = true; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Область применения"; col.Name = "application_field";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Упаковка"; col.Name = "Packaging";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Технические характеристики"; col.Name = "technical_characteristics";
                    col.Visible = true; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Инструкции к использованию"; col.Name = "Instruction_for_use";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Предостережения"; col.Name = "Precautions";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Хранение и транспортировка"; col.Name = "Storage_and_transportation";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Сертификаты"; col.Name = "Certificates";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Номер производителя"; col.Name = "Manufacturer_number";
                    col.Visible = false; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Количество магазинов"; col.Name = "store_number";
                    col.Visible = true; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Количество"; col.Name = "count";
                    col.Visible = true; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                    col = new DataGridViewColumn(); col.HeaderText = "Минимальная стоимость"; col.Name = "cost";
                    col.Visible = true; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                }
                else
                {
                    mainTable.Rows.Clear();
                }
                Offset = 0;
                foreach (string[] item in values)
                    mainTable.Rows.Add(item);
                if (mainTable.Rows.Count == 20)
                {
                    string[] itemRow = { "0", "Еще", "", "", "", "", "", "", "", "", "", "", "", "" };
                    mainTable.Rows.Add(itemRow);
                }
            }
            else if (node.Table == "catalogs" || node.Table == "subcatalogs")
            {
                if (mainTable.Columns.Count != 1)
                {
                    mainTable.Columns.Clear();
                    DataGridViewColumn col;
                    col = new DataGridViewColumn(); col.HeaderText = "Значение"; col.Name = "Text";
                    col.Visible = true; col.CellTemplate = new DataGridViewTextBoxCell(); mainTable.Columns.Add(col);
                }
                else
                {
                    mainTable.Rows.Clear();
                }
                mainTable.Rows.Add("...");
                foreach (TreeNode item in node.Nodes)
                {
                    mainTable.Rows.Add(item);
                }
            }
        }

        private void mainTable_DoubleClick(object sender, EventArgs e)
        {
            
            if (mainTable.SelectedCells.Count > 0)
            {
                if (mainTable.SelectedCells[0].Value.ToString() != "...")
                {
                    TreeNodeWithExtraInfo node = mainTable.SelectedCells[0].Value as TreeNodeWithExtraInfo;
                    if (node != null && node.Table != "position")
                    {
                        TreeViewDataBase.SelectedNode = node;
                        node.Expand();
                    }
                }
                else
                {
                    TreeViewDataBase.SelectedNode.Collapse();
                    if (TreeViewDataBase.SelectedNode.Parent != null )
                        TreeViewDataBase.SelectedNode = TreeViewDataBase.SelectedNode.Parent;
                }
            }
        }

        private void TreeViewDataBase_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            TreeNodeWithExtraInfo node = e.Node as TreeNodeWithExtraInfo;
            if (node != null)
            {
                node.Nodes.Clear();
                node.Nodes.Add("...");
                mainTable.Rows.Clear();
            }
        }

        private void TreeViewDataBase_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void mainTable_Click(object sender, EventArgs e)
        {
        }

        private void closeMaterialInfoBtn_Click(object sender, EventArgs e)
        {
            if (materialInfoPanel.Controls.Count > 1)
                materialInfoPanel.Controls.RemoveAt(1);
            splitContainer2.Panel2Collapsed = true;
        }

        private void mainTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Row = mainTable.Rows[e.RowIndex];
            if (Row.Cells.Count > 1)
            {
                if (Row.Cells[1].Value.ToString() == "Еще")
                {
                    if (TreeViewDataBase.SelectedNode != null)
                    {
                        Offset = mainTable.Rows.Count - 1;
                        IEnumerable<string[]> values = (TreeViewDataBase.SelectedNode as TreeNodeWithExtraInfo).Table == "materials" ? SQLQuery.ReadMaterialsAvailableWithCheckBoxes(offset : Offset, condition : Condition + Search, tables : Tables,order : Order) : SQLQuery.ReadMaterialsCatalogWithCheckBoxes((TreeViewDataBase.SelectedNode as TreeNodeWithExtraInfo).Id.ToString(), offset:Offset, condition: Condition + Search, tables: Tables, order: Order);
                        mainTable.Rows.Remove(Row);
                        foreach (string[] item in values)
                            mainTable.Rows.Add(item);
                        if (values.Count() >= 20)
                        {
                            string[] itemRow = { "0", "Еще", "", "", "", "", "", "", "", "", "", "", "", "" };
                            mainTable.Rows.Add(itemRow);
                        }
                    }
                }
                else
                    materialInfoBtn_Click(sender, e);
            }
        }

        private void materialInfoBtn_Click(object sender, EventArgs e)
        {
            if (Row != null)
            {
                if (materialInfoPanel.Controls.Count > 1)
                    materialInfoPanel.Controls.RemoveAt(1);
                MaterialInfo frm = new MaterialInfo(Row);
                frm.TopLevel = false;
                materialInfoPanel.Controls.Add(frm);
                frm.Show();
                splitContainer2.Panel2Collapsed = false;
                splitContainer2.SplitterDistance = 700;
            }
        }

        private void manufacturerInfoBtn_Click(object sender, EventArgs e)
        {
            if (Row != null)
            {
                if (materialInfoPanel.Controls.Count > 1)
                    materialInfoPanel.Controls.RemoveAt(1);
                ManufacturerInfo frm = new ManufacturerInfo(Row);
                frm.TopLevel = false;
                materialInfoPanel.Controls.Add(frm);
                frm.Show();
                splitContainer2.Panel2Collapsed = false;
                splitContainer2.SplitterDistance = 700;
            }
        }

        private void storesInfoBtn_Click(object sender, EventArgs e)
        {
            if (Row != null)
            {
                if (materialInfoPanel.Controls.Count > 1)
                    materialInfoPanel.Controls.RemoveAt(1);
                MaterialsAvailableForm frm = new MaterialsAvailableForm(Row);
                frm.TopLevel = false;
                materialInfoPanel.Controls.Add(frm);
                frm.Show();
                splitContainer2.Panel2Collapsed = false;
                splitContainer2.SplitterDistance = 700;
            }
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                searchButton_Click(sender, e);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            TreeNodeWithExtraInfo node = TreeViewDataBase.SelectedNode as TreeNodeWithExtraInfo;
            if (node != null)
            {
                Search = $" AND materials.name LIKE '%{searchBox.Text}%' ";
                if (node.Table == "materials")
                    PrintTable(node, SQLQuery.ReadMaterialsAvailableWithCheckBoxes(condition : Condition + Search, tables : Tables, offset: 0, limit : 20, order: Order));
                if (node.Table == "materials_subcatalog")
                    PrintTable(node, SQLQuery.ReadMaterialsCatalogWithCheckBoxes(node.Id.ToString(), condition: Condition + Search, tables : Tables, offset: 0, limit: 20, order: Order));
            }
        }

        private void фильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer3.Panel2Collapsed)
            {
                FilterForm frm = new FilterForm();
                frm.TopLevel = false;
                filterTableLayoutPanel.Controls.Add(frm, 0, 0);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                splitContainer3.SplitterDistance = 100;
                splitContainer3.Panel2Collapsed = false;
            }
            else
            {
                filterTableLayoutPanel.Controls.RemoveAt(1);
                splitContainer3.Panel2Collapsed = true;
            }
        }

        private void catalogsButton_Click(object sender, EventArgs e)
        {
            if (splitContainer3.Panel1Collapsed)
            {
                splitContainer3.Panel1Collapsed = false;
            }
            else
            {
                if (splitContainer3.Panel2Collapsed)
                    фильтрToolStripMenuItem_Click(sender, e);
                splitContainer3.Panel1Collapsed = true;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            FilterForm frm = filterTableLayoutPanel.Controls[1] as FilterForm;
            if (frm != null)
            {
                
                string tags = "";
                string tables = "";
                string conditions = "";
                if (Int32.TryParse(frm.underBorder.Text, out int underNumber))
                {
                    conditions += $" AND cost >= {underNumber} ";
                }
                if (Int32.TryParse(frm.upperBorder.Text, out int upperNumber))
                {
                    conditions += $" AND cost <= {upperNumber} ";
                }
                for (int i = 1; i < frm.tagPanel.Controls.Count; i++)
                {
                    CheckBoxWithId bx = frm.tagPanel.Controls[i] as CheckBoxWithId;
                    if (bx.Checked)
                        tags += $" materials_tags.tag_id = {bx.Id} OR";
                }
                if (tags != "")
                {
                    tables += ", tags, materials_tags ";
                    tags = $"  AND tags.tag_id = materials_tags.tag_id AND materials.material_number = materials_tags.material_number AND ({tags.Substring(0, tags.Length - 2)}) ";
                }
                string manufacturers = "";
                for (int i = 1; i < frm.manufacturerPanel.Controls.Count; i++)
                {
                    CheckBoxWithId bx = frm.manufacturerPanel.Controls[i] as CheckBoxWithId;
                    if (bx.Checked)
                        manufacturers += $" manufacturers.manufacturer_number = {bx.Id} OR";
                }
                if (manufacturers != "")
                {
                    tables += ", manufacturers ";
                    manufacturers = $" AND manufacturers.manufacturer_number = materials.manufacturer_number AND ({manufacturers.Substring(0, manufacturers.Length - 2)}) ";
                }
                string stores = "";
                for (int i = 1; i < frm.storePanel.Controls.Count; i++)
                {
                    CheckBoxWithId bx = frm.storePanel.Controls[i] as CheckBoxWithId;
                    if (bx.Checked)
                        stores += $" stores.store_number = {bx.Id} OR";
                }
                if (stores != "")
                {
                    stores = $" AND ({stores.Substring(0, stores.Length - 2)}) ";
                }
                TreeNodeWithExtraInfo node = TreeViewDataBase.SelectedNode as TreeNodeWithExtraInfo;
                Condition = conditions + tags + manufacturers + stores;
                Tables = tables;
                if (node != null && node.Table == "materials")
                {
                    PrintTable(node, SQLQuery.ReadMaterialsAvailableWithCheckBoxes(condition : Condition, tables : Tables, order: Order));
                }
                else if (node != null && node.Table == "materials_subcatalog")
                {
                    PrintTable(node, SQLQuery.ReadMaterialsCatalogWithCheckBoxes(node.Id.ToString(), condition: Condition, tables: Tables, order: Order));
                }
            }
        }


        private void changeMaterialsButton_Click(object sender, EventArgs e)
        {
            DataGridViewForm frm = new DataGridViewForm("materials", searchColumn : "name");
            frm.Text = "Материалы";
            frm.ShowDialog();
        }

        private void changeTagButton_Click(object sender, EventArgs e)
        {
            DataGridViewForm frm = new DataGridViewForm("tags", searchColumn: "name");
            frm.Text = "Теги";
            frm.ShowDialog();
        }

        private void changeStores_Click(object sender, EventArgs e)
        {
            DataGridViewForm frm = new DataGridViewForm("stores", searchColumn: "real_address");
            frm.Text = "Магазины";
            frm.ShowDialog();
        }

        private void changeManufacturers_Click(object sender, EventArgs e)
        {
            DataGridViewForm frm = new DataGridViewForm("manufacturers", searchColumn: "name");
            frm.Text = "Производители";
            frm.ShowDialog();
        }

        private void changeCatalogs_Click(object sender, EventArgs e)
        {
            DataGridViewForm frm = new DataGridViewForm("catalogs", searchColumn: "name");
            frm.Text = "Каталоги";
            frm.ShowDialog();
        }

        private void changeSubcatalogs_Click(object sender, EventArgs e)
        {
            DataGridViewForm frm = new DataGridViewForm("subcatalogs", searchColumn: "name");
            frm.Text = "Подкаталоги";
            frm.ShowDialog();
        }

        private void adminEnter_Click(object sender, EventArgs e)
        {
            SimpleForm form = new SimpleForm();
            form.Text = "Вход";
            form.name.Text = "Пароль:";
            form.txtBxName.PasswordChar = '*';

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var cs = $"server=krakv.tplinkdns.com;user=admin;database=is_building_materials;password={form.txtBxName.Text};CharSet=utf8;";
                    var con = new MySqlConnection(cs);
                    con.Open();
                    con.Close();
                    user = "admin";
                    password = form.txtBxName.Text;
                    SQLQuery.user = user;
                    SQLQuery.password = password;
                    DataGridViewForm.user = user;
                    DataGridViewForm.password = password;
                    MessageBox.Show("Вход произведен.");
                    adminEnter.Enabled = false;
                    adminEnter.Visible = false;
                    changeTablesButton.Visible = true;
                    changeTablesButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Не удалось.");
                }
            }

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Order = "materials.name";
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                Order = "MIN(cost)";
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                Order = "MIN(cost) DESC";
            }
            else if (toolStripComboBox1.SelectedIndex == 3)
            {
                Order = "SUM(count)";
            }
            else if (toolStripComboBox1.SelectedIndex == 4)
            {
                Order = "SUM(count) DESC";
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (SQLQuery.lastSelect != "")
            {
                //string path = "/var/lib/mysql-files/customers.txt";
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = "c:\\";
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName.Replace("\\", @"/");
                        SQLQuery.OutFile(path);

                    }
                }
            }
            else
            {
                MessageBox.Show("Не найден последний запрос материалов.", "Не удалось");
            }
        }
    }


}
