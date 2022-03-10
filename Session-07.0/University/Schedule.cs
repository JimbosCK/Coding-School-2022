using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem {
    public class Schedule {
        public Guid ID { get; }
        public Guid CourseID { get; }
        public Guid ProffesorID { get; }
        public DateTime Callendar { get; set; }
    }
}
