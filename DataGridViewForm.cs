using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types;

namespace ChoosingBuildingMaterials
{
    public partial class DataGridViewForm : Form
    {
        private string Condition { get; set; }
        private string Table { get; set; }
        private string SearchColumn { get; set; }
        private int Limit { get; set; }
        private int Offset { get; set; }
        public static string user;
        public static string password;


        public DataGridViewForm(string table, string condition = "", string searchColumn = "")
        {
            InitializeComponent();
            Condition = condition;
            Table = table;
            SearchColumn = searchColumn;
            Limit = 50;
            Offset = 0;
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            var cs = $"server={MainForm.server};user={user};database=is_building_materials;password={password};CharSet=utf8;";
            string query = "SELECT * " +
                $"FROM {Table} " +
                $"WHERE 1 = 1 {Condition} " +
                $"LIMIT {Limit} OFFSET {Offset} ";
            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                MySqlDataAdapter ms = new MySqlDataAdapter(query, con);
                DataTable table = new DataTable();
                ms.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchColumn != "")
                {
                    var cs = $"server={MainForm.server};user={user};database=is_building_materials;password={password};CharSet=utf8;";
                    string query = "SELECT * " +
                        $"FROM {Table} " +
                        $"WHERE {SearchColumn} LIKE '%{searchBox.Text}%' {Condition} " +
                        $"LIMIT {Limit} OFFSET {Offset}";
                    using (var con = new MySqlConnection(cs))
                    {
                        con.Open();
                        MySqlDataAdapter ms = new MySqlDataAdapter(query, con);
                        DataTable table = new DataTable();
                        ms.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка поиска. \nТекст ошибки: \n" + ex.Message, "Ошибка");
            }
        }

        private void countBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countBox_Validating(object sender, CancelEventArgs e)
        {
            ToolStripTextBox bx = sender as ToolStripTextBox;
            if (Int32.TryParse(bx.Text, out int value))
            {
                if (bx.Name == "offsetBox") 
                    Offset = value;
                else if (bx.Name == "countBox")
                    Limit = value;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Table == "materials")
                    UpdateMaterial(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "tags")
                    UpdateTag(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "stores")
                    UpdateStore(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "manufacturers")
                    UpdateManufacturer(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "catalogs")
                    UpdateCatalog(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "subcatalogs")
                    UpdateSubcatalog(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка редактирования. \nТекст ошибки: \n" + ex.Message, "Ошибка");
            }
            searchButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы точно хотите удалить элемент?", "Удаление", MessageBoxButtons.YesNo);
            string num = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
            if (res == DialogResult.Yes)
            {
                try
                {
                    if (Table == "materials")
                        SQLQuery.SimpleExecuteQuery($"DELETE FROM materials WHERE material_number = {num}");
                    else if (Table == "stores")
                        SQLQuery.SimpleExecuteQuery($"DELETE FROM stores WHERE store_number = {num}");
                    else if (Table == "manufacturers")
                        SQLQuery.SimpleExecuteQuery($"DELETE FROM manufacturers WHERE manufacturer_number = {num}");
                    else if (Table == "special_offers")
                        SQLQuery.SimpleExecuteQuery($"DELETE FROM special_offers WHERE number = {num}");
                    else if (Table == "tags")
                        SQLQuery.SimpleExecuteQuery($"DELETE FROM tags WHERE tag_id = {num}");
                    else if (Table == "catalogs")
                        SQLQuery.SimpleExecuteQuery($"DELETE FROM catalogs WHERE id = {num}");
                    else if (Table == "subcatalogs")
                        SQLQuery.SimpleExecuteQuery($"DELETE FROM subcatalogs WHERE id = {num}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка удаления. \nТекст ошибки: \n" + ex.Message, "Ошибка");
                }
                searchButton_Click(sender, e);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Table == "materials")
                    addMaterialBtn_Click(sender, e);
                else if (Table == "stores")
                    addStoreButton_Click(sender, e);
                else if (Table == "manufacturers")
                    addManufacturerBtn_Click(sender, e);
                else if (Table == "tags")
                    addTag_Click_1(sender, e);
                else if (Table == "catalogs")
                    addCatalog_Click(sender, e);
                else if (Table == "subcatalogs")
                    addSubcatalog_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка добавления. \nТекст ошибки: \n" + ex.Message, "Ошибка");
            }
            searchButton_Click(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Table == "materials")
                    UpdateMaterial(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "tags")
                    UpdateTag(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "stores")
                    UpdateStore(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "manufacturers")
                    UpdateManufacturer(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "catalogs")
                    UpdateCatalog(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
                else if (Table == "subcatalogs")
                    UpdateSubcatalog(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка редактирования. \nТекст ошибки: \n" + ex.Message, "Ошибка");
            }
            searchButton_Click(sender, e);
        }

