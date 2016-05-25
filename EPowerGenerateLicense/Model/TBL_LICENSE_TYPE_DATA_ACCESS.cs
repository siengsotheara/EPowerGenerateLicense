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
        public List<RUN_SHOW_NOT_SPECIAL_LICENSEResult> ShowLicenseTypeSpecial()
        {
            _context = new LicenseDataContext();
            var all = _context.RUN_SHOW_NOT_SPECIAL_LICENSE();
            return all.ToList();
        }
       
        //public IQueryable<CLASS_TBL_LICENSE_TYPE> ShowLicenseTypeSpecial()
        //{
        //    _context = new LicenseDataContext();
        //    var all = (from l in _context.TBL_LICENSEs
        //               join lt in _context.TBL_LICENSE_TYPEs on l.LICENSE_ID equals (int?)lt.LICENSE_ID
        //                   into groupLicense
        //               from LicenseType in groupLicense.DefaultIfEmpty()
        //               where LicenseType.LICENSE_ID == null// && LicenseType.IS_ACTIVE==true
        //               select new CLASS_TBL_LICENSE_TYPE
        //               {
        //                   LICENSE_TYPE_ID = LicenseType.LICENSE_TYPE_ID,
        //                   LICENSE_ID = l.LICENSE_ID,
        //                   ACCOUNT_NO = l.ACCOUNT_NO,
        //                   ACCOUNT_NAME = l.ACCOUNT_NAME,
        //                   PHONE = l.PHONE,
        //                   CONTACT_NAME = l.CONTACT_NAME,
        //                   ADDRESS = l.ADDRESS,
        //                   COLOR_ID = LicenseType.COLOR_ID
        //               }).Take(24);
        //    return all;
        //}
        public IQueryable<CLASS_TBL_LICENSE_TYPE> ShowLicenseType()
        {
            _context = new LicenseDataContext();
            var all = (from l in _context.TBL_LICENSEs
                       join lt in _context.TBL_LICENSE_TYPEs on l.LICENSE_ID equals lt.LICENSE_ID
                       where lt.IS_ACTIVE == true
                       select new CLASS_TBL_LICENSE_TYPE
                      {
                          LICENSE_TYPE_ID = lt.LICENSE_TYPE_ID,
                          LICENSE_ID = l.LICENSE_ID,
                          ACCOUNT_NO = l.ACCOUNT_NO,
                          ACCOUNT_NAME = l.ACCOUNT_NAME,
                          PHONE = l.PHONE,
                          CONTACT_NAME = l.CONTACT_NAME,
                          ADDRESS = l.ADDRESS,
                          COLOR_ID = lt.COLOR_ID

                      }).Take(24);
            return all;
        }
        public IQueryable<CLASS_TBL_LICENSE_TYPE> Search(string prompt)
        {
            _context = new LicenseDataContext();
            var all = (from l in _context.TBL_LICENSEs
                       join lt in _context.TBL_LICENSE_TYPEs on l.LICENSE_ID equals lt.LICENSE_ID
                       where l.IS_ACTIVE == true && ((l.ADDRESS.Contains(prompt) 
                       || l.CONTACT_NAME.Contains(prompt) 
                       || l.ACCOUNT_NO.Contains(prompt)
                       || l.ACCOUNT_NAME.Contains(prompt)
                       || l.PROVINCE_NAME.Contains(prompt)
                       || l.PHONE.Contains(prompt)))
                       select new CLASS_TBL_LICENSE_TYPE
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
