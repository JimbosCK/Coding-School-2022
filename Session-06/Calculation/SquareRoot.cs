namespace Calculation {
    internal class SquareRoot : Operation {
        public SquareRoot() { }

        public override string Execute(MathExpression expression) {
            try {
                double operand2Dec = Convert.ToDouble(expression.Variables[1]);
                double result = Math.Sqrt(operand2Dec);

                return result.ToString();
            }
            catch (Exception ex) {

                Console.WriteLine(ex);
            }

            return _errorInCalculationMessage;
        }
    }
}