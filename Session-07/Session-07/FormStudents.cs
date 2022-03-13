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
    public partial class FormStudents : XtraForm {
        private Uni.Student _selectedStudent;
        
        public List<Uni.Student> Students { get; set; }

        public FormStudents() {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e) {
            FillList();
            this.Text = "Students";
            
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxStudents.SelectedIndex > -1) {
                SelectStudent();
                DisplayStudent();
            }

        }
        private void SelectStudent() {
            int x = ListBoxStudents.SelectedIndex;
            _selectedStudent = Students[x];
        }
        private void DisplayStudent() {

            if (_selectedStudent != null) {
                TextEditStudentName.Text = _selectedStudent.Name;
                TextEditStudentAge.Text = _selectedStudent.Age.ToString();
                TextEditStudentRegistrationNumber.Text = _selectedStudent.RegistrationNumber.ToString();
            }
            else {
                TextEditStudentName.Text = String.Empty;
                TextEditStudentAge.Text = String.Empty;
                TextEditStudentRegistrationNumber.Text = String.Empty;
            }
        }

        private void UpdateStudent() {
            if (_selectedStudent != null) {
                _selectedStudent.Name = TextEditStudentName.Text;
                _selectedStudent.Age = Convert.ToInt32(TextEditStudentAge.Text);
                _selectedStudent.RegistrationNumber = Convert.ToInt32(TextEditStudentRegistrationNumber.Text);
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e) {
            DeleteStudent();
        }
        private void FillList() {
            ListBoxStudents.Items.Clear();
            if (Students != null) {
                foreach (var professor in Students) {
                    if (professor != null)
                        ListBoxStudents.Items.Add(string.Format("{0} - {1}", professor.Name, professor.RegistrationNumber));
                }
            }
        }
        private void DeleteStudent() {

            if (_selectedStudent != null) {
                Students.Remove(_selectedStudent);
                _selectedStudent = null;
                FillList();
            }
            DisplayStudent();
        }

        private void ButtonNew_Click(object sender, EventArgs e) {
            Uni.Student newStudent = CreateNewStudent();
            Students.Add(newStudent);
            ListBoxStudents.SelectedIndex = Students.IndexOf(newStudent);

            FillList();
        }
        private Uni.Student CreateNewStudent() {
            Uni.Student prof = new Uni.Student() {
                Name = "New..."
            };
            return prof;
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
                UpdateStudent();
                FillList();
                MessageBox.Show("Changes have been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
