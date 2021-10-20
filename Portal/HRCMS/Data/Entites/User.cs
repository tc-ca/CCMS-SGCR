using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRCMS.Data
{
    public class User
    {
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string pri { get; set; }
        public string email { get; set; }
        public string regionCode { get; set; }
        public string regionEng { get; set; }
        public string regionFra { get; set; }
    }
}
