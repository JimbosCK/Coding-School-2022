namespace Calculation {
    internal class Power : Operation {

        public Power() { }
        public override string Execute(string operand1, string operand2) {
            try {
                double operand1Dec = Convert.ToDouble(operand1);
                double operand2Dec = Convert.ToDouble(operand2);
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