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

        public List<Grade> GetGradesByStudentID(Guid stdudentID) {
            List<Grade> grades = new List<Grade>();

            foreach (var gr in University.Grades) {
                if (gr.StudentID == stdudentID)
                    grades.Add(gr);
            }

            return grades;
        }
        public string GetSubjectCodeByID(Guid courseID) {
            string subject = string.Empty;
            foreach (var cr in University.Courses) {
                if (cr.ID == courseID)
                    subject = cr.Subject;
            }

            return subject;
        }

        public Course GetCourseByCode(string code) {
            Course course = null ;
            foreach (var item in University.Courses) {
                if(item.Code == code) {
                    course = item;
                }
            }
            return course;
        }

    }
}
