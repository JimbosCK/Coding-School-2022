using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class UniversityHandler {
        private int _numberOfSchedules = 0;

        public University University{ get; set; }

        public UniversityHandler() {
            University = new University();
            University.Students = new List<Student>();
            University.Courses = new List<Course>();
            University.Grades = new List<Grade>();
            University.Professors = new List<Professor>();
            University.ScheduledCourses = new List<Schedule>();

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

    }
}
