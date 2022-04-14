
namespace FuelStation.Win
{
    public partial class FormTransactionEdit : XtraFormWithServerConnection
    {
        private Guid _customerID;

        public FormFindCustomerPrompt RefFindCustomerPrompt { get; set; }

        public FormTransactionEdit(Guid customerID)
        {
            _customerID = customerID;
            InitializeComponent();
        }
    }
}
