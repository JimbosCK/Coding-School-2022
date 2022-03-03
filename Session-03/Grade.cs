using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Grade {
        public Guid ID { get; }
        public Guid StudentID { get;  }
        public Guid CourseID { get; }
        public int Value { get; set; } //Grade

        public Grade()
        {

        }
        public Grade( Guid _studentID, Guid _courseID)
        {
            ID = Guid.NewGuid();
            StudentID = _studentID; 
            CourseID = _courseID;
        }
    }
}
