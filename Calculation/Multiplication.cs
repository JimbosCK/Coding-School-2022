using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation {
    internal class Multiplication : Operation {
        public Multiplication() { }

        public override string Execute(string operand1, string operand2) {
            decimal operand1Dec = Convert.ToDecimal(operand1);
            decimal operand2Dec = Convert.ToDecimal(operand2);
            decimal result = operand1Dec * operand2Dec;
            return result.ToString();
        }
    }
}