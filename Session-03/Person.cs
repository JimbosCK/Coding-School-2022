using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Person {

        public Guid ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { 
            ID = Guid.NewGuid();
            Name = "N/A";
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
