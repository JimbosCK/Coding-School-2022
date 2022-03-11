using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    public class UniversityHandler {
        private int _numberOfSchedules = 0;

        public University University{ get; set; }

        public UniversityHandler() {
            University = new University();
        }
        public string GetUniversityName() {
            return University.Name;
        }
        public Student[] GetStudents() {
            return University.Students;
        }
        public Course[] GetCourses() {
            return University.Courses;
        }
        public Grade[] GetGrades() {
            return University.Grades;
        }
        public void SetCourse(Guid courseID, Guid professorID, DateTime datetime) {
            University.ScheduledCourses[_numberOfSchedules++] = new Schedule(courseID, professorID, datetime);
        }
    }
}
