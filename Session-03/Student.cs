﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Student {
        public int RegistrationNumber { get; set; }
        public Course[] Courses;

        public Student(){
            Courses = new Course[20];
        }

        public void Attend(Course course, DateTime datetime){
            //TODO: Student::Attend()
        }
        public void WriteExam(Course course, DateTime datetime) {
            //TODO: Student::WriteExam()
        }

    }
}
