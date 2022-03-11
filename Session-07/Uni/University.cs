using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class University : Institute {

        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }
        public List<Grade> Grades { get; set; }

        public University() { }

    }
}
