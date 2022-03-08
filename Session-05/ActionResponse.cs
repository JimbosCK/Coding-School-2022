using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class ActionResponse {
        public Guid ResponseID { get; }
        public Guid RequestID { get; set; }
        public string Output { get; set; }

        public ActionResponse() { ResponseID = Guid.NewGuid(); }


    }
}
