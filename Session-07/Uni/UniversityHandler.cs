using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    internal class UniversityHandler {
        public Proffesor[] Professors { get; set; }
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Schedule Schedule { get; set; }
        
        public UniversityHandler() {
            Professors = new Proffesor[5];
            Students = new Student[30];
            Courses = new Course[20];
            Schedule = new Schedule();
        }
    }
}
