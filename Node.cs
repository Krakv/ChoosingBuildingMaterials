using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosingBuildingMaterials
{
    internal class Node : TreeNode
    {
        public Node(string text) : base(text) { }

        public override string ToString()
        {
            return base.Text;
        }
    }
}
