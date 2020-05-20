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
              .ForMember(dest => dest.CaseTypeId, act => act.MapFrom(src => src._hr_casetype_value))
              .ForMember(dest => dest.CaseSubTypeId, act => act.MapFrom(src => src._hr_casesubtype_value))
              .ForMember(dest => dest.CaseStatusId, act => act.MapFrom(src => src.hr_casestatus))
              .ForMember(dest => dest.DateCreated, act => act.MapFrom(src => src.createdon))
              .ForMember(dest => dest.DateReceived, act => act.MapFrom(src => src.hr_datereceived))
              .ForMember(dest => dest.Description, act => act.MapFrom(src => src.hr_description))
              .ReverseMap();

            //this.CreateMap<RatingType, RatingTypeModel>()
            //  .ReverseMap();

            //this.CreateMap<Service, ServiceModel>()
            //  .ReverseMap();
        }
    }
}
