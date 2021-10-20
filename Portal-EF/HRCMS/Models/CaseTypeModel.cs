using System.ComponentModel.DataAnnotations;

namespace HRCMS.ViewModels
{
    public class CaseTypeModel
    {
        public string TypeName { get; set; }
        public string TypeNameEn { get; set; }
        public string TypeNameFr { get; set; }
        [Required]
        public string TypeId { get; set; }

    }
}