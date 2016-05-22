using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPowerGenerateLicense.Class;
using System.Data;

namespace EPowerGenerateLicense.Model
{
    public class TBL_SEASON_DATA_ACCESS : IDisposable
    {
        private LicenseDataContext _context = null;

        public void Dispose()
        {

        }
        public List<RUN_SHOW_HISTORY_SURVEYResult> ShowSurvey(int SEASON_ID)
        {
            _context = new LicenseDataContext();
            var result = _context.RUN_SHOW_HISTORY_SURVEY(SEASON_ID);
            return result.ToList();
        }
        public List<RUN_SHOW_NUMBER_AVAILABLEResult> ShowSeason(int SEASON_ID)
        {
            _context = new LicenseDataContext();
            var result = _context.RUN_SHOW_NUMBER_AVAILABLE(SEASON_ID);
            return result.ToList();
        }
        public IQueryable<TBL_SEASON> ShowAllSeasonIncludeInactive()
        {
            _context = new LicenseDataContext();
            var result = from s in _context.TBL_SEASONs select s;
            return result;
        }
        public IQueryable<TBL_SEASON> CheckSeason(string SEASON_NAME)
        {
            _context = new LicenseDataContext();
            var all = from s in _context.TBL_SEASONs where s.SEASON_NAME == SEASON_NAME select s;
            
            return all;
        }
        public IQueryable<TBL_SEASON> CheckSeasonWithoutExisting(string SEASON_NAME)
        {
            _context = new LicenseDataContext();
            var all = from s in _context.TBL_SEASONs where s.SEASON_NAME == SEASON_NAME select s;
            return all;
        }
        public IQueryable<TBL_LICENSE> ShowAllLicense()
        {
            _context = new LicenseDataContext();
            var all = from l in _context.TBL_LICENSEs select l;
            return all;
        }
        public IQueryable<CLASS_TBL_SEASON> ShowSeasonNameByName(string SEASON_NAME)
        {
            _context = new LicenseDataContext();
            var resutl = from s in _context.TBL_SEASONs
                         where s.SEASON_NAME == SEASON_NAME && s.IS_ACTIVE == true
                         select new CLASS_TBL_SEASON
                         {
                             SEASON_ID = s.SEASON_ID,
                             SEASON_NAME = s.SEASON_NAME,
                             NOTE = s.NOTE,
                             CREATE_BY = s.CREATE_BY
                         };
            return resutl;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<CLASS_TBL_SEASON> ShowSeasonNameByID(int SEASON_ID)
        {
            _context = new LicenseDataContext();
            var resutl = from s in _context.TBL_SEASONs
                         where s.SEASON_ID == SEASON_ID
                         select new CLASS_TBL_SEASON
                         {
                             SEASON_ID = s.SEASON_ID,
                             SEASON_NAME = s.SEASON_NAME,
                             NOTE = s.NOTE,
                             CREATE_BY = s.CREATE_BY
                         };
            return resutl;
        }
        public void SaveSchedule(TBL_SCHEDULE schedule)
        {
            using (_context = new LicenseDataContext())
            {
                _context.TBL_SCHEDULEs.InsertOnSubmit(schedule);
                _context.SubmitChanges();
            }
        }
        public void SaveSeason(TBL_SEASON season)
        {
            using (_context = new LicenseDataContext())
            {
                _context.TBL_SEASONs.InsertOnSubmit(season);
                _context.SubmitChanges();
            };
        }
 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SEASON_ID"></param>
        /// <returns></returns>
        public List<RUN_SHOW_SEASON_AVAILABLEResult> ShowSeason()
        {
            _context = new LicenseDataContext();
            var result = _context.RUN_SHOW_SEASON_AVAILABLE();
            return result.ToList();
        }
        public DataTable ShowAllSeasonToComboBox()
        {
            _context = new LicenseDataContext();
            var result = from s in _context.TBL_SEASONs
                         where s.IS_ACTIVE == true
                         select new CLASS_TBL_SEASON
                         {
                             SEASON_ID = s.SEASON_ID,
                             SEASON_NAME = s.SEASON_NAME
                         };
            DataTable dt = new DataTable();
            dt.Columns.Add("SEASON_ID");
            dt.Columns.Add("SEASON_NAME");
            DataRow row1 = dt.NewRow();
            row1["SEASON_ID"] = 0;
            row1["SEASON_NAME"] = Properties.Resources.ALL_SEASON;
            dt.Rows.Add(row1);
            foreach (var q in result)
            {
                DataRow row = dt.NewRow();
                row["SEASON_ID"] = q.SEASON_ID;
                row["SEASON_NAME"] = q.SEASON_NAME;
                dt.Rows.Add(row);
            }
            return dt;
        }
        public IQueryable<TBL_SEASON> ShowAllSeason()
        {
            _context = new LicenseDataContext();
            var result = from s in _context.TBL_SEASONs where s.IS_ACTIVE == true select s;
            return result;
        }
    }
}
