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
        private Uni.Professor _orignalProfessor;
        private int _selectedIndex;

        public List<Uni.Professor> Professors { get; set; }
        public FormProfessor() {
            InitializeComponent();
        }

        private void FormProfessors_Load(object sender, EventArgs e) {
            FillList();
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            UpdateProfessor();
            FillList();
        }

        private void FillList() {
            int rrr = ListBoxProfessors.SelectedIndex;
            ListBoxProfessors.Items.Clear();
            rrr = ListBoxProfessors.SelectedIndex;

            foreach (var professor in Professors) {
                if (professor != null)
                    ListBoxProfessors.Items.Add(string.Format("{0} - {1} ", professor.Name, professor.Rank));
            }
        }

        private void ListBoxProfessors_SelectedIndexChanged(object sender, EventArgs e) {
            if(ListBoxProfessors.SelectedIndex > -1) {
                SelectProfessor();
                DisplayProfessor();
            }
        }

        private void SelectProfessor() {
                _selectedProfessor = Professors[ListBoxProfessors.SelectedIndex];
        }
        private void DisplayProfessor() {

            if (_selectedProfessor != null) {
                TextEditProfessorName.Text = _selectedProfessor.Name;
                TextEditProfessorAge.Text = _selectedProfessor.Age.ToString();
                TextEditProfessorRank.Text = _selectedProfessor.Rank;
            }
            else {
                TextEditProfessorName.Text = String.Empty;
                TextEditProfessorAge.Text = "0";
                TextEditProfessorRank.Text = String.Empty;
            }
        }

        private void UpdateProfessor() {

            //_orignalProfessor = _selectedProfessor.ShallowCopy();
            
            if (_selectedProfessor != null) {
                _selectedProfessor.Name = TextEditProfessorName.Text;
                _selectedProfessor.Age = Convert.ToInt32(TextEditProfessorAge.Text);
                _selectedProfessor.Rank = TextEditProfessorRank.Text;
            }
        }
    }
}
