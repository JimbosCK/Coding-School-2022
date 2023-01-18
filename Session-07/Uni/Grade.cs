using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    public class Grade {
        public string ID { get; set;  }
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public int Value { get; set; } //Grade

        public Grade()
        {
            ID = Guid.NewGuid().ToString();
        }
        public Grade( string studentID, string courseID)
        {
            ID = Guid.NewGuid().ToString();
            StudentID = studentID; 
            CourseID = courseID;
        }

        public Grade(string studentID, string courseID, int value) {
            ID = Guid.NewGuid().ToString();
            StudentID = studentID;
            CourseID = courseID;
            Value = value;
        }
        
    }
}
