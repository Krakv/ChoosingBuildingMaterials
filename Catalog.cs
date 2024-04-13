﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingBuildingMaterials
{
    internal class Catalog
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Catalog(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
