﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class ActionRequest {
        public ActionRequest() { RequestID = Guid.NewGuid(); }

        public Guid RequestID { get; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }
    }
}
