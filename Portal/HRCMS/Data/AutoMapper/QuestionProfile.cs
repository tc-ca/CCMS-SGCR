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
              .ForMember(dest => dest.QuestionId, act => act.MapFrom(src => src.hr_questionandanswersid))
              .ForMember(dest => dest.QuestionSequenceNumber, act => act.MapFrom(src => src.hr_questionsequencenumber))
              .ForMember(dest => dest.HRCase, act => act.MapFrom(src => src.hr_HRCase))
              .ForMember(dest => dest.QuestionText, act => act.MapFrom(src => src.hr_question))
              .ForMember(dest => dest.AnswerText, act => act.MapFrom(src => src.hr_answer))
              .ForMember(dest => dest.DateCreated, act => act.MapFrom(src => src.createdon))
              .ForMember(dest => dest.DateModified, act => act.MapFrom(src => src.modifiedon))
              .ForMember(dest => dest.DateAsked, act => act.MapFrom(src => src.hr_askedon))
              .ForMember(dest => dest.DateAnswered, act => act.MapFrom(src => src.hr_answeredon))
              .ReverseMap();           
        }
    }
}
