using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingBuildingMaterials
{
    internal class ButtonWithId : System.Windows.Forms.Button
    {
        public string Id { get; set; }
        public ButtonWithId(string id) : base()
        {
            Id = id;
        }
    }
}
