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
        private Uni.Course _selectedGeneralCourse;
        private Uni.Course _selectedStudentCourse;

        public List<Uni.Student> Students { get; set; }
        public List<Uni.Course> Courses { get; set; }

        public FormStudents() {
            InitializeComponent();
        }
        private void FormStudents_Load(object sender, EventArgs e) {
            FillListStudents();
            FillCourseList();
            this.Text = "Students";
            
        }
        #region Buttons
        private void ButtonDelete_Click(object sender, EventArgs e) {
            DeleteStudent();
        }

        private void ButtonNew_Click(object sender, EventArgs e) {
            Uni.Student newStudent = CreateNewStudent();
            Students.Add(newStudent);
            ListBoxStudents.SelectedIndex = Students.IndexOf(newStudent);

            FillListStudents(newStudent);
        }
        private void ButtonSave_Click(object sender, EventArgs e) {
                UpdateStudent();
                FillListStudents();
                MessageBox.Show("Changes have been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void ButtonDeleteCourse_Click(object sender, EventArgs e) {
            RemoveSelectedCourseFromStudent();
        }
        private void ButtonAddCourse_Click(object sender, EventArgs e) {
            AddSelectedCourseToStudent();
        }
        #endregion

        #region ListBoxIndexChanged
        private void ListBoxStudents_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxStudents.SelectedIndex > -1) {
                SelectStudent();
                FillStudentsCoursesList();
                DisplayStudent();
            }
        }
        private void ListBoxCourses_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxCourses.SelectedIndex != -1) {
                UpdateSelectedCourse();
            }
        }
        private void ListBoxStudentsCourses_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedStudentsCourse();
        }
        #endregion

        #region Student Methods
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
        private void DeleteStudent() {

            if (_selectedStudent != null) {
                Students.Remove(_selectedStudent);
                _selectedStudent = null;
                FillListStudents();
            }
            DisplayStudent();
        }
        private Uni.Student CreateNewStudent() {
            Uni.Student student = new Uni.Student() {
                Name = "New..."
            };
            return student;
        }
        private void UpdateStudent() {
            if (_selectedStudent != null) {
                _selectedStudent.Name = TextEditStudentName.Text;
                _selectedStudent.Age = Convert.ToInt32(TextEditStudentAge.Text);
                _selectedStudent.RegistrationNumber = Convert.ToInt32(TextEditStudentRegistrationNumber.Text);
            }
        }
        private void FillListStudents() {
            ListBoxStudents.Items.Clear();
            if (Students != null) {
                foreach (var student in Students) {
                    if (student != null)
                        ListBoxStudents.Items.Add(string.Format("{0} - {1}", student.Name, student.RegistrationNumber));
                }
            }
        }
        private void FillListStudents(Uni.Student newStudent) {
            ListBoxStudents.Items.Clear();
            if (Students != null) {
                foreach (var student in Students) {
                    if (student != null)
                        ListBoxStudents.Items.Add(string.Format("{0} - {1}", student.Name, student.RegistrationNumber));
                }
                ListBoxStudents.SelectedIndex = Students.IndexOf(newStudent);
            }
        }
        #endregion

        #region Courses
        private void FillCourseList() {
            ListBoxCourses.Items.Clear();
            if (Courses != null) {
                foreach (var course in Courses) {
                    if (course != null)
                        ListBoxCourses.Items.Add(string.Format("{0} - {1} ", course.Subject, course.Code));
                }
            }
        }
        private void UpdateSelectedCourse() {
            if (ListBoxCourses.SelectedIndex != -1) {
                _selectedGeneralCourse = Courses[ListBoxCourses.SelectedIndex];
            }
        }
        private void AddSelectedCourseToStudent() {
            _selectedStudent.Courses.Add(_selectedGeneralCourse);
            FillStudentsCoursesList(_selectedGeneralCourse);
        }

        private void RemoveSelectedCourseFromStudent() {
            _selectedStudent.Courses.Remove(_selectedStudentCourse);
            FillStudentsCoursesList();
        }
        #endregion

        #region Students Courses
        private void UpdateSelectedStudentsCourse() {
            if (ListBoxStudentsCourses.SelectedIndex != -1) {
                _selectedStudentCourse = _selectedStudent.Courses[ListBoxStudentsCourses.SelectedIndex];
            }
        }
        private void FillStudentsCoursesList() {
            ListBoxStudentsCourses.Items.Clear();
            if (_selectedStudent != null && _selectedStudent.Courses != null) {
                foreach (var pCourse in _selectedStudent.Courses) {
                    if (pCourse != null)
                        ListBoxStudentsCourses.Items.Add(string.Format("{0} - {1} ", pCourse.Subject, pCourse.Code));
                }
            }
        }
        private void FillStudentsCoursesList(Uni.Course newCourse) {
            ListBoxStudentsCourses.Items.Clear();
            if (_selectedStudent != null && _selectedStudent.Courses != null) {
                foreach (var pCourse in _selectedStudent.Courses) {
                    if (pCourse != null)
                        ListBoxStudentsCourses.Items.Add(string.Format("{0} - {1} ", pCourse.Subject, pCourse.Code));
                }
                ListBoxStudentsCourses.SelectedIndex = Courses.IndexOf(newCourse);
            }
        }
        #endregion
    }
}