        private void UpdateMaterial(DataGridViewRow row)
        {
            MaterialForm frm = new MaterialForm();
            frm.txtBxName.Text = row.Cells[1].Value.ToString();
            frm.txtBxFieldOfApplication.Text = row.Cells[2].Value.ToString();
            frm.txtBxPackaging.Text = row.Cells[3].Value.ToString();
            frm.txtBxTechnicalCharacteristics.Text = row.Cells[4].Value.ToString();
            frm.txtBxInstructionForUse.Text = row.Cells[5].Value.ToString();
            frm.txtBxPrecautions.Text = row.Cells[6].Value.ToString();
            frm.txtBxStorageAndTransportation.Text = row.Cells[7].Value.ToString();
            frm.txtBxCertificates.Text = row.Cells[8].Value.ToString();
            frm.txtBxUnit.Text = row.Cells[9].Value.ToString();
            List<string[]> manufacturers = SQLQuery.ReadManufacturers();
            foreach (string[] item in manufacturers)
            {
                frm.cmbBxManufacturer.Items.Add(item[1]);
                if (item[0] == row.Cells[9].Value.ToString())
                    frm.cmbBxManufacturer.SelectedIndex = frm.cmbBxManufacturer.Items.Count - 1;
            }
            List<string[]> stores = SQLQuery.ReadStores();
            
            foreach (string[] item in stores)
            {
                CheckBoxWithId bx = new CheckBoxWithId(Int32.Parse(item[0]));
                bx.Text = item[1] + " | " + item[3];
                bx.Dock = DockStyle.Top;
                List<string[]> storesAvailable = SQLQuery.ReadMaterialsAvailableStores($" AND materials_available.material_number = {row.Cells[0].Value} AND stores.store_number = {item[0]} ");
                string count = "", cost = ""; 
                if (storesAvailable.Count > 0)
                {
                    bx.Checked = true;
                    count = storesAvailable[0][5];
                    cost = storesAvailable[0][6];
                }
                frm.storesPanel.Controls.Add(bx);
                frm.storesPanel.Controls.Add(new System.Windows.Forms.TextBox() { Dock = DockStyle.Fill , Text = count});
                frm.storesPanel.Controls.Add(new System.Windows.Forms.TextBox() { Dock = DockStyle.Fill , Text = cost });
            }
            List<string[]> tags = SQLQuery.ReadTags();
            List<string> tagsLinked = new List<string>();
            foreach (string[] item in SQLQuery.ReadTags($" AND tags.tag_id = materials_tags.tag_id AND materials_tags.material_number = {row.Cells[0].Value} ", " , materials_tags "))
            {
                tagsLinked.Add(item[0]);
            }
            foreach (string[] item in tags)
            {
                CheckBoxWithId bx = new CheckBoxWithId(Int32.Parse(item[0]));
                bx.Text = item[1];
                bx.Dock = DockStyle.Top;
                if (tagsLinked.Contains(item[0]))
                    bx.Checked = true;
                frm.tagsPanel.Controls.Add(bx);
            }
            List<string[]> subcatalogs = SQLQuery.ReadSubcatalogs();
            List<string> subcatalogsLinked = new List<string>();
            foreach (string[] item in SQLQuery.ReadSubcatalogs($" AND subcatalogs.id = materials_catalog.subcatalog_id AND materials_catalog.material_number = {row.Cells[0].Value} ", " , materials_catalog "))
            {
                subcatalogsLinked.Add(item[0]);
            }
            foreach (string[] item in subcatalogs)
            {
                CheckBoxWithId bx = new CheckBoxWithId(Int32.Parse(item[0]));
                bx.Text = item[2];
                bx.Dock = DockStyle.Top;
                if (subcatalogsLinked.Contains(item[0]))
                    bx.Checked = true;
                frm.subcatalogsPanel.Controls.Add(bx);
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                
                string result = " ";
                result += $" name = '{frm.txtBxName.Text}', ";
                result += $" application_field = '{frm.txtBxFieldOfApplication.Text}', ";
                result += $" packaging = '{frm.txtBxPackaging.Text}', ";
                result += $" technical_characteristics = '{frm.txtBxTechnicalCharacteristics.Text}', ";
                result += $" instruction_for_use = '{frm.txtBxInstructionForUse.Text}', ";
                result += $" precautions = '{frm.txtBxPrecautions.Text}', ";
                result += $" storage_and_transportation = '{frm.txtBxStorageAndTransportation.Text}', ";
                result += $" certificates = '{frm.txtBxCertificates.Text}', ";
                result += $" manufacturer_number = '{SQLQuery.SimpleReadQuery($"SELECT manufacturer_number, name FROM manufacturers WHERE name = '{frm.cmbBxManufacturer.Text}'", "manufacturer_number")}', ";
                result += $" unit_of_measurement = '{frm.txtBxUnit.Text}' ";
                result = result.Replace("''", "NULL");
                SQLQuery.UPDATE("materials", result, $" AND materials.material_number = {row.Cells[0].Value} ");
                int number = Int32.Parse(row.Cells[0].Value.ToString());
                for (int j = 0; j < frm.storesPanel.RowCount; j++)
                {
                    CheckBoxWithId item = frm.storesPanel.Controls[j * 3] as CheckBoxWithId;
                    System.Windows.Forms.TextBox count = frm.storesPanel.Controls[j * 3 + 1] as System.Windows.Forms.TextBox;
                    System.Windows.Forms.TextBox cost = frm.storesPanel.Controls[j * 3 + 2] as System.Windows.Forms.TextBox;
                    if (item != null)
                    {
                        if (item.Checked)
                        {
                            List<string[]> lst = SQLQuery.ReadMaterialsAvailableStores($" AND materials_available.material_number = {row.Cells[0].Value} AND stores.store_number = {item.Id} ");
                            if (lst != null && lst.Count > 0)
                            {
                                SQLQuery.UPDATE("materials_available", $" count = '{count.Text}', cost = '{cost.Text}' ", $" AND material_available_number = {lst[0][0]} ");
                            }
                            else
                            {
                                int i = 0;
                                string[] vs = new string[5];
                                vs[i++] = "";
                                vs[i++] = number.ToString();
                                vs[i++] = item.Id.ToString();
                                vs[i++] = count.Text;
                                vs[i++] = cost.Text;
                                SQLQuery.Add("materials_available", vs);
                            }
                        }
                        else
                        {
                            string res = SQLQuery.SimpleReadQuery($"SELECT * FROM materials_available WHERE material_number = {row.Cells[0].Value} AND store_number = {item.Id} ", "material_available_number");
                            if (res != "")
                            {
                                SQLQuery.SimpleExecuteQuery($"DELETE FROM materials_available WHERE material_available_number = {res} ");
                            }
                        }
                    }
                }
                foreach (CheckBoxWithId item in frm.tagsPanel.Controls)
                {
                    if (item != null && item.Checked)
                    {
                        if (!tagsLinked.Contains(item.Id.ToString()))
                        {
                            int i = 0;
                            string[] vs = new string[3];
                            vs[i++] = "";
                            vs[i++] = number.ToString();
                            vs[i++] = item.Id.ToString();
                            SQLQuery.Add("materials_tags", vs);
                        }
                    }
                    else
                    {
                        string res = SQLQuery.SimpleReadQuery($"SELECT * FROM materials_tags WHERE material_number = {row.Cells[0].Value} AND tag_id = {item.Id} ", "id");
                        if (res != "")
                        {
                            SQLQuery.SimpleExecuteQuery($"DELETE FROM materials_tags WHERE id = {res} ");
                        }
                    }
                    
                }
                foreach (CheckBoxWithId item in frm.subcatalogsPanel.Controls)
                {
                    if (item != null && item.Checked)
                    {
                        if (!subcatalogsLinked.Contains(item.Id.ToString()))
                        {
                            int i = 0;
                            string[] vs = new string[3];
                            vs[i++] = "";
                            vs[i++] = number.ToString();
                            vs[i++] = item.Id.ToString();
                            SQLQuery.Add("materials_catalog", vs);
                        }
                    }
                    else
                    {
                        string res = SQLQuery.SimpleReadQuery($"SELECT * FROM materials_catalog WHERE material_number = {row.Cells[0].Value} AND subcatalog_id = {item.Id} ", "id");
                        if (res != "")
                        {
                            SQLQuery.SimpleExecuteQuery($"DELETE FROM materials_catalog WHERE id = {res} ");
                        }
                    }

                }
            }
        }

