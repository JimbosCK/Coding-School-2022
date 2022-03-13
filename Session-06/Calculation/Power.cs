namespace Calculation {
    internal class Power : Operation {

        public Power() { }
        public override string Execute(MathExpression expression) {
            try {
                double operand1Dec = Convert.ToDouble(expression.Variables[0]);
                double operand2Dec = Convert.ToDouble(expression.Variables[1]);
                double result = Math.Pow(operand1Dec, operand2Dec);
                return result.ToString();
            }
            catch (Exception ex) {

                Console.WriteLine(ex);
            }

            return _errorInCalculationMessage;
        }
    }
}