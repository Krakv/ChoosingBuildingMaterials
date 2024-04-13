using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosingBuildingMaterials
{
    public class TreeNodeWithExtraInfo : TreeNode
    {
        public int Id { get; set; }
        public string Table { get; set; }
        public string Column { get; set; }

        public TreeNodeWithExtraInfo(string text, int id, string table, string column = "") : base(text)
        {
            Id = id;
            Table = table;
            Column = column;
        }

        public override string ToString()
        {
            return base.Text;
        }
    }
}
