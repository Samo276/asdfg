using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terminy.models;
namespace terminy.schematy.brygadowka
{
    public class AlgBryg
    {
        public bryg _data = new bryg();        
        public List<Match> _schedule = new();

        #region Fetch_FromDatabase
        private List<Group> GetGroups()
        {
            var tmpgroups = new List<Group>();
            foreach (var item in _data._employeeGroups)
                tmpgroups.Add(item);
            return tmpgroups;
        }
        private List<Shift> GetShifts()
        {
            var tmpshifts = new List<Shift>();
            foreach (var item in _data._shiftList.Shifts)
                tmpshifts.Add(item);
            return tmpshifts;
        }

        #endregion

        #region Operations
        private List<Group> CheckGroupAvailability(List<Group> allgroups, int maxwt, int maxft)
        {
            var noOfShifts = _data._shiftList.Shifts.Count();
            var tmp = new List<Group>();
            foreach (var item in allgroups)
            {
                if (item.freetime == maxft)
                {
                    item.freetime = 0;
                    item.worktime = 0;
                    item.lastshiftId= (item.lastshiftId+1)% (noOfShifts+1);
                    if (item.lastshiftId == 0) item.lastshiftId = 1;
                    tmp.Add(item);
                }
                if (item.worktime < maxwt)
                {                    
                    tmp.Add(item);
                }
                if(item.worktime >= maxwt)
                {
                    item.freetime++;
                }
                Console.WriteLine("g("+item.Name+") w:"+item.worktime+" f: " +item.freetime);
            }
            return tmp;
        }
        private void AddAllToSchedule(List<Match> tmp)
        {
            foreach (var item in tmp)
                _schedule.Add(item);
        }
        public void PrintResults()
        {
            int x = 0;
            foreach (var item in _schedule)
            {
                Console.WriteLine(
                    "ls: " + _data._employeeGroups.Where(x => item.groupID == x.Id).FirstOrDefault().lastshiftId +
                    " shift: " + item.shiftID +
                    /*" crew:"+*/ _data._employeeGroups.Where(x => item.groupID == x.Id).FirstOrDefault().Name +
                    " date: " + item.ShiftTime.Date
                    );
                
                if (item.shiftID == 3) Console.WriteLine();

            }
        }
        
        #endregion

        public void Setup_dayOne()
        {
            _data.FetchSampleData(false, false);

            /*var tmpgroups = GetGroups();

            var tmpshifts = GetShifts();

            var tmp_matchList = new List<Match>();

            for (int i = 0; i <= tmpshifts.Count; i++)
            {
                tmp_matchList.Add(new Match(tmpshifts.FirstOrDefault().Id, tmpgroups.FirstOrDefault().Id,DateTime.Now));
                tmpshifts.Remove(tmpshifts.FirstOrDefault());

                var tmp = _data._employeeGroups.Where(x => x == tmpgroups.FirstOrDefault()).ToList();
                tmp.FirstOrDefault().worktime++;
                tmp.FirstOrDefault().lastshiftId=i;
                tmpgroups.Remove(tmpgroups.FirstOrDefault());
            }

            _schedule = tmp_matchList;*/
        }
        public void Progress(int maxwt, int maxft, int noDays, DateTime fromDate)
        {
            var tmp_matchList = new List<Match>();
            for (int i = 1; i <= noDays; i++)
            {
                var tmpgroups = GetGroups();
                var tmpshifts = GetShifts();

                var avGroups = CheckGroupAvailability(tmpgroups, maxwt, maxft);
                //avGroups.OrderBy(x=> x.Id);
                //Console.WriteLine(avGroups.Count);

                foreach (var item in avGroups)
                {
                    Console.Write(item.Name);
                }
                Console.WriteLine();
                foreach (var _shift in tmpshifts)
                {
                    if (avGroups.Where(x => x.lastshiftId == _shift.Id).Any())
                    {
                        var tmp = avGroups.Where(x => x.lastshiftId == _shift.Id).First();
                        tmp_matchList.Add(new Match(
                            _shift.Id, 
                            tmp.Id, 
                            fromDate.AddDays(i))
                            );
                        tmp.worktime++;
                    }
                    
                }
            }
            AddAllToSchedule(tmp_matchList);
        }
    }
}
