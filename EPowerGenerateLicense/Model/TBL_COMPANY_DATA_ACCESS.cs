using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPowerGenerateLicense.Class;

namespace EPowerGenerateLicense.Model
{
    public class TBL_COMPANY_DATA_ACCESS : IDisposable
    {
        private LicenseDataContext _context = new LicenseDataContext();
        public void Dispose()
        {

        }
        public IQueryable<CLASS_TBL_COMPANY> ShowCompany()
        {
            _context = new LicenseDataContext();
            var resutl = from c in _context.TBL_COMPANies
                         where c.COMPANY_ID == 1
                         select new CLASS_TBL_COMPANY
                         {
                             COMPANY_ADDRESS = c.ADDRESS,
                             COMPANY_NAME = c.COMPANY_NAME
                         };
            return resutl;
        }
    }
}
