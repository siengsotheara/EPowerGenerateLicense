using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EPowerGenerateLicense.Class;
using System.Threading.Tasks;

namespace EPowerGenerateLicense.Model
{
    public class TBL_LICENSE_TYPE_DATA_ACCESS : IDisposable
    {
        private LicenseDataContext _context = null;
        void IDisposable.Dispose()
        {

        }
        public void SaveLicense(TBL_LICENSE_TYPE license)
        {
            using (_context = new LicenseDataContext())
            {
                _context.TBL_LICENSE_TYPEs.InsertOnSubmit(license);
                _context.SubmitChanges();
            };
        }
        public IQueryable<CLASS_TBL_LICENSE> ShowLicenseTypeSpecial()
        {
            _context = new LicenseDataContext();
            var all = (from l in _context.TBL_LICENSEs
                       join lt in _context.TBL_LICENSE_TYPEs on l.LICENSE_ID equals lt.LICENSE_ID
                           into groupLicense
                       from LicenseType in groupLicense.DefaultIfEmpty()
                       where LicenseType.LICENSE_ID == null
                       select new CLASS_TBL_LICENSE
                       {
                           LICENSE_ID = l.LICENSE_ID,
                           ACCOUNT_NO = l.ACCOUNT_NO,
                           ACCOUNT_NAME = l.ACCOUNT_NAME,
                           CONTACT_NAME = l.CONTACT_NAME,
                           PHONE = l.PHONE,
                           ADDRESS = l.ADDRESS
                       }).Take(24);
            return all;
        }
        public IQueryable<CLASS_TBL_LICENSE> ShowLicenseType()
        {
            _context = new LicenseDataContext();
            var all = (from l in _context.TBL_LICENSEs
                      join lt in _context.TBL_LICENSE_TYPEs on l.LICENSE_ID equals lt.LICENSE_ID
                      select new CLASS_TBL_LICENSE
                      {
                          LICENSE_ID = l.LICENSE_ID,
                          ACCOUNT_NO = l.ACCOUNT_NO,
                          ACCOUNT_NAME = l.ACCOUNT_NAME,
                          CONTACT_NAME = l.CONTACT_NAME,
                          PHONE = l.PHONE,
                          ADDRESS = l.ADDRESS,
                          COLOR_ID = lt.COLOR_ID
                         
                      }).Take(24);
            return all;
        }
        public IQueryable<CLASS_TBL_LICENSE> Search(string prompt)
        {
            _context = new LicenseDataContext();
            var all = (from l in _context.TBL_LICENSEs
                       join lt in _context.TBL_LICENSE_TYPEs on l.LICENSE_ID equals lt.LICENSE_ID
                       where l.ADDRESS.Contains(prompt) 
                       || l.CONTACT_NAME.Contains(prompt) 
                       || l.ACCOUNT_NO.Contains(prompt)
                       || l.ACCOUNT_NAME.Contains(prompt)
                       || l.PROVINCE_NAME.Contains(prompt)
                       || l.PHONE.Contains(prompt)
                       select new CLASS_TBL_LICENSE
                       {
                           ACCOUNT_NO = l.ACCOUNT_NO,
                           ACCOUNT_NAME = l.ACCOUNT_NAME,
                           CONTACT_NAME = l.CONTACT_NAME,
                           PHONE = l.PHONE,
                           ADDRESS = l.ADDRESS,
                           COLOR_ID = lt.COLOR_ID

                       }).Take(24);
            return all;
        }
    }
}
