using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    public class Professor : Person {
        public string Rank { get; set; }
        public List<Course> Courses;

        public Professor() {

        }

        public string GetName() {
            if (!Name.StartsWith("Dr. ")) {
                Name = "Dr. " + Name;
            }
            return Name;
        }
        public new void SetName(string _name) {
            Name = _name;

            if (!Name.StartsWith("Dr. ")) {
                Name = "Dr. " + Name;
            }
        }

        public void Teach(Course course, DateTime datetime) {
            // TODO: Proffesor::Teach() 
        }

        public void SetGrade(Guid studentID, Guid courseID, Grade grade) {
            // TODO: Proffesor::SetGrade() 
        }

        public Professor ShallowCopy() {
            return (Professor)MemberwiseClone();
        }
    }
}
