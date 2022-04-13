using DevExpress.XtraEditors;
using FuelStation.Blazor.Shared.Services;
using FuelStation.EF.Repositories;
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
    public partial class FormItemList : XtraForm
    {
        private AppState _appState;
        private AccessHandler _accessHandler;
        public FormItemList()
        {
            InitializeComponent();
        }
    }
}
