using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public interface IQuestionRepository
    {
        //Task<List<Question>> GetAllQuestionsAsync(string caseId);
        //Task<Question> GetQuestionAsync(string questionId);
        Task<string> UpdateAnswerAsync(Question ques);
    }
}
