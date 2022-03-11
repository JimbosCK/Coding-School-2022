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
    public partial class FormUniversity : Form {
        public string UniversityName { get; set; }
        public int UniversityYearsInService { get; set; }
        public FormUniversity() {
            InitializeComponent();
        }

        private void FormUniversity_Load(object sender, EventArgs e) {
            TextEditUniversityName.Text = UniversityName;
            TextEditUniversityYearsInService.Text = UniversityYearsInService.ToString();
        }
    }
}
