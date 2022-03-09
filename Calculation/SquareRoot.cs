namespace Calculation {
    internal class SquareRoot : Operation {
        public SquareRoot() { }

        public override string Execute(string operand1, string operand2) {
            double operand2Dec = Convert.ToDouble(operand2);
            double result = Math.Sqrt(operand2Dec);

            return result.ToString();
        }
    }
}