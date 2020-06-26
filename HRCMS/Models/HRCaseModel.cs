using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace HRCMS.ViewModels
{
    public class HRCaseModel
    {
        public HRCaseModel()
        {
            //CaseType = new CaseTypeModel();
            //CaseSubType = new CaseSubtypeModel();
            //Questions = new List<QuestionModel>();
            //Attachments = new List<AnnotationModel>();
        }
        public string CaseId { get; set; }
        public String CaseNumber { get; set; }
        [Required]
        [StringLength(11)]
        public String PRI { get; set; }
        [Required]
        [StringLength(100)]
        public String LastName { get; set; }
        [Required]
        [StringLength(100)]
        public String FirstName { get; set; }
        [Required]
        [StringLength(250)]
        public String Email { get; set; }

        public string CaseStatusId { get; set; }
        public string CaseStatusText { get; set; }
        public CaseTypeModel CaseType { get; set; }
        public CaseSubtypeModel CaseSubType { get; set; }
        [StringLength(4000)]
        public String Description { get; set; }
        public String Resolution { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime DateCreated { get; set; }
        public List<QuestionModel> Questions { get; set; }

        public IEnumerable<SelectListItem> CaseStatuses { get; set; }
        public IEnumerable<SelectListItem> CaseTypes { get; set; }
        public IEnumerable<SelectListItem> CaseSubTypes { get; set; }

        public List<AnnotationModel> Attachments { get; set; }

        public AnnotationModel NewAttachment { get; set; }
    }
}
