﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Institute {
        public Guid ID { get; set; }
        public string Name;
        public int YearsInService { get; set; }

        public Institute() { 
            ID = Guid.NewGuid();
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string _name)
        {
            Name = _name;
        }
    }
}
