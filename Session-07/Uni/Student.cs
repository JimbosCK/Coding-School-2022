using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    [Serializable]
    public class Student : Person{
        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }

        public Student(){
            Courses = new List<Course>();
        }

        public void Attend(Course course, DateTime datetime){
            //TODO: Student::Attend()
        }
        public void WriteExam(Course course, DateTime datetime) {
            //TODO: Student::WriteExam()
        }

    }
}
