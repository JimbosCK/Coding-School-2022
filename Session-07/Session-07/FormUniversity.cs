using DevExpress.XtraEditors;
using Uni;

namespace Session_07 {
    public partial class FormUniversity : XtraForm {
        private string _formName = "University";
        public University University { get; set; }
        public FormUniversity() {
            InitializeComponent();
        }
        private void FormUniversity_Load(object sender, EventArgs e) {
            this.Text = _formName;

            BSUniversity.DataSource = this.University;

            TextEditUniversityName.DataBindings.Add("EditValue", BSUniversity, "Name", true);
            SpinEditYearsInService.DataBindings.Add("EditValue", BSUniversity, "YearsInService", true);
        }
        #region Buttons
        private void ButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void ButtonSave_Click(object sender, EventArgs e) {

        }
        #endregion
    }
}
