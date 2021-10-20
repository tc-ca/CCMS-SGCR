using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public interface IHRCaseRepository
    {
        // General 
        void Add<T>(T entity) where T : class;

        // HR Cases
        Task<List<HRCaseModel>> GetAllCasesAsync(string pri, string statuses, string twoLetterCultureLanguage);
        Task<HRCaseModel> GetCaseAsync(string caseId, string twoLetterCultureLanguage);
        Task<string> CreateHRCaseAsync(HRCase hrCase);
        Task<string> UpdateHRCaseAsync(HRCase hrCase);
        Task<bool> DeleteHRCaseAsync(string caseId);
    }
}
