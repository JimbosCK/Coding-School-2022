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
            MessageBox.Show("Changes have been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FillList() {
            ListBoxProfessors.Items.Clear();
            if (Professors != null) {
                foreach (var professor in Professors) {
                    if (professor != null)
                        ListBoxProfessors.Items.Add(string.Format("{0} - {1} ", professor.Name, professor.Rank));
                }
            }
            else {
                Professors.Add(CreateNewProfessor());
            }

        }

        private void ListBoxProfessors_SelectedIndexChanged(object sender, EventArgs e) {
            if(ListBoxProfessors.SelectedIndex > -1) {
                SelectProfessor();
                DisplayProfessor();
            }
        }

        private void SelectProfessor() {
            int x = ListBoxProfessors.SelectedIndex;
                _selectedProfessor = Professors[x];
        }
        private void DisplayProfessor() {

            if (_selectedProfessor != null) {
                TextEditProfessorName.Text = _selectedProfessor.Name;
                TextEditProfessorAge.Text = _selectedProfessor.Age.ToString();
                TextEditProfessorRank.Text = _selectedProfessor.Rank;
            }
            else {
                TextEditProfessorName.Text = String.Empty;
                TextEditProfessorAge.Text = String.Empty;
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

        private void ButtonDelete_Click(object sender, EventArgs e) {
            DeleteProfessor();
        }

        private void DeleteProfessor() {

            if (_selectedProfessor != null) {

                Professors.Remove(_selectedProfessor);

                _selectedProfessor = null;

                FillList();
            }
            DisplayProfessor();
        }

        private void ButtonNew_Click(object sender, EventArgs e) {
            Uni.Professor newProfessor = CreateNewProfessor();
            Professors.Add(newProfessor);
            ListBoxProfessors.SelectedIndex = Professors.IndexOf(newProfessor);

            FillList();

        }
        private Uni.Professor CreateNewProfessor() {
            Uni.Professor prof = new Uni.Professor() {
                Name = "New..."
            };
            return prof;
        }
    }
}
