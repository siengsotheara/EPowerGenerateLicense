using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPowerGenerateLicense;
using EPowerGenerateLicense.Class;

namespace EPowerGenerateLicense.Model
{
    
    public class TBL_LICENSE_GENERATE_DATA_ACCESS : IDisposable
    {
        private LicenseDataContext _context = null;

        void IDisposable.Dispose()
        {

        }

        public void SaveLicenseGenerate(TBL_LICENSE_GENERATE lg)
        {
            using (_context = new LicenseDataContext())
            {
                _context.TBL_LICENSE_GENERATEs.InsertOnSubmit(lg);
                _context.SubmitChanges();
            };
        }
        public IQueryable<CLASS_TBL_LICENSE_GENERATE> RunningAvailableLicenseBySeasonID(int SEASON_ID)
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
                      select new CLASS_TBL_LICENSE_GENERATE
                      {
                          SCHEDULE_ID = s.SCHEDULE_ID
                      };
            return all;
        }
    }
}
