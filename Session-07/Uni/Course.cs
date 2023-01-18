using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class Course {
        public string ID { get; }
        public string Code { get; set; }

        public string Subject { get; set; }

        public Course() {
            ID = Guid.NewGuid().ToString();    
        }
    }
}
