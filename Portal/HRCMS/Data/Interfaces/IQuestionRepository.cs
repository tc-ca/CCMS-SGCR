using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public interface IQuestionRepository
    {
        Task<List<QuestionModel>> GetAllUnAnsweredQuestionsAsync(string pri);
        //Task<Question> GetQuestionAsync(string questionId);
        Task<string> UpdateAnswerAsync(Question ques);
    }
}
