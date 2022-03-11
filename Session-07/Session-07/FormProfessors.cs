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
        private int _selectedIndex;

        public List<Uni.Professor> Professors { get; set; }
        public FormProfessor() {
            InitializeComponent();
        }

        private void FormProfessors_Load(object sender, EventArgs e) {
            FillList();
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            UpdateProfessorList();
            FillList();
        }

        private void FillList() {
            ListBoxProfessors.Items.Clear();
            foreach (var professor in Professors) {
                if (professor != null)
                    ListBoxProfessors.Items.Add(string.Format("{0} - {1} ", professor.Name, professor.Rank));
            }
        }

        private void ListBoxProfessors_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedIndex = ListBoxProfessors.SelectedIndex;
            _selectedProfessor = Professors[ListBoxProfessors.SelectedIndex];
            FillProfessor();
        }

        private void FillProfessor() {
            if (_selectedProfessor != null) {
                TextEditProfessorName.Text = _selectedProfessor.Name;
                TextEditProfessorAge.Text = _selectedProfessor.Age.ToString();
                TextEditProfessorRank.Text = _selectedProfessor.Rank;
            }
        }
        private void UpdateProfessorList() {
            if (_selectedProfessor != null) {
                _selectedProfessor.Name = TextEditProfessorName.Text;
                _selectedProfessor.Age = Convert.ToInt32(TextEditProfessorAge.Text);
                _selectedProfessor.Rank = TextEditProfessorRank.Text;
                FillList();

            }

        }
    }
}
