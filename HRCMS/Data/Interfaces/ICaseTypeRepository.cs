using HRCMS.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public interface ICaseTypeRepository
    {        
        Task<IEnumerable<SelectListItem>> GetAllCaseTypesAsync(string twoLetterCultureLanguage);
        Task<IEnumerable<SelectListItem>> GetAllCaseSubTypesAsync(string twoLetterCultureLanguage);
        Task<IEnumerable<SelectListItem>> GetCaseSubTypesAsync(string caseTypeId, string twoLetterCultureLanguage);
        Task<IEnumerable<SelectListItem>> GetAllCaseStatusesAsync();

    }
}
