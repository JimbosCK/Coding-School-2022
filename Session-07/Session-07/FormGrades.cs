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
    public partial class FormGrades : XtraForm {
        private string _formName = "Grades";

        public int Value { get; set; }
        public List<Uni.Grade> Grades { get; set; }
        public FormGrades() {
            InitializeComponent();
        }

        private void FormGrades_Load(object sender, EventArgs e) {
            this.Text = _formName;
            TextEditGradeValue.Text = Grades[0].Value.ToString();
        }
    }
}
