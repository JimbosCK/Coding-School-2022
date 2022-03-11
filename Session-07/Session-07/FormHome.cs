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
        #endregion

        private void LoadData() {
            //_universityHandler = new Uni.UniversityHandler();

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

        private void OpenFormStudents() {
            _universityHandler.University.Students[0] = new Uni.Student() {
                Name = "Dimitris",
                Age = 25,
                RegistrationNumber = 141209
            };

            var formStudents = new FormStudents() {
                Students = _universityHandler.University.Students
            };

            formStudents.Show();
        }

        private void OpenFormProffesors() {
            _universityHandler.University.Professors[0] = new Uni.Proffesor() {
                Name = "Nick",
                Age = 33,
                Rank = "Phd"
            };

            var formProfessors = new FormProfessor() {
                Professors = _universityHandler.University.Professors
            };

            formProfessors.Show();
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