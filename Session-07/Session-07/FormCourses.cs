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
    public partial class FormCourses : XtraForm {
        private Uni.Course _selectedCourse;
        public List<Uni.Course> Courses { get; set; }
        public FormCourses() {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e) {
            this.Text = "Courses";
            FillList();


        }
        private void listBoxControl_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxCourses.SelectedIndex > -1) {
                SelectCourse();
                DisplayCourse();
            }

        }
        private void SelectCourse() {
            int x = ListBoxCourses.SelectedIndex;
            _selectedCourse = Courses[x];
        }
        private void DisplayCourse() {

            if (_selectedCourse != null) {
                TextEditCourseSubject.Text = _selectedCourse.Subject;
                TextEditCourseCode.Text = _selectedCourse.Code;
            }
            else {
                TextEditCourseSubject.Text = String.Empty;
                TextEditCourseCode.Text = String.Empty;
            }
        }

        private void UpdateCourse() {

            if (_selectedCourse != null) {
                _selectedCourse.Subject = TextEditCourseSubject.Text;
                _selectedCourse.Code = TextEditCourseCode.Text;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e) {
            DeleteCourse();
        }
        private void FillList() {
            ListBoxCourses.Items.Clear();
            if (Courses != null) {
                foreach (var cr in Courses) {
                    if (cr != null)
                        ListBoxCourses.Items.Add(string.Format("{0} - {1} ", cr.Subject, cr.Code));
                }
            }
            else {
                Courses.Add(CreateNewCourse());
            }

        }
        private void DeleteCourse() {

            if (_selectedCourse != null) {

                Courses.Remove(_selectedCourse);

                _selectedCourse = null;

                FillList();
            }
            DisplayCourse();
        }

        private void ButtonNew_Click(object sender, EventArgs e) {
            Uni.Course newCourse = CreateNewCourse();
            Courses.Add(newCourse);
            ListBoxCourses.SelectedIndex = Courses.IndexOf(newCourse);

            FillList();

        }
        private Uni.Course CreateNewCourse() {
            Uni.Course prof = new Uni.Course() {
                Subject = "New..."
            };
            return prof;
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            UpdateCourse();
            FillList();
            MessageBox.Show("Changes have been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
