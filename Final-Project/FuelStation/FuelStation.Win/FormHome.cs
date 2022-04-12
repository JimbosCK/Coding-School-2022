using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class Home : XtraForm
    {
        private AppState _appState;
        private AccessHandler _accessHandler;
        public Home(AppState appState, AccessHandler accessHandler)
        {
            _appState = appState;
            _accessHandler = accessHandler;
            InitializeComponent();
        }
    }
}
