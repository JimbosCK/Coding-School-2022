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
using Uni;

namespace Session_07 {
    public partial class FormGrades : XtraForm {
        private string _formName = "Grades";
        private Course _selectedCourse;
        private Student _selectedStudent;
        private Grade _selectedGrade;

        public UniversityHandler UHandler { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public FormGrades() {
            InitializeComponent();
        }

        private void FormGrades_Load(object sender, EventArgs e) {
            InitWindow();
            FillStudentList();
            FillCourseList();
            FillGradeList();
        }

        #region Buttons
        private void ButtonDelete_Click(object sender, EventArgs e) {
            RemoveSelectedGrade();
            FillGradeList();
        }
        private void ButtonSave_Click(object sender, EventArgs e) {
            AddNewGrade();
            FillGradeList();
        }
        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region Handlers
        private void ListBoxStudents_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedStudent(); 
        }

        private void ListBoxGrades_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedGrade();
        }
        private void ListBoxCourses_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSelectedCourse();
        }
        #endregion

        #region Methods
        private void InitWindow() {
            this.Text = _formName;
        }
        private void FillStudentList() {
            ListBoxStudents.Items.Clear();

            if (Students != null) {
                foreach (var student in Students) {
                    ListBoxStudents.Items.Add($"{student.Name}");
                }
            }
        }
        private void FillCourseList() {
            if (Courses != null) {
                foreach (var course in Courses) {
                    ListBoxCourses.Items.Add($"{course.Subject}");
                }
            }
        }
        private void FillGradeList() {
            ListBoxGrades.Items.Clear();
            if (Grades != null) {
                foreach (var grade in Grades) {
                    ListBoxGrades.Items.Add($"{grade.StudentID} - {grade.CourseID} : {grade.Value}");
                }
            }
        }
        private void UpdateSelectedStudent() {
            if (ListBoxStudents.SelectedIndex != -1) {
                _selectedStudent = Students[ListBoxStudents.SelectedIndex];
            }
        }
        private void UpdateSelectedCourse() {
            if (ListBoxCourses.SelectedIndex != -1) {
                _selectedCourse = Courses[ListBoxCourses.SelectedIndex];
            }
        }
        private void UpdateSelectedGrade() {
            if (ListBoxGrades.SelectedIndex != -1) {
                _selectedGrade = Grades[ListBoxGrades.SelectedIndex];
            }
        }
        private void RemoveSelectedGrade() {
            Grades.Remove(_selectedGrade);
        }
        private void AddNewGrade() {
            if (CanAddNewGrade()) {
                var newGrade = new Grade(_selectedStudent.ID, _selectedCourse.ID, Convert.ToInt32(spinEditGrade.Text));
                Grades.Add(newGrade);
                SetActiveGrade(newGrade);
            }
        }
        private bool CanAddNewGrade() {
            if (_selectedStudent != null && _selectedCourse != null && spinEditGrade.Text != null)
                return true;
            return false;
        }
        private void SetActiveGrade(Grade activeGrade) {
            if (activeGrade != null)
                ListBoxGrades.SelectedIndex = Grades.IndexOf(activeGrade);
        }
        #endregion


    }
}
