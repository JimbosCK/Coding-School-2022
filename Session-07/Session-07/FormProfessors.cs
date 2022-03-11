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
    public partial class FormProfessor : XtraForm {
        private Uni.Professor _selectedProfessor;

        public Uni.Professor[] Professors { get; set; }
        public FormProfessor() {
            InitializeComponent();
        }

        private void FormProfessors_Load(object sender, EventArgs e) {
            FillList();
        }

        private void FillList() {
            foreach (var professor in Professors) {
                if(professor != null)
                    ListBoxProfessors.Items.Add(string.Format("{0} - {1} ",professor.Name, professor.Rank));
            }
        }

        private void ListBoxProfessors_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedProfessor = Professors[ListBoxProfessors.SelectedIndex];
            FillProfessor();
        }

        private void FillProfessor() {
            if(_selectedProfessor != null) {
                TextEditProfessorName.Text = _selectedProfessor.Name;
                TextEditProfessorAge.Text = _selectedProfessor.Age.ToString();
                TextEditProfessorRank.Text = _selectedProfessor.Rank;
            }
        }
    }
}
