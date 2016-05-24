using EPowerGenerateLicense.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPowerGenerateLicense.Model
{

    public class TBL_SCHEDULE_DATA_ACCESS : IDisposable
    {
        private LicenseDataContext _context = null;
        void IDisposable.Dispose()
        {

        }
        /// <summary>
        /// AvaibleLicense To Generate  Filter By SeasonID
        /// SELECT *
        /// FROM TBL_SCHEDULE s 
        /// INNER JOIN TBL_LICENSE l ON s.LICENSE_ID = l.LICENSE_ID
        /// LEFT JOIN TBL_LICENSE_GENERATE lg ON s.SCHEDULE_ID = lg.SCHEDULE_ID
        /// LEFT JOIN TBL_SEASON se ON s.SEASON_ID = se.SEASON_ID
        /// WHERE s.SEASON_ID = 1 AND lg.SCHEDULE_ID IS NULL
        /// </summary>
        /// <param name="SEASON_ID"></param>
        /// <returns></returns>
        public IQueryable<CLASS_TBL_MIX> AvaibleLicenseToGenerateBySeasonID(int SEASON_ID)
        {
            // SELECT *
            // FROM TBL_SCHEDULE s 
            // INNER JOIN TBL_LICENSE l ON s.LICENSE_ID = l.LICENSE_ID
            // LEFT JOIN TBL_LICENSE_GENERATE lg ON s.SCHEDULE_ID = lg.SCHEDULE_ID
            // LEFT JOIN TBL_SEASON se ON s.SEASON_ID = se.SEASON_ID
            // WHERE s.SEASON_ID = 1 AND lg.SCHEDULE_ID IS NULL
            string current_date = DateTime.Now.ToString("dd - MM - yyy");
            _context = new LicenseDataContext();
            var all = from l in _context.TBL_LICENSEs
                      join s in _context.TBL_SCHEDULEs on l.LICENSE_ID equals s.LICENSE_ID
                      join lg in _context.TBL_LICENSE_GENERATEs on s.SCHEDULE_ID equals lg.SCHEDULE_ID into groupSchedule
                      from Schedule in groupSchedule.DefaultIfEmpty()
                      join se in _context.TBL_SEASONs on s.SEASON_ID equals se.SEASON_ID into groupSeason
                      from Season in groupSeason.DefaultIfEmpty()
                      where s.SEASON_ID == SEASON_ID && Schedule.SCHEDULE_ID == null
                      select new CLASS_TBL_MIX
                      {
                          SEASON_ID = s.SEASON_ID,
                          SCHEDULE_ID = s.SCHEDULE_ID,
                          SEASON_NAME = Season.SEASON_NAME,
                          NOTE = Season.NOTE,
                          DATE_FOR = current_date
                         // TOTAL_LICENSE = Schedule.TOTAL_LICENSE + "នាក់",
                       //   REMAIN_LICENSE = Schedule.REMAIN_LICENSE +"នាក់"
                      };
            return all;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SEASON_ID"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SEASON_ID"></param>
        /// <returns></returns>
        public List<CLASS_TBL_SCHEDULE> DisplayToGenerate(int SEASON_ID)
        {
            string current_date = DateTime.Now.ToString("ថ្ងៃ dd - ខែ MM - ឆ្នាំ yyy");  
            _context = new LicenseDataContext();
            if (SEASON_ID == 0)
            {
                var result = _context.RUN_SHOW_ALL_SEASON()
                            .Select(g => new CLASS_TBL_SCHEDULE
                            {
                                SEASON_ID = g.SEASON_ID,
                                SEASON_NAME = g.SEASON_NAME,
                                NOTE = g.NOTE,
                                DATE_FOR = current_date,
                                TOTAL_LICENSE = g.TOTAL_LICENSE.ToString() + Properties.Resources.NEAK,
                                REMAIN_LICENSE = g.REMAIN_LICENSE.ToString() + Properties.Resources.NEAK
                            });
                return result.ToList();
                
            }
            else
            {
                // query calculate total have been run already
                var total_run = from lg in _context.TBL_LICENSE_GENERATEs
                                join s in _context.TBL_SCHEDULEs on lg.SCHEDULE_ID equals s.SCHEDULE_ID
                                where s.SEASON_ID == SEASON_ID
                                select SEASON_ID;
                // query total license calculate in schedule
                var total_license = from s in _context.TBL_SCHEDULEs
                                    where s.SEASON_ID == SEASON_ID
                                    select s;
                var result = from s in _context.TBL_SEASONs
                             where s.SEASON_ID == SEASON_ID
                             select new CLASS_TBL_SCHEDULE
                             {
                                 SEASON_ID = s.SEASON_ID,
                                 SEASON_NAME = s.SEASON_NAME,
                                 NOTE = s.NOTE,
                                 DATE_FOR = current_date,
                                 TOTAL_LICENSE = total_license.Count() + "នាក់",
                                 REMAIN_LICENSE = total_license.Count() - total_run.Count() + "នាក់"
                             };
                return result.ToList();    
            }
            
        }

    }
}
