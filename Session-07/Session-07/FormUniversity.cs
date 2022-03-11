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
    public partial class FormUniversity : XtraForm {
        private string _formName = "University";
        public Uni.University University{ get; set; }
        public FormUniversity() {
            InitializeComponent();
        }

        private void FormUniversity_Load(object sender, EventArgs e) {
            this.Text = _formName;
            TextEditUniversityName.Text = University.Name;
            TextEditUniversityYearsInService.Text = University.YearsInService.ToString();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            UpdateUniversity();
            MessageBox.Show("Changes Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateUniversity() {
            University.Name = TextEditUniversityName.Text;
            University.YearsInService = Convert.ToInt32(TextEditUniversityYearsInService.Text);
        }
    }
}
