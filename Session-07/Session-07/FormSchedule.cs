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
    public partial class FormSchedule : XtraForm {
        private string _formName = "Schedule";

        public List<Uni.Schedule> Schedules { get; set; }
        public FormSchedule() {
            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e) {
            this.Text = _formName;
            TextEditScheduleDate.Text = Schedules[0].Callendar.ToString();
        }
    }
}