        private void UpdateTag(DataGridViewRow row)
        {
            SimpleForm form = new SimpleForm();
            form.txtBxName.Text = row.Cells[1].Value.ToString();
            form.Text = "Изменение тега";
            if (form.ShowDialog() == DialogResult.OK)
            {
                SQLQuery.UPDATE("tags", $" name = '{form.txtBxName.Text}' ", $" AND tag_id = {row.Cells[0].Value} ");
            }
        }

        private void UpdateStore(DataGridViewRow row)
        {
            StoreForm form = new StoreForm();
            form.txtBxName.Text = row.Cells[1].Value.ToString();
            form.txtBxLegalAddress.Text = row.Cells[2].Value.ToString();
            form.txtBxRealAddress.Text = row.Cells[3].Value.ToString();
            form.txtBxFirstName.Text = row.Cells[4].Value.ToString();
            form.txtBxSecondName.Text = row.Cells[5].Value.ToString();
            form.txtBxFatherName.Text = row.Cells[6].Value.ToString();
            form.txtBxPhoneNumber.Text = row.Cells[7].Value.ToString();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string values = "";
                values += $" name = '{form.txtBxName.Text}', ";
                values += $" legal_address = '{form.txtBxLegalAddress.Text}', ";
                values += $" real_address = '{form.txtBxRealAddress.Text}', ";
                values += $" director_name = '{form.txtBxFirstName.Text}', ";
                values += $" director_surname = '{form.txtBxSecondName.Text}', ";
                values += $" director_father = '{form.txtBxFatherName.Text}', ";
                values += $" phone_number = '{form.txtBxPhoneNumber.Text}' ";
                SQLQuery.UPDATE("stores", values, $" AND store_number = {row.Cells[0].Value} ");
            }
        }

