﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07 {
    public partial class FormStudents : Form {
        public Uni.Student[] Students { get; set; }
        public FormStudents() {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e) {
            TextEditStudentName.Text = Students[0].Name;
            TextEditStudentAge.Text = Students[0].Age.ToString();
            TextEditStudentRegistrationNumber.Text = Students[0].RegistrationNumber.ToString();
        }
    }
}
