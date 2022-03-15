using DevExpress.XtraEditors;
using Uni;

namespace Session_07 {
    public partial class FormProfessor : XtraForm {
        private Professor _selectedProfessor;
        private Course _selectedGeneralCourse;
        private Course _selectedProfessorCourse;

        public List<Course> Courses { get; set; }
        public List<Professor> Professors { get; set; }
        public FormProfessor() {
            InitializeComponent();
        }
        private void FormProfessors_Load(object sender, EventArgs e) {
            FillProfessorList();
            FillCourseList();
        }
        private void ButtonSave_Click(object sender, EventArgs e) {
            UpdateProfessor();
            FillProfessorList();
            MessageBox.Show("Changes Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ButtonDelete_Click(object sender, EventArgs e) {
            DeleteProfessor();
        }
        private void ButtonNew_Click(object sender, EventArgs e) {
            AddNewProfessor();
        }
        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void ListBoxProfessors_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxProfessors.SelectedIndex > -1) {
                UpdateSelectedProfessor();
                FillProfessorsCoursesList();
                DisplayProfessor();
            }
        }
        private void ListBoxCourses_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxCourses.SelectedIndex != -1) {
                UpdateSelectedCourse();
            }
        }
        private void ListBoxProfessorsCourses_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxProfessorsCourses.SelectedIndex != -1) {
                UpdateSelectedProfessorCourse();
            }
        }
        private void ButtonAddCourse_Click(object sender, EventArgs e) {
            AddSelectedCourseToProfessor();
        }
        private void ButtonDeleteCourse_Click(object sender, EventArgs e) {
            RemoveSelectedCourseFromProfessor();
        }
        private void RemoveSelectedCourseFromProfessor(){
            _selectedProfessor.Courses.Remove(_selectedProfessorCourse);
            FillProfessorsCoursesList();
        }
        private void AddNewProfessor() {
            Professor newProfessor = CreateNewProfessor();

            Professors.Add(newProfessor);
            ListBoxProfessors.SelectedIndex = Professors.IndexOf(newProfessor);
            FillProfessorList(newProfessor);
        }
        private void AddSelectedCourseToProfessor() {
            _selectedProfessor.Courses.Add(_selectedGeneralCourse);
            FillProfessorsCoursesList();
        }
        private void FillProfessorList() {
            ListBoxProfessors.Items.Clear();
            if (Professors != null) {
                foreach (var professor in Professors) {
                    if (professor != null)
                        ListBoxProfessors.Items.Add(string.Format("{0} - {1} ", professor.GetName(), professor.Rank));
                }
            }
        }
        private void FillProfessorList(Professor newProfessor) {
            ListBoxProfessors.Items.Clear();
            if (Professors != null) {
                foreach (var professor in Professors) {
                    if (professor != null)
                        ListBoxProfessors.Items.Add(string.Format("{0} - {1} ", professor.GetName(), professor.Rank));
                }
                ListBoxProfessors.SelectedIndex = Professors.IndexOf(newProfessor);
            }
        }
        private void FillCourseList() {
            ListBoxCourses.Items.Clear();
            if (Courses != null) {
                foreach (var course in Courses) {
                    if (course != null)
                        ListBoxCourses.Items.Add(string.Format("{0} - {1} ", course.Subject, course.Code));
                }
            }
        }
        private void FillProfessorsCoursesList() {
            ListBoxProfessorsCourses.Items.Clear();
            if (_selectedProfessor != null && _selectedProfessor.Courses != null) {
                foreach (var pCourse in _selectedProfessor.Courses) {
                    if (pCourse != null)
                        ListBoxProfessorsCourses.Items.Add(string.Format("{0} - {1} ", pCourse.Subject, pCourse.Code));
                }
            }
        }
        private void UpdateSelectedProfessor() {
            int x = ListBoxProfessors.SelectedIndex;
                _selectedProfessor = Professors[x];
        }
        private void UpdateSelectedCourse() {
            _selectedGeneralCourse = Courses[ListBoxCourses.SelectedIndex];
        }
        private void UpdateSelectedProfessorCourse() {
            _selectedProfessorCourse = _selectedProfessor.Courses[ListBoxProfessorsCourses.SelectedIndex];
        }
        private void DisplayProfessor() {
            if (_selectedProfessor != null) {
                TextEditProfessorName.Text = _selectedProfessor.Name;
                TextEditProfessorAge.Text = _selectedProfessor.Age.ToString();
                TextEditProfessorRank.Text = _selectedProfessor.Rank;
            }
            else {
                ResetTextEdits();
            }
        }
        private void ResetTextEdits() {
            TextEditProfessorName.Text = String.Empty;
            TextEditProfessorAge.Text = String.Empty;
            TextEditProfessorRank.Text = String.Empty;
        }

        private void UpdateProfessor() {
            if (_selectedProfessor != null) {
                _selectedProfessor.Name = TextEditProfessorName.Text;
                _selectedProfessor.Age = Convert.ToInt32(TextEditProfessorAge.Text);
                _selectedProfessor.Rank = TextEditProfessorRank.Text;
            }
        }
        private void DeleteProfessor() {
            if (_selectedProfessor != null) {
                Professors.Remove(_selectedProfessor);
                _selectedProfessor = null;
                FillProfessorList();
            }
            DisplayProfessor();
        }
        private Professor CreateNewProfessor() {
            Professor prof = new Professor() {
                Name = "New..."
            };
            return prof;
        }

    }
}
