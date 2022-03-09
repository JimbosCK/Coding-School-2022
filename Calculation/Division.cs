using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation {
    internal class Division : Operation {
        public Division() { }

        public override string Execute(string operand1, string operand2) {
            try {
                decimal operand1Dec = Convert.ToDecimal(operand1);
                decimal operand2Dec = Convert.ToDecimal(operand2);
                if (operand2Dec == 0) {
                    return "Can not divide by zero.";
                }
                decimal result = operand1Dec / operand2Dec;
                return result.ToString();
            }
            catch (Exception ex) {

                Console.WriteLine(ex);
            }
            
            return _errorInCalculationMessage;
        }
        
    }
}