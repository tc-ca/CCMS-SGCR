using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public class CaseProfile : Profile
    {
        public CaseProfile()
        {
            this.CreateMap<HRCase, HRCaseModel>()
              .ForMember(dest => dest.CaseId, act => act.MapFrom(src => src.hr_hrcaseid))
              .ForMember(dest =>dest.CaseNumber, act=>act.MapFrom(src=>src.hr_name))
              .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.hr_firstname))
              .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.hr_lastname))
              .ForMember(dest => dest.Email, act => act.MapFrom(src => src.hr_email))
              .ForMember(dest => dest.PRI, act => act.MapFrom(src => src.hr_pri))
              .ForMember(dest => dest.CaseType, act => act.MapFrom(src => src.hr_CaseType))
              .ForMember(dest => dest.CaseSubType, act => act.MapFrom(src => src.hr_CaseSubType))
              .ForMember(dest => dest.CaseStatusId, act => act.MapFrom(src => src.hr_casestatus))
              .ForMember(dest => dest.DateCreated, act => act.MapFrom(src => src.createdon))
              .ForMember(dest => dest.DateReceived, act => act.MapFrom(src => src.hr_datereceived))
              .ForMember(dest => dest.Description, act => act.MapFrom(src => src.hr_description))
              .ForMember(dest => dest.Questions, act => act.MapFrom(src => src.hr_HRCase_hr_HRCase_hr_QuestionandAnswers))
              .ForMember(dest => dest.Attachments, act => act.MapFrom(src => src.hr_hrcase_Annotations))
              .ReverseMap();

            this.CreateMap<CaseType, CaseTypeModel>()
              .ForMember(dest => dest.TypeId, act => act.MapFrom(src => src.hr_casetypeid))
              .ForMember(dest => dest.TypeName, act => act.MapFrom(src => src.hr_name))
              .ReverseMap();

            this.CreateMap<CaseSubType, CaseSubtypeModel>()
              .ForMember(dest => dest.SubTypeId, act => act.MapFrom(src => src.hr_casesubtypeid))
              .ForMember(dest => dest.SubTypeName, act => act.MapFrom(src => src.hr_name))
              .ReverseMap();
        }

       
    }
}
