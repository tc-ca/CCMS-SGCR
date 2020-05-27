using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public interface IAnnotationRepository
    {
        Task<AnnotationModel> GetAnnotationAsync(string annotationId);
        Task<string> UploadAttatchmentAsync(Annotation ques);
    }
}
