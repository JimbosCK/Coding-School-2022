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
        public List<Student> GetStudents() {
            return University.Students;
        }
        public List<Course> GetCourses() {
            return University.Courses;
        }
        public List<Grade> GetGrades() {
            return University.Grades;
        }
        public void SetCourse(Guid courseID, Guid professorID, DateTime datetime) {
            University.ScheduledCourses[_numberOfSchedules++] = new Schedule(courseID, professorID, datetime);
        }

        public Student? GetStudentById(Guid studentID) {
            Student student = null;
            foreach (var st in University.Students) {
                if (st.ID == studentID) { student = st; }
            }

            return student;
        }
        public Course? GetCourseById(Guid courseID) {
            Course course = null;
            foreach (var cr in University.Courses) {
                if (cr.ID == courseID) { course = cr; }
            }

            return course;
        }

    }
}
