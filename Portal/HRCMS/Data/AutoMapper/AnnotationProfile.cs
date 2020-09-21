using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public class AnnotationProfile : Profile
    {
        public AnnotationProfile()
        {
            this.CreateMap<Annotation, AnnotationModel>()              
              .ForMember(dest => dest.Annotationid, act => act.MapFrom(src => src.annotationid))
              .ForMember(dest => dest.IsDocument, act => act.MapFrom(src => src.isdocument))
              .ForMember(dest => dest.Subject, act => act.MapFrom(src => src.subject))
              .ForMember(dest => dest.Mimetype, act => act.MapFrom(src => src.mimetype))
              .ForMember(dest => dest.FileName, act => act.MapFrom(src => src.filename))
              .ForMember(dest => dest.DocumentBody, act => act.MapFrom(src => src.documentbody))
              .ForMember(dest => dest.NoteText, act => act.MapFrom(src => src.notetext))
              .ForMember(dest => dest.CaseId, act => act.MapFrom(src => src._objectid_value))
              .ForMember(dest => dest.DateCreated, act => act.MapFrom(src => src.createdon))
              .ForMember(dest => dest.DateModified, act => act.MapFrom(src => src.modifiedon))
              .ReverseMap();           
        }
    }
}
