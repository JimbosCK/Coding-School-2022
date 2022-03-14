using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Uni;

namespace Session_07 {
    public partial class FormHome : XtraForm {
        private Uni.University _university  ;
        private Uni.UniversityHandler _universityHandler = new Uni.UniversityHandler();
        private string _fileName = "test.json";

        public FormHome() {
            InitializeComponent();

        }
        #region UI

        private void Form1_Load(object sender, EventArgs e) {
            InitializeData();
            InitializeEnviroment();

        }

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
            string s = File.ReadAllText(_fileName);
            try {
                _universityHandler.University = (Uni.University)System.Text.Json.JsonSerializer.Deserialize(s, typeof(Uni.University));
            }
            catch (Exception) {
                _universityHandler = new Uni.UniversityHandler();
            }
            if (_universityHandler.University != null) {
                memoEdit1.Text += "[Loaded University.]" + Environment.NewLine + s + Environment.NewLine;
            }
            else {
                memoEdit1.Text += "University loaded null." + Environment.NewLine;
            }

        }

        private void SaveData() {
            Console.WriteLine(_universityHandler.University);

            string json = JsonConvert.SerializeObject(_universityHandler.University);
            File.WriteAllText(_fileName, json);

            if (_universityHandler.University != null) {
                memoEdit1.Text += "[Saved University.]" + Environment.NewLine + json + Environment.NewLine;
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
                UHandler = _universityHandler
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
            _universityHandler = new Uni.UniversityHandler();
            _universityHandler.University = new Uni.University();
            _universityHandler.University.Professors = new List<Uni.Professor>();
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