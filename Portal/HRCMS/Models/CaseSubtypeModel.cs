using System.ComponentModel.DataAnnotations;

namespace HRCMS.ViewModels
{
    public class CaseSubtypeModel
    {
        public string SubTypeName { get; set; }
        public string SubTypeNameEn { get; set; }
        public string SubTypeNameFr { get; set; }
        [Required]
        public string SubTypeId { get; set; }

    }
}