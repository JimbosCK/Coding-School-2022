using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Uni;

namespace Session_07 {
    public partial class FormHome : XtraForm{
        private UniversityHandler _universityHandler;
        private string _fileName = "test.json";

        public FormHome() {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e) {
            InitializeData();
            InitializeEnviroment();

        }

        #region UI
        private void MenuItemFileLoad_Click(object sender, EventArgs e) {
            LoadData();
        }
        private void MenuItemFileSave_Click(object sender, EventArgs e) {
            SaveData();
        }
        private void MenuItemProfessorsEdit_Click(object sender, EventArgs e) {
            OpenFormProffesors();
        }
        private void MenuItemUniversityEdit_Click(object sender, EventArgs e) {
            OpenFormUniversity();
        }
        private void MenuItemStudentsEdit_Click(object sender, EventArgs e) {
            OpenFormStudents();
        }
        private void MenuItemCoursesEdit_Click(object sender, EventArgs e) {
            OpenFormCourses();
        }
        private void MenuItemGradesEdit_Click(object sender, EventArgs e) {
            OpenFormGrades();
        }
        private void MenuItemScheduleEdit_Click(object sender, EventArgs e) {
            OpenFormSchedule();
        }
        private void FormHome_FormClosing(object sender, FormClosingEventArgs e) {
            SaveData();
        }
        #endregion

        #region I/O
        private void LoadData() {
            string ipnutJSON = File.ReadAllText(_fileName);
            try {
                _universityHandler.University = (University)System.Text.Json.JsonSerializer.Deserialize(ipnutJSON, typeof(University));
            }
            catch (Exception) {
                _universityHandler = new UniversityHandler();
            }
            if (_universityHandler.University != null) {
                memoEdit1.Text += "[Loaded University.]" + Environment.NewLine + ipnutJSON + Environment.NewLine;
            }
            else {
                memoEdit1.Text += "University loaded null." + Environment.NewLine;
            }

        }

        private void SaveData() {
            Console.WriteLine(_universityHandler.University);

            string outputJSON = JsonConvert.SerializeObject(_universityHandler.University);
            File.WriteAllText(_fileName, outputJSON);

            if (_universityHandler.University != null) {
                memoEdit1.Text += "[Saved University.]" + Environment.NewLine + outputJSON + Environment.NewLine;
            }
            else {
                memoEdit1.Text += "Saved loaded null." + Environment.NewLine;
            }

        }
        #endregion

        #region OpenMethods
        private void OpenFormStudents() {
            var formStudents = new FormStudents() {
                Students = _universityHandler.University.Students,
                Courses = _universityHandler.University.Courses
            };

            formStudents.ShowDialog();
        }
        private void OpenFormProffesors() {

            var formProfessors = new FormProfessor() {
                Professors = _universityHandler.University.Professors,
                Courses = _universityHandler.University.Courses
            };

            formProfessors.ShowDialog();
        }
        private void OpenFormCourses() {

            var formCourses = new FormCourses() {
                Courses = _universityHandler.University.Courses
            };

            formCourses.ShowDialog();
        }
        private void OpenFormGrades() {

            var formGrades = new FormGrades() {
                Grades = _universityHandler.University.Grades,
                Students = _universityHandler.University.Students,
                Courses = _universityHandler.University.Courses
            };

            formGrades.ShowDialog();
        }
        private void OpenFormSchedule() {
            var formSchedule = new FormSchedule() {
                Schedules = _universityHandler.University.ScheduledCourses
            };

            formSchedule.ShowDialog();
        }
        private void OpenFormUniversity() {
            var formUniversity = new FormUniversity() {
                University = _universityHandler.University
            };
            formUniversity.ShowDialog();
        }
        #endregion

        #region INIT
        private void InitializeEnviroment() {
            this.Text = _universityHandler.GetUniversityName();
            //DebugUniInit();
        }
        private void InitializeData() {
            _universityHandler = new UniversityHandler();
            _universityHandler.University = new University();
            _universityHandler.University.Professors = new List<Professor>();
            LoadData();
            if (_universityHandler.University.Name == null) {
                LoadDefaultData();
            }
        }
        private void LoadDefaultData() {
            _universityHandler.University = new Uni.University() {
                Name = "University",
                YearsInService = 25
            };
        }

        #endregion


    }
}