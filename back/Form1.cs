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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChoosingBuildingMaterials
{
    public partial class MainForm : Form
    {
        private int X { get; set; }
        private int Y { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TreeNodeWithExtraInfo node = new TreeNodeWithExtraInfo("КСР", 1, "book", "brc");
            //node.Nodes.Add("...");
            //TreeViewDataBase.Nodes.Add(node);
            TreeNodeWithExtraInfo node = new TreeNodeWithExtraInfo("Материалы", TreeViewDataBase.Nodes.Count + 1, "materials");
            node.Nodes.Add("...");
            TreeViewDataBase.Nodes.Add(node);
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNodeWithExtraInfo node = TreeViewDataBase.Nodes[0] as TreeNodeWithExtraInfo;
            node.Expand();
        }

        private void LoadTreeNode(TreeNode mainNode)
        {
            var cs = ConfigurationManager.ConnectionStrings["is_building_materials"].ConnectionString;

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    "FROM brc_books", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var node = new TreeNodeWithExtraInfo(dr["book_number"].ToString() + ". " +dr["description"].ToString(),  (int)dr["book_number"], "part", "book");
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

        private void LoadNode(TreeNodeWithExtraInfo inputNode)
        {
            var cs = ConfigurationManager.ConnectionStrings["is_building_materials"].ConnectionString;

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM brc_{inputNode.Table}s " +
                    $"WHERE {inputNode.Column}_id = {inputNode.Id}", con);
                string next = "";
                if (inputNode.Table == "part")
                    next = "chapter";
                else if (inputNode.Table == "chapter")
                    next = "group";
                else if (inputNode.Table == "group")
                    next = "position";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var node = new TreeNodeWithExtraInfo($"{dr[$"{inputNode.Table}_number"]}. {dr["description"]}", (int)dr[$"{inputNode.Table}_id"], next, inputNode.Table);
                        node.Nodes.Add(new Node("..."));
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
            
            //TreeNodeWithExtraInfo node = TreeViewDataBase.SelectedNode as TreeNodeWithExtraInfo;
            //if (node != null && node.Table != "position" && node.Table != "book")
            //{
            //    LoadNode(node);
            //    PrintTable(node);
            //}
            //else if (node != null && node.Table == "book")
            //{
            //    LoadTreeNode(node);
            //    PrintTable(node);
            //}
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X; Y = e.Y; 
            Point point = new Point(X, Y);
            TreeViewDataBase.SelectedNode = TreeViewDataBase.GetNodeAt(point);
        }

        private void TreeViewDataBase_DoubleClick(object sender, EventArgs e)
        {
        }

        private void PrintTable(TreeNodeWithExtraInfo node)
        {
            //if (node.Table != "position")
            //{
            //    if (mainTable.Columns.Count != 1)
            //    {
            //        mainTable.Columns.Clear();
            //        var col = new DataGridViewColumn();
            //        col.HeaderText = "Значение";
            //        col.Name = "Value";
            //        col.Width = 1920;
            //        col.CellTemplate = new DataGridViewTextBoxCell();
            //        mainTable.Columns.Add(col);
            //    }
            //    else
            //    {
            //        mainTable.Rows.Clear();
            //    }
            //}
            //mainTable.Rows.Add("...");
            //foreach (TreeNode item in node.Nodes)
            //{
            //    mainTable.Rows.Add(item);
            //}
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
            TreeNodeWithExtraInfo node = e.Node as TreeNodeWithExtraInfo;
            if (node != null && node.IsExpanded)
            {
                PrintTable(node);
            }
            else
            {
                mainTable.Rows.Clear();
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
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                int index = 0;
                string[] values = new string[10];
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
                SQLQuery.Add("materials", values);
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
            List<string[]> regions = SQLQuery.ReadRegions();
            foreach (string[] item in regions)
            {
                form.cmbBxRegion.Items.Add(item[1]);
            }
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                int index = 0;
                string[] values = new string[9];
                values[index++] = "";
                values[index++] = form.txtBxName.Text;
                values[index++] = form.txtBxLegalAddress.Text;
                values[index++] = form.txtBxRealAddress.Text;
                values[index++] = form.txtBxSecondName.Text;
                values[index++] = form.txtBxFirstName.Text;
                values[index++] = form.txtBxFatherName.Text;
                values[index++] = form.txtBxPhoneNumber.Text;
                values[index] = SQLQuery.SimpleReadQuery($"SELECT number, name FROM regions WHERE name = '{form.cmbBxRegion.Text}'", "number"); ;

                SQLQuery.Add("stores", values);
            }
        }

        private void addSpecialOfferBtn_Click(object sender, EventArgs e)
        {
            SpecialOffer frm = new SpecialOffer();
            List<string[]> manufacturers = SQLQuery.ReadManufacturers();
            foreach (string[] item in manufacturers)
            {
                frm.cmbBxManufacturer.Items.Add(item[1]);
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                int index = 0;
                string[] values = new string[3];
                values[index++] = "";
                values[index++] = SQLQuery.SimpleReadQuery($"SELECT manufacturer_number, name FROM manufacturers WHERE name = '{frm.cmbBxManufacturer.Text}'", "manufacturer_number");
                values[index++] = frm.txtBxDescription.Text;
                SQLQuery.Add("special_offers", values);
            }
        }
    }


}
