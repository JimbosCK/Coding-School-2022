using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07 {
    public partial class FormCourses : XtraForm {
        public List<Uni.Course> Courses { get; set; }
        public FormCourses() {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e) {
            this.Text = "Courses";
            TextEditCourseCode.Text = Courses[0].Code;
            TextEditCourseSubject.Text = Courses[0].Subject;
        }
    }
}
