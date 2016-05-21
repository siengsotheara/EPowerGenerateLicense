using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPowerGenerateLicense.Class
{
    public class CLASS_TBL_MIX
    {
        public int SCHEDULE_ID { get; set; }
        public int LICENSE_ID { get; set; }
        public int SEASON_ID { get; set; }
        public string NOTE { get; set; }
        public string SEASON_NAME { get; set; }
        public int TOTAL_LICENSE { get; set; }
        public int REMAIN_LICENSE { get; set; }
        public int TAKEOVER { get; set; }
        public string SCHEDULE_NAME { get; set; }
        public string DATE_FOR { get; set; }
    }
}
