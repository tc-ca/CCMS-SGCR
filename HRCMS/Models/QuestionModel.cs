using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using HRCMS.Data;
namespace HRCMS.ViewModels
{
    public class QuestionModel
    {
        public string QuestionId { get; set; }
        
        public String QuestionText { get; set; }
        public String AnswerText { get; set; }
        public HRCaseModel HRCase { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        //Date set in string format for convert to local time.
        public string DateAsked { get; set; }
        //Date set in string format for convert to local time.
        public string DateAnswered { get; set; }
    }
}
