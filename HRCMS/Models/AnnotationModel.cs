using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using HRCMS.Data;
using Microsoft.AspNetCore.Http;

namespace HRCMS.ViewModels
{
    public class AnnotationModel
    {
        public string Annotationid { get; set; }
        [Required]
        public String Subject { get; set; }
        public String NoteText { get; set; }
        public String FileName { get; set; }
        public string Mimetype { get; set; }
        public String CaseId { get; set; }
        public bool IsDocument { get; set; }
        public String DocumentBody { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        [Required]
        public IFormFile File { get; set; }
    }
}
