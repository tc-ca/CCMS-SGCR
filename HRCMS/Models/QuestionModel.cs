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
        public String QuestionNumber { get; set; }
        
        public String QuestionText { get; set; }
        public String AnswerText { get; set; }
        public string HRCaseId { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
    }
}
