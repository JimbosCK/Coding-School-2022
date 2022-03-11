using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Session_07 {
    public partial class FormHome : Form {
        private Uni.University _university;
        private Uni.UniversityHandler _universityHandler;
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
        #endregion

        private void LoadData() {
            string s = File.ReadAllText(_fileName);

            _universityHandler.University = (Uni.University)JsonSerializer.Deserialize(s, typeof(Uni.University));
            if (_universityHandler.University != null) {
                memoEdit1.Text += "[Loaded University.]" + Environment.NewLine + s + Environment.NewLine;
            }
            else {
                memoEdit1.Text += "University loaded null." + Environment.NewLine;
            }

        }

        private void SaveData() {

            string json = JsonSerializer.Serialize(_universityHandler.University);
            File.WriteAllText(_fileName, json);

            if (_universityHandler.University != null) {
                memoEdit1.Text += "[Saved University.]" + Environment.NewLine + json + Environment.NewLine;
            }
            else {
                memoEdit1.Text += "Saved loaded null." + Environment.NewLine;
            }

        }

        private void InitializeEnviroment() {
            this.Text = _universityHandler.GetUniversityName();
            DebugUniInit();
        }
        private void InitializeData() {
            _universityHandler = new Uni.UniversityHandler();
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
        private void DebugUniInit() {
            _universityHandler.University.Students[0] = new Uni.Student() {
                Name = "Dimitris",
                Age = 25,
                RegistrationNumber = 141209
            };

            _universityHandler.University.Professors[0] = new Uni.Proffesor() {
                Name = "Nick",
                Age = 33,
                Rank = "Phd"
            };

            _universityHandler.University.Courses[0] = new Uni.Course() {
                Code = "0000331420",
                Subject = "Data Structures",
            };

            _universityHandler.University.Grades[0] = new Uni.Grade(_universityHandler.University.Students[0].ID, _universityHandler.University.Courses[0].ID, 5);

            _universityHandler.University.ScheduledCourses[0] = new Uni.Schedule(_universityHandler.University.Courses[0].ID, _universityHandler.University.Professors[0].ID, DateTime.Now);
        }
        private void OpenFormStudents() {
            var formStudents = new FormStudents() {
                Students = _universityHandler.University.Students
            };

            formStudents.Show();
        }

        private void OpenFormProffesors() {

            var formProfessors = new FormProfessor() {
                Professors = _universityHandler.University.Professors
            };

            formProfessors.Show();
        }

        private void OpenFormCourses() {

            var formCourses = new FormCourses() {
                Courses = _universityHandler.University.Courses
            };

            formCourses.Show();
        }
        private void OpenFormGrades() {

            var formGrades = new FormGrades() {
                Grades = _universityHandler.University.Grades
            };

            formGrades.Show();
        }

        private void OpenFormSchedule() {
            var formSchedule = new FormSchedule() {
                Schedules = _universityHandler.University.ScheduledCourses
            };

            formSchedule.Show();
        }

        private void OpenFormUniversity() {
            var formUniversity = new FormUniversity() {
                UniversityName = _universityHandler.University.Name,
                UniversityYearsInService = _universityHandler.University.YearsInService
            };
            formUniversity.Show();
        }

        
    }
}