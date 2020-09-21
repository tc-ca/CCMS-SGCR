using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS
{
    public class Dynamics
    {
        public string ResourceUrl { get; set; }
        public string ApiVersion { get; set; }
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string ClientSecret { get; set; }
        public string AuthContextUrl { get; set; }
    }

    public class HrApi
    {
        public string ResourceUrl { get; set; }
        public string appToken { get; set; }        
    }
}
