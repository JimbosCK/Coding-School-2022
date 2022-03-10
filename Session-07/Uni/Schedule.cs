using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    public class Schedule {
        public Guid ID { get; }
        public Guid CourseID { get; }
        public Guid ProffesorID { get; }
        public DateTime Callendar { get; set; }

        public Schedule() { 
            ID = Guid.NewGuid();
        }
        public Schedule(Guid courseID, Guid professorID, DateTime callendar) {
            ID = Guid.NewGuid();
            CourseID = courseID;
            ProffesorID = professorID;
            Callendar = callendar;
        }
    }
}
