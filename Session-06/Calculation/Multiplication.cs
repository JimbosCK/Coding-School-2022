using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation {
    internal class Multiplication : Operation {
        public Multiplication() { }

        public override string Execute(MathExpression expression) {
            try {
                decimal operand1Dec = Convert.ToDecimal(expression.Variables[0]);
                decimal operand2Dec = Convert.ToDecimal(expression.Variables[1]);
                decimal result = operand1Dec * operand2Dec;
                return result.ToString();
            }
            catch (Exception ex) {

                Console.WriteLine(ex);
            }
            return _errorInCalculationMessage;

        }
    }
}