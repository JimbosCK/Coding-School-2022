﻿namespace Calculation {
    internal class Subtraction : Operation {
        public Subtraction() { }

        public override string Execute(string operand1, string operand2) {
            try {
                decimal operand1Dec = Convert.ToDecimal(operand1);
                decimal operand2Dec = Convert.ToDecimal(operand2);
                decimal result = operand1Dec - operand2Dec;
                return result.ToString();
            }
            catch (Exception ex) {

                Console.WriteLine(ex);
            }

            return _errorInCalculationMessage;
        }
    }
}