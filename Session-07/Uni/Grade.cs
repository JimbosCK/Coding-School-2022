using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    public class Grade {
        public string ID { get; }
        public string StudentID { get;  }
        public string CourseID { get; }
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
