using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class HRCase
    {
        public string hr_hrcaseid { get; set; }
        public string hr_name { get; set; }
        public string hr_lastname { get; set; }
        public string hr_firstname { get; set; }
        public string hr_pri { get; set; }
        public string hr_email { get; set; }
        public string _hr_casetype_value { get; set; }
        public CaseType hr_CaseType { get; set; }
        public string _hr_casesubtype_value { get; set; }
        public CaseSubType hr_CaseSubType { get; set; }
        public string hr_description { get; set; }
        public string hr_casestatus { get; set; }
        public DateTime createdon { get; set; }
        public DateTime? hr_datereceived { get; set; }
        public List<Question> hr_HRCase_hr_HRCase_hr_QuestionandAnswers { get; set; }
    }
}
