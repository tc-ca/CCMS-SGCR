using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class Annotation
    {
        public string annotationid { get; set; }
        public bool isdocument { get; set; }
        public string filename { get; set; }
        public string subject { get; set; }
        public string mimetype { get; set; }
        public string documentbody { get; set; }
        //HR Case Id
        public string _objectid_value { get; set; }
        public string notetext { get; set; }
        public string createdon { get; set; }
        public DateTime modifiedon { get; set; }
    }
}
