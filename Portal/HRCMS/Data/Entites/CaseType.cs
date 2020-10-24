using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class CaseType
    {
        public string hr_casetypeid { get; set; }
        public string hr_name { get; set; }
        public string hr_nameen { get; set; }
        public string hr_namefr { get; set; }

        public bool statuscode { get; set; }        
    }
}
