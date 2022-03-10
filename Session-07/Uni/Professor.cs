﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni {
    public class Proffesor : Person {
        public string Rank { get; set; }
        public Course[] Courses;

        public Proffesor() {
            Courses = new Course[20];
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
    }
}
