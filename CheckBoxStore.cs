using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosingBuildingMaterials
{
    internal class CheckBoxStore : CheckBox
    {
        public int Id { get; set; }
        public string Count { get; set; }
        public string Cost { get; set; }

        public CheckBoxStore(int id, string count, string cost) : base()
        {
            Id = id;
            Count = count;
            Cost = cost;
        }

    }
}
