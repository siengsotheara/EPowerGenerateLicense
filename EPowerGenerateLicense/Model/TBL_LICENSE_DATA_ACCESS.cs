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
            var result = from l in _context.TBL_LICENSEs where l.LICENSE_NUMBER == LICENSE_NUMBER select l;
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
                                      (license, type) => new { license.LICENSE_ID,license.LICENSE_NUMBER, license.FIRST_NAME, license.LAST_NAME, license.PHONE, license.CONTACT_NAME, license.ADDRESS, license.IS_ACTIVE, COLOR_ID = (int?)type.SingleOrDefault().COLOR_ID })
                                      .Select(x => new {x.LICENSE_ID, x.LICENSE_NUMBER, x.FIRST_NAME, x.LAST_NAME, x.PHONE, x.CONTACT_NAME, x.ADDRESS, x.IS_ACTIVE, x.COLOR_ID })
                                      .Where(i => i.IS_ACTIVE == true)
                                      .Take(24)
                                      .Select(g => new CLASS_TBL_LICENSE
                                        {
                                            LICENSE_ID = g.LICENSE_ID,
                                            LICENSE_NUMBER = g.LICENSE_NUMBER,
                                            FULLNAME = g.FIRST_NAME + " " + g.LAST_NAME,
                                            CONTACT_NAME = g.CONTACT_NAME,
                                            PHONE = g.PHONE,
                                            ADDRESS = g.ADDRESS,
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
                (license, type) => new {license.LICENSE_ID, license.LICENSE_NUMBER, license.FIRST_NAME, license.LAST_NAME, license.PHONE, license.CONTACT_NAME, license.ADDRESS, license.IS_ACTIVE, COLOR_ID = (int?)type.SingleOrDefault().COLOR_ID })
                .Select(x => new {x.LICENSE_ID, x.LICENSE_NUMBER, x.FIRST_NAME, x.LAST_NAME, x.PHONE, x.CONTACT_NAME, x.ADDRESS, x.IS_ACTIVE, FULLNAME=x.FIRST_NAME+" "+x.LAST_NAME, x.COLOR_ID })
                .Where(s => s.IS_ACTIVE == true)
                .Where
                (
                    s => s.LICENSE_NUMBER.Contains(prompt)
                    || s.FIRST_NAME.Contains(prompt)
                    || s.LAST_NAME.Contains(prompt)
                    || s.CONTACT_NAME.Contains(prompt)
                    || s.PHONE.Contains(prompt)
                    || s.ADDRESS.Contains(prompt)
                    || s.FULLNAME.Contains(prompt)
                )
                .Select(n => new CLASS_TBL_LICENSE
                {
                    LICENSE_ID = n.LICENSE_ID,
                    LICENSE_NUMBER = n.LICENSE_NUMBER,
                    FULLNAME = n.FIRST_NAME + " " + n.LAST_NAME,
                    CONTACT_NAME = n.CONTACT_NAME,
                    PHONE = n.PHONE,
                    ADDRESS = n.ADDRESS,
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
                          LICENSE_NUMBER = l.LICENSE_NUMBER,
                          ACCOUNT_NAME = l.FIRST_NAME + " " + l.LAST_NAME,
                          PHONE = l.PHONE,
                          COLOR_ID = Convert.ToInt32(type.COLOR_ID)
                      };
            return all;
        }
        
    }
}
