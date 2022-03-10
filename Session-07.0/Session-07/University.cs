using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Session_07 {
    [Serializable]
    public class Test {
        public int MyProperty { get; set; }
        public Test() { }


    public partial class University : Form {
        private UniversitySystem.University _university;
        private Test _test;

            private string _loadFileName = "load.txt";
        public University() {
            InitializeComponent();
        }

        private void MenuItemFileLoad_Click(object sender, EventArgs e) {
            LoadData();
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e) {
            SaveData();
        }


        private void LoadData() {

            string loadedData = File.ReadAllText(_loadFileName);

            //textBox1.Text = s;

            _university = (UniversitySystem.University)JsonSerializer.Deserialize(loadedData, typeof(UniversitySystem.University));

            MessageBox.Show("Loaded OK!");
        }

        private void SaveData() {
            _university = new UniversitySystem.University();
                _test = new Test();
            string json = JsonSerializer.Serialize(_university);

            File.WriteAllText(_loadFileName, json);

            string jsonString = (Test)JsonSerializer.Serialize(_test);


            MessageBox.Show("File Saved!");
        }


    }
}
