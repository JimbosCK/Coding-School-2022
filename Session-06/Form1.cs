namespace Session_06 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        // Button Number Handlers
        private void buttonNumberOne_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.One).ToString();

        }
        private void buttonNumberTwo_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Two).ToString();
        }

        private void buttonNumberThree_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Three).ToString();
        }

        private void buttonNumberFour_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Four).ToString();
        }

        private void buttonNumberFive_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Five).ToString();
        }

        private void buttonNumberSix_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Six).ToString();
        }

        private void buttonNumberSeven_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Seven).ToString();
        }

        private void buttonNumberEight_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Eight).ToString();

        }

        private void buttonNumberNine_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Nine).ToString();
        }

        private void buttonNumberZero_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((int)Numbers.Zero).ToString();
        }
        
        // Button Operations Handlers

        private void buttonOperationPlus_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)Operations.Plus).ToString();
        }

        private void buttonOperationMinus_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)Operations.Minus).ToString();
        }

        private void buttonOperationMultiplication_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)Operations.Multiplication).ToString();
        }

        private void buttonOperationDivision_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)Operations.Division).ToString();
        }

        private void buttonOperationPower_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)Operations.Power).ToString();
        }

        private void buttonOperationSquareRoot_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text += ((char)Operations.SquareRoot).ToString();
        }
        private void buttonOperationClear_Click(object sender, EventArgs e) {
            textBoxCalculatorScreen.Text = String.Empty;
        }
    }
}