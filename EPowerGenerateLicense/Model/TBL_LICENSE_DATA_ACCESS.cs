using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPowerGenerateLicense.Class;

namespace EPowerGenerateLicense.Model
{
    public class TBL_LICENSE_DATA_ACCESS : IDisposable
    {
        private LicenseDataContext _context = null;


        void IDisposable.Dispose()
        {

        }
        public IQueryable<TBL_LICENSE> CheckLicenseNumber(string LICENSE_NUMBER)
        {
            _context = new LicenseDataContext();
            var result = from l in _context.TBL_LICENSEs where l.ACCOUNT_NO == LICENSE_NUMBER select l;
            return result;

        }
        /// <summary>
        /// Return Filter of TBL_LICENSE of Class TBL_LICENSE
        /// </summary>
        /// <returns></returns>
        public List<CLASS_TBL_LICENSE> ShowLicense()
        {
            _context = new LicenseDataContext();

            var all = _context.TBL_LICENSEs.GroupJoin(_context.TBL_LICENSE_TYPEs, l => l.LICENSE_ID, t => (int?)t.LICENSE_ID,
                                      (license, type) => new { license.LICENSE_ID, license.ACCOUNT_NAME, license.ACCOUNT_NO, license.PHONE, license.CONTACT_NAME, license.EMAIL, license.ADDRESS, license.PROVINCE_NAME, license.DISTRICT_NAME,license.COMMUNE_NAME,license.VILLAGE_NAME, license.IS_ACTIVE, COLOR_ID=(int?)type.SingleOrDefault().COLOR_ID })
                                      .Select(x => new { x.LICENSE_ID, x.ACCOUNT_NAME, x.ACCOUNT_NO, x.PHONE, x.CONTACT_NAME, x.EMAIL, x.ADDRESS, x.PROVINCE_NAME, x.DISTRICT_NAME, x.COMMUNE_NAME, x.VILLAGE_NAME, x.IS_ACTIVE, x.COLOR_ID })
                                      .Where(i => i.IS_ACTIVE == true)
                                      .Take(24)
                                      .Select(g => new CLASS_TBL_LICENSE
                                        {
                                            LICENSE_ID = g.LICENSE_ID,
                                            ACCOUNT_NO = g.ACCOUNT_NO,
                                            ACCOUNT_NAME = g.ACCOUNT_NAME,
                                            CONTACT_NAME = g.CONTACT_NAME,
                                            PHONE = g.PHONE,
                                            EMAIL = g.EMAIL,
                                            ADDRESS = g.ADDRESS,
                                            PROVINCE_NAME = g.PROVINCE_NAME,
                                            DISTRICT_NAME = g.DISTRICT_NAME,
                                            COMMUNE_NAME = g.COMMUNE_NAME,
                                            VILLAGE_NAME = g.VILLAGE_NAME,
                                            COLOR_ID = g.COLOR_ID.GetValueOrDefault()
                                        }).ToList();
            return all;
        }
        /// <summary>
        /// prompt is paramter to Search from TBL_LICENSE
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public List<CLASS_TBL_LICENSE> Search(string prompt)
        {
            _context = new LicenseDataContext();
            var all = _context.TBL_LICENSEs.GroupJoin(_context.TBL_LICENSE_TYPEs, l => l.LICENSE_ID, t => (int?)t.LICENSE_ID,
                (license, type) => new {license.LICENSE_ID, license.ACCOUNT_NAME, license.ACCOUNT_NO, license.PHONE, license.CONTACT_NAME, license.EMAIL, license.ADDRESS, license.IS_ACTIVE,license.PROVINCE_NAME, license.DISTRICT_NAME,license.COMMUNE_NAME,license.VILLAGE_NAME, COLOR_ID = (int?)type.SingleOrDefault().COLOR_ID })
                .Select(x => new {x.LICENSE_ID, x.ACCOUNT_NAME, x.ACCOUNT_NO, x.CONTACT_NAME, x.PHONE, x.EMAIL, x.PROVINCE_NAME, x.DISTRICT_NAME, x.COMMUNE_NAME, x.VILLAGE_NAME, x.ADDRESS, x.IS_ACTIVE, x.COLOR_ID })
                .Where(s => s.IS_ACTIVE == true)
                .Where
                (
                    s => s.ACCOUNT_NO.Contains(prompt)
                    || s.ACCOUNT_NAME.Contains(prompt)
                    || s.PHONE.Contains(prompt)
                    || s.CONTACT_NAME.Contains(prompt)
                    || s.PHONE.Contains(prompt)
                    || s.ADDRESS.Contains(prompt)
                    || s.PROVINCE_NAME.Contains(prompt)
                )
                .Select(n => new CLASS_TBL_LICENSE
                {
                    LICENSE_ID = n.LICENSE_ID,
                    ACCOUNT_NO = n.ACCOUNT_NO,
                    ACCOUNT_NAME = n.ACCOUNT_NAME,
                    CONTACT_NAME = n.CONTACT_NAME,
                    PHONE = n.PHONE,
                    EMAIL = n.EMAIL,
                    ADDRESS = n.ADDRESS,
                    PROVINCE_NAME = n.PROVINCE_NAME,
                    DISTRICT_NAME = n.DISTRICT_NAME,
                    COMMUNE_NAME = n.COMMUNE_NAME,
                    VILLAGE_NAME = n.VILLAGE_NAME,
                    COLOR_ID = n.COLOR_ID.GetValueOrDefault()
                }).ToList();
            return all;
        }
        public IQueryable<TBL_LICENSE> ShowLicenseByID(int LICENSE_ID)
        {
            _context = new LicenseDataContext();
            
                var result = from l in _context.TBL_LICENSEs where l.LICENSE_ID == LICENSE_ID select l;
                return result;
            
            
        }
        public void SaveLicense(TBL_LICENSE license)
        {
            using (_context = new LicenseDataContext())
            {
                _context.TBL_LICENSEs.InsertOnSubmit(license);
                _context.SubmitChanges();
            };
        }

