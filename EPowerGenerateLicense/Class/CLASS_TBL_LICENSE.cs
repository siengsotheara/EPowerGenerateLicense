using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPowerGenerateLicense.Class
{
    public class CLASS_TBL_LICENSE
    {
        public int LICENSE_ID { get; set; }
        public string ACCOUNT_NO { get; set; }
        public string ACCOUNT_NAME { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string CONTACT_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string PROVINCE_NAME { get; set; }
        public string DISTRICT_NAME { get; set; }
        public string COMMUNE_NAME { get; set; }
        public string VILLAGE_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public int COLOR_ID { get; set; }
    }
}
