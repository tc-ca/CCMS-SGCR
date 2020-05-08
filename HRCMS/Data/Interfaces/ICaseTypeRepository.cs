using HRCMS.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public interface ICaseTypeRepository
    {        
        Task<IEnumerable<SelectListItem>> GetAllCaseTypesAsync();
        Task<IEnumerable<SelectListItem>> GetAllCaseSubTypesAsync();
        Task<IEnumerable<SelectListItem>> GetCaseSubTypesAsync(string caseTypeId);
        Task<IEnumerable<SelectListItem>> GetAllCaseStatusesAsync();

    }
}
