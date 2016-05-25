using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPowerGenerateLicense.Class
{
    public class CLASS_TBL_LICENSE_TYPE
    {
        public int LICENSE_ID{get;set;}
        public int LICENSE_TYPE_ID { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string ACCOUNT_NAME { get; set; }
        public string PHONE { get; set; }
        public string CONTACT_NAME { get; set; }
        public string ADDRESS { get; set; }
        public Nullable<int> COLOR_ID { get; set; }
    }
}
