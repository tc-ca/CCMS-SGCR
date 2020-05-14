using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class Question
    {
        public string hr_questionandanswersid { get; set; }
        public string hr_questionnumber { get; set; }
        public string hr_question { get; set; }
        public string hr_answer { get; set; }
        public string _hr_hrcase_value { get; set; }
        public DateTime createdon { get; set; }
        public DateTime modifiedon { get; set; }
    }
}
