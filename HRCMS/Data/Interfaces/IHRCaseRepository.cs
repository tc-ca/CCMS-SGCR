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
        Task<List<HRCase>> GetAllCasesAsync(string pri);
        Task<HRCase> GetCaseAsync(string caseId);
        Task<string> CreateHRCaseAsync(HRCase hrCase);
        Task<string> UpdateHRCaseAsync(HRCase hrCase);
        Task<bool> DeleteHRCaseAsync(string caseId);
    }
}
