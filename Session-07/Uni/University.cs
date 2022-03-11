using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class University : Institute{

        public Professor[] Professors { get; set; }
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Schedule[] ScheduledCourses { get; set; }
        public Grade[] Grades{ get; set; }

        public University()
        {
            Professors = new Professor[5];
            Students = new Student[30];
            Courses = new Course[20];
            Grades = new Grade[600]; // numOfCourses * numOfStudents
            ScheduledCourses = new Schedule[60];
        }

    }
}