        /// <summary>
        /// Update License No.
        /// </summary>
        /// <param name="license"></param>
        public void UpdateLicense(TBL_LICENSE license)
        {
            using (_context = new LicenseDataContext())
            {

                _context.SubmitChanges();
            }
        }

        /// <summary>
        /// Delete License NO.
        /// </summary>
        /// <param name="license"></param>
        public void DeleteLicense(TBL_LICENSE license)
        {
            using (_context = new LicenseDataContext())
            {
                _context.TBL_LICENSEs.DeleteOnSubmit(license);
                _context.SubmitChanges();
            }
        }
        public IQueryable<CLASS_TBL_LICENSE_AVAILABLE> DisplayAvailableLicenseBySeasonID(int SEASON_ID)
        {
            _context = new LicenseDataContext();
            var all = from l in _context.TBL_LICENSEs
                      join s in _context.TBL_SCHEDULEs on l.LICENSE_ID equals s.LICENSE_ID
                      join lg in _context.TBL_LICENSE_GENERATEs on s.SCHEDULE_ID equals lg.SCHEDULE_ID into groupSchedule
                      from Schedule in groupSchedule.DefaultIfEmpty()
                      join se in _context.TBL_SEASONs on s.SEASON_ID equals se.SEASON_ID into groupSeason
                      from Season in groupSeason.DefaultIfEmpty()
                      join lt in _context.TBL_LICENSE_TYPEs on l.LICENSE_ID equals (int?)lt.LICENSE_ID into groupType
                      from type in groupType.DefaultIfEmpty()
                      where s.SEASON_ID == SEASON_ID && Schedule.SCHEDULE_ID == null
                      select new CLASS_TBL_LICENSE_AVAILABLE
                      {
                          LICENSE_NUMBER = l.ACCOUNT_NO,
                          ACCOUNT_NAME = l.ACCOUNT_NAME,
                          PHONE = l.PHONE,
                          COLOR_ID = Convert.ToInt32(type.COLOR_ID)
                      };
            return all;
        }
        
    }
}
