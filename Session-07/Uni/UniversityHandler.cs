using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    internal class UniversityHandler {
        private int _numberOfSchedules = 0;

        public University Uni{ get; set; }

        public UniversityHandler() {
            Uni = new University();
        }

        public Student[] GetStudents() {
            return Uni.Students;
        }
        public Course[] GetCourses() {
            return Uni.Courses;
        }
        public Grade[] GetGrades() {
            return Uni.Grades;
        }
        public void SetCourse(Guid courseID, Guid professorID, DateTime datetime) {
            Uni.ScheduledCourses[_numberOfSchedules++] = new Schedule(courseID, professorID, datetime);
        }
    }
}
