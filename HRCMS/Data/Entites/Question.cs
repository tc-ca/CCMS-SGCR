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
        public HRCase hr_HRCase { get; set; }
        public DateTime createdon { get; set; }
        public DateTime modifiedon { get; set; }
        //Date set in string format for convert to local time.
        public string hr_answeredon { get; set; }
        //Date set in string format for convert to local time.
        public string hr_askedon { get; set; }

    }
}
