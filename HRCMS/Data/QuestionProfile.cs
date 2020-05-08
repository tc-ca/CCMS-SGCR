using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            this.CreateMap<Question, QuestionModel>()
              .ForMember(dest => dest.HRCaseId, act => act.MapFrom(src => src._hr_hrcase_value))
              .ForMember(dest => dest.QuestionId, act => act.MapFrom(src => src.hr_questionandanswersid))
              .ForMember(dest => dest.QuestionNumber, act=>act.MapFrom(src => src.hr_questionnumber))
              .ForMember(dest => dest.QuestionText, act => act.MapFrom(src => src.hr_question))
              .ForMember(dest => dest.AnswerText, act => act.MapFrom(src => src.hr_answer))
              .ForMember(dest => dest.DateCreated, act => act.MapFrom(src => src.createdon))
              .ReverseMap();           
        }
    }
}
