using System.ComponentModel.DataAnnotations;

namespace HRCMS.ViewModels
{
    public class CaseTypeModel
    {
        public string TypeName { get; set; }
        [Required]
        public string TypeId { get; set; }

    }
}