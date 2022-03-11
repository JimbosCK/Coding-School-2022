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
        private Uni.Course _selectedCourse;
        private Uni.Student _selectedStudent;
        private Uni.Grade _selectedGrade;

        public Uni.UniversityHandler UHandler { get; set; }
        public FormGrades() {
            InitializeComponent();
        }

        private void FormGrades_Load(object sender, EventArgs e) {
            this.Text = _formName;
            FillStudentList();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ListBoxStudents_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedStudent();
            loadGradesByStudent(UHandler.University.Students[ListBoxStudents.SelectedIndex]);
        }

        private void ButtonDelete_Click(object sender, EventArgs e) {
            deleteGrade();
        }
        private void ButtonAdd_Click(object sender, EventArgs e) {
            FillCourses();
            ResetGradeIN();
        }
        private void ListBoxGrades_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedGrade();
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            UpdateGrades();
            MessageBox.Show("Changes Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListBoxCourses_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedCourse();
        }


        private void UpdateSelectedCourse() {
            _selectedCourse = UHandler.University.Courses[ListBoxCourses.SelectedIndex];
        }
        private void UpdateSelectedGrade() {
            if (ListBoxGrades.SelectedIndex > -1) {
                _selectedGrade = UHandler.University.Grades[ListBoxGrades.SelectedIndex];
            }
        }
        private void UpdateSelectedStudent() {
            if (ListBoxStudents.SelectedIndex != -1) {
                _selectedStudent = UHandler.University.Students[ListBoxStudents.SelectedIndex];
            }
        }
        private void FillStudentList() {
            ListBoxStudents.Items.Clear();
            if (UHandler.University.Students != null) {
                foreach (var std in UHandler.University.Students) {
                    if (std != null)
                        ListBoxStudents.Items.Add(string.Format("{0} ", std.Name));
                }
            }
        }

        void loadGradesByStudent(Uni.Student currentStudent) {
            ListBoxGrades.Items.Clear();
            List<Uni.Grade> studentGrades = UHandler.GetGradesByStudentID(currentStudent.ID);
            string courseCode;
            if (studentGrades != null) {
                foreach (var gr in studentGrades) {
                    if (gr != null) {
                        courseCode = UHandler.GetSubjectCodeByID(gr.CourseID);
                        ListBoxGrades.Items.Add(string.Format("{0}: {1} ", courseCode, gr.Value));
                    }

                }
            }
        }

        private void deleteGrade() {
            UHandler.University.Grades.Remove(_selectedGrade);
            FillStudentList();
        }
        private void FillCourses() {
            foreach (var course in UHandler.University.Courses) {
                ListBoxCourses.Items.Add(string.Format("{0} - {1} ", course.Subject, course.Code));
            }
        }
        private void ResetGradeIN() {
            TextEditGradeIN.Text = "0";
        }
        private void UpdateGrades() {
            var newGrade = new Uni.Grade(_selectedCourse.ID, _selectedStudent.ID, Convert.ToInt32(TextEditGradeIN.Text));
            UHandler.University.Grades.Add(newGrade);
            FillStudentList();
        }


    }
}
