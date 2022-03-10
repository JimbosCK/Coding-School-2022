using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Session_07 {
    public partial class FormUniversity : Form {
        private Uni.University _university;

        private string _fileName = "test.json";
        
        public FormUniversity() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            _university = new Uni.University() {
                Name = "PADA",
                ID = Guid.NewGuid()
            };

        }

        private void MenuItemFileLoad_Click(object sender, EventArgs e) {
            LoadData();
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e) {
            SaveData();
        }

        private void LoadData() {
            string s = File.ReadAllText(_fileName);

            _university = (Uni.University)JsonSerializer.Deserialize(s, typeof(Uni.University));

            MessageBox.Show("Loaded OK!");
        }

        private void SaveData() {

            string json = JsonSerializer.Serialize(_university);

            File.WriteAllText(_fileName, json);

            MessageBox.Show("File Saved!");
        }

        private void MenuItemProfessorsEdit_Click(object sender, EventArgs e) {

            FormProfessor formProfessors = new FormProfessor() {
                ProfessorName = "Takis",
                ProfessorAge = 18,
                ProfessorRank = "Lektoras"
            };

            formProfessors.Show();

        }
    }
}