using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class University : Institute{
        public Student[] Students;
        public Course[] Courses;
        public Grade[] Grades;
        public Schedule[] ScheduledCourses;

        public University()
        {
            Students = new Student[30];
            Courses = new Course[20];
            Grades = new Grade[600];
            ScheduledCourses = new Schedule[60];
        }

        public Student[] GetStudents()
        {
            return Students;
        }
        public Course[] GetCourses()
        {
            return  Courses;
        }
        public Grade[] GetGrades()
        {
            return Grades;
        }
        public void SetSchedule(Guid CourseID, Guid ProffessorID, DateTime datetime)
        {
            // TODO: University::SetSchedule
        }
    }
}
