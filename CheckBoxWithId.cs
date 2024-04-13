using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosingBuildingMaterials
{
    internal class CheckBoxWithId : CheckBox
    {
        public int Id { get; set; }
        public CheckBoxWithId(int id) : base()
        {
            Id = id;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
