using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    
    public class CaseStatus
    {
        public string Value { get; set; }
        public string Label { get; set; }
        public string LanguageCode { get; set; }
        
    }

    //public class CaseStatuses
    //{
    //    public static CaseStatus NewCase = new CaseStatus { Value = "315840001", Label = "New Case" }; 
    //    public static CaseStatus Assigned = new CaseStatus { Value = "315840000", Label = "Assigned" }; 
    //    public static CaseStatus InProgress = new CaseStatus { Value = "315840003", Label = "In-Progress" };
    //    public static CaseStatus WithdrawnByPay = new CaseStatus { Value = "315840005", Label = "Withdrawn by Pay" };
    //    public static CaseStatus Saved = new CaseStatus { Value = "315840002", Label = "Saved" }; //Editable
    //    public static CaseStatus Completed = new CaseStatus { Value = "315840004", Label = "Completed/closed" };
    //    public static CaseStatus WithdrawnByClient = new CaseStatus { Value = "315840006", Label = "Withdrawn - by client" };
    //}
}
