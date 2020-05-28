using System.ComponentModel.DataAnnotations;

namespace HRCMS.ViewModels
{
    public class CaseSubtypeModel
    {
        public string SubTypeName { get; set; }
        [Required]
        public string SubTypeId { get; set; }

    }
}