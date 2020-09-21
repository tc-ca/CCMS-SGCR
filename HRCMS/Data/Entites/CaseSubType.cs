using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class CaseSubType
    {
        public string hr_casesubtypeid { get; set; }
        public string hr_name { get; set; }
        public string hr_nameen { get; set; }
        public string hr_namefr { get; set; }
        public int hr_sortorder{ get; set; }
        public bool statuscode { get; set; }       
    }
}
