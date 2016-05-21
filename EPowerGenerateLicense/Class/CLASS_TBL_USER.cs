using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPowerGenerateLicense.Class
{
    public class CLASS_TBL_USER
    {
        public int USER_ID{get;set;}
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
