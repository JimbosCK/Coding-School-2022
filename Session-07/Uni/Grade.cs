using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    public class Grade {
        public Guid ID { get; }
        public Guid StudentID { get;  }
        public Guid CourseID { get; }
        public int Value { get; set; } //Grade

        public Grade()
        {

        }
        public Grade( Guid studentID, Guid courseID)
        {
            ID = Guid.NewGuid();
            StudentID = studentID; 
            CourseID = courseID;
        }

        public Grade(Guid studentID, Guid courseID, int value) {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            Value = value;
        }
        
    }
}
