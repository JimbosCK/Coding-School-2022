using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation {
    public abstract class Operation {

        abstract public string Execute(string operand1, string operand2);
    }
}