        private void UpdateManufacturer(DataGridViewRow row)
        {
            ManufacturerForm form = new ManufacturerForm();
            form.txtBxName.Text = row.Cells[1].Value.ToString();
            form.txtBxOfficialSite.Text = row.Cells[2].Value.ToString();
            form.txtBxContactInfo.Text = row.Cells[3].Value.ToString();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string values = "";
                values += $" name = '{form.txtBxName.Text}', ";
                values += $" site = '{form.txtBxOfficialSite.Text}', ";
                values += $" contact_info = '{form.txtBxContactInfo.Text}' ";
                SQLQuery.UPDATE("manufacturers", values, $" AND manufacturer_number = {row.Cells[0].Value} ");
            }
        }

        private void UpdateCatalog(DataGridViewRow row)
        {
            SimpleForm form = new SimpleForm();
            form.txtBxName.Text = row.Cells[1].Value.ToString();
            form.Text = "Каталог";
            if (form.ShowDialog() == DialogResult.OK)
            {
                string values = "";
                values += $" name = '{form.txtBxName.Text}' ";
                SQLQuery.UPDATE("catalogs", values, $" AND id = {row.Cells[0].Value} ");
            }
        }
        
        private void UpdateSubcatalog(DataGridViewRow row)
        {
            SubcatalogForm frm = new SubcatalogForm();
            frm.Text = "Подкаталог";
            frm.txtBxName.Text = row.Cells[2].Value.ToString();
            foreach (string[] item in SQLQuery.ReadCatalogs())
            {
                frm.catalogCmbBx.Items.Add(new Catalog(item[1], Int32.Parse(item[0])));
                if (item[0] == row.Cells[1].Value.ToString())
                    frm.catalogCmbBx.SelectedIndex = frm.catalogCmbBx.Items.Count - 1;
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Catalog ctg = frm.catalogCmbBx.SelectedItem as Catalog;
                if (ctg != null)
                {
                    string values = "";
                    values += $" name = '{frm.txtBxName.Text}', ";
                    values += $" catalog_id = '{ctg.Id}' ";
                    SQLQuery.UPDATE("subcatalogs", values, $" AND id = {row.Cells[0].Value} ");
                }
                else
                {
                    MessageBox.Show("Не удалось");
                }
            }
        }

        private void addMaterialBtn_Click(object sender, EventArgs e)
        {
            MaterialForm frm = new MaterialForm();
            List<string[]> manufacturers = SQLQuery.ReadManufacturers();
            foreach (string[] item in manufacturers)
            {
                frm.cmbBxManufacturer.Items.Add(item[1]);
            }
            List<string[]> stores = SQLQuery.ReadStores();
            foreach (string[] item in stores)
            {
                CheckBoxWithId bx = new CheckBoxWithId(Int32.Parse(item[0]));
                bx.Text = item[1] + " | " + item[3];
                bx.Dock = DockStyle.Top;
                frm.storesPanel.Controls.Add(bx);
                frm.storesPanel.Controls.Add(new System.Windows.Forms.TextBox() { Dock = DockStyle.Fill });
                frm.storesPanel.Controls.Add(new System.Windows.Forms.TextBox() { Dock = DockStyle.Fill });
            }
            List<string[]> tags = SQLQuery.ReadTags();
            foreach (string[] item in tags)
            {
                CheckBoxWithId bx = new CheckBoxWithId(Int32.Parse(item[0]));
                bx.Text = item[1];
                bx.Dock = DockStyle.Top;
                frm.tagsPanel.Controls.Add(bx);
            }
            List<string[]> subcatalogs = SQLQuery.ReadSubcatalogs();
            foreach (string[] item in subcatalogs)
            {
                CheckBoxWithId bx = new CheckBoxWithId(Int32.Parse(item[0]));
                bx.Text = item[2];
                bx.Dock = DockStyle.Top;
                frm.subcatalogsPanel.Controls.Add(bx);
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                int index = 0;
                string[] values = new string[11];
                values[index++] = "";
                values[index++] = frm.txtBxName.Text;
                values[index++] = frm.txtBxFieldOfApplication.Text;
                values[index++] = frm.txtBxPackaging.Text;
                values[index++] = frm.txtBxTechnicalCharacteristics.Text;
                values[index++] = frm.txtBxInstructionForUse.Text;
                values[index++] = frm.txtBxPrecautions.Text;
                values[index++] = frm.txtBxStorageAndTransportation.Text;
                values[index++] = frm.txtBxCertificates.Text;
                values[index++] = SQLQuery.SimpleReadQuery($"SELECT manufacturer_number, name FROM manufacturers WHERE name = '{frm.cmbBxManufacturer.Text}'", "manufacturer_number");
                values[index++] = frm.txtBxUnit.Text;
                SQLQuery.Add("materials", values);
                if (Int32.TryParse(SQLQuery.SimpleReadQuery("SELECT MAX(material_number) FROM materials ", "MAX(material_number)"), out int number))
                {
                    for (int j = 0; j < frm.storesPanel.RowCount; j++)
                    {
                        CheckBoxWithId item = frm.storesPanel.Controls[j * 3] as CheckBoxWithId;
                        System.Windows.Forms.TextBox count = frm.storesPanel.Controls[j * 3 + 1] as System.Windows.Forms.TextBox;
                        System.Windows.Forms.TextBox cost = frm.storesPanel.Controls[j * 3 + 2] as System.Windows.Forms.TextBox;
                        if (item != null && item.Checked)
                        {
                            int i = 0;
                            string[] vs = new string[5];
                            vs[i++] = "";
                            vs[i++] = number.ToString();
                            vs[i++] = item.Id.ToString();
                            vs[i++] = count.Text;
                            vs[i++] = cost.Text;
                            SQLQuery.Add("materials_available", vs);
                        }
                    }
                    foreach (CheckBoxWithId item in frm.tagsPanel.Controls)
                    {
                        if (item != null && item.Checked)
                        {
                            int i = 0;
                            string[] vs = new string[3];
                            vs[i++] = "";
                            vs[i++] = number.ToString();
                            vs[i++] = item.Id.ToString();
                            SQLQuery.Add("materials_tags", vs);
                        }
                    }
                    foreach (CheckBoxWithId item in frm.subcatalogsPanel.Controls)
                    {
                        if (item != null && item.Checked)
                        {
                            int i = 0;
                            string[] vs = new string[3];
                            vs[i++] = "";
                            vs[i++] = number.ToString();
                            vs[i++] = item.Id.ToString();
                            SQLQuery.Add("materials_catalog", vs);
                        }
                    }
                }
            }
        }

        private void addManufacturerBtn_Click(object sender, EventArgs e)
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
            }
        }

        private void addStoreButton_Click(object sender, EventArgs e)
        {
            StoreForm form = new StoreForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                int index = 0;
                string[] values = new string[8];
                values[index++] = "";
                values[index++] = form.txtBxName.Text;
                values[index++] = form.txtBxLegalAddress.Text;
                values[index++] = form.txtBxRealAddress.Text;
                values[index++] = form.txtBxSecondName.Text;
                values[index++] = form.txtBxFirstName.Text;
                values[index++] = form.txtBxFatherName.Text;
                values[index++] = form.txtBxPhoneNumber.Text;

                SQLQuery.Add("stores", values);
            }
        }

        private void addSpecialOfferBtn_Click(object sender, EventArgs e)
        {
        }

        private void addTag_Click_1(object sender, EventArgs e)
        {
            SimpleForm frm = new SimpleForm();
            frm.Text = "Тег";

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                string[] parameters = { "", frm.txtBxName.Text };
                SQLQuery.Add("tags", parameters);
            }
        }

        private void addCatalog_Click(object sender, EventArgs e)
        {
            SimpleForm frm = new SimpleForm();
            frm.Text = "Каталог";

            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                string[] parameters = { "", frm.txtBxName.Text };
                SQLQuery.Add("catalogs", parameters);
            }
        }

        private void addSubcatalog_Click(object sender, EventArgs e)
        {
            SubcatalogForm frm = new SubcatalogForm();
            frm.Text = "Подкаталог";
            foreach (string[] item in SQLQuery.ReadCatalogs())
            {
                frm.catalogCmbBx.Items.Add(new Catalog(item[1], Int32.Parse(item[0])));
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Catalog ctg = frm.catalogCmbBx.SelectedItem as Catalog;
                if (ctg != null)
                {
                    string[] parameters = { "", ctg.Id.ToString(), frm.txtBxName.Text };
                    SQLQuery.Add("subcatalogs", parameters);
                }
                else
                {
                    MessageBox.Show("Не удалось");
                }
            }
        }
    }
}
