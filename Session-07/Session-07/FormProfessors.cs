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
    public partial class FormProfessor : Form {
        public string ProfessorName { get; set; }
        public int ProfessorAge { get; set; }
        public string ProfessorRank { get; set; }
        public FormProfessor() {
            InitializeComponent();
        }

        private void FormProfessors_Load(object sender, EventArgs e) {
            TextEditProfessorName.Text = ProfessorName;
            TextEditProfessorAge.Text = ProfessorAge.ToString();
            TextEditProfessorRank.Text = ProfessorRank;
        }
    }
}
