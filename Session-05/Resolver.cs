using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal abstract class Resolver {

        abstract public void LogEvent(string description, DateTime timeStamp);
        abstract public void LogEvent(Guid requestID, string requestInput, string requestOutput, ActionEnum action,  DateTime timeStamp);
    }
}
