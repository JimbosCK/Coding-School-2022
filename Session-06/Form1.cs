namespace Session_06 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        // Button Symbol Handlers
        private void buttonSymbolComma_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)SymbolsEnum.Comma).ToString();
        }

        // Button Number Handlers
        private void buttonNumberOne_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.One).ToString();

        }
        private void buttonNumberTwo_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Two).ToString();
        }

        private void buttonNumberThree_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Three).ToString();
        }

        private void buttonNumberFour_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Four).ToString();
        }

        private void buttonNumberFive_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Five).ToString();
        }

        private void buttonNumberSix_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Six).ToString();
        }

        private void buttonNumberSeven_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Seven).ToString();
        }

        private void buttonNumberEight_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Eight).ToString();

        }

        private void buttonNumberNine_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Nine).ToString();
        }

        private void buttonNumberZero_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)NumbersEnum.Zero).ToString();
        }
        
        // Button Operations Handlers

        private void buttonOperationPlus_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)OperationsEnum.Plus).ToString();
        }

        private void buttonOperationMinus_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)OperationsEnum.Minus).ToString();
        }

        private void buttonOperationMultiplication_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)OperationsEnum.Multiplication).ToString();
        }

        private void buttonOperationDivision_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)OperationsEnum.Division).ToString();
        }

        private void buttonOperationPower_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)OperationsEnum.Power).ToString();
        }

        private void buttonOperationSquareRoot_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)OperationsEnum.SquareRoot).ToString();
        }
        private void buttonOperationClear_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text = String.Empty;
        }

        private void buttonOperationEquals_Click(object sender, EventArgs e) {
            var calc = new Calculation.Addition();
            textBoxCalculatorScreen.Text += calc.Execute("2,5", "4");
        }


    }
}