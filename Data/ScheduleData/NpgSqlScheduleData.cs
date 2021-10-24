using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLearningProj.Models;

namespace WebLearningProj.Data.ScheduleData
{
    public class NpgSqlScheduleData : IScheduleData
    {
        ApplicationContext _applicationContext;
        public NpgSqlScheduleData(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public List<Schedule> GetSchedule()
        {
            return _applicationContext.Schedules.ToList();
        }

        public List<Schedule> GetSchedule(string group)
        {
            if (string.IsNullOrWhiteSpace(group))
            {
                return GetSchedule();
            }
            group = group.Trim();
            return _applicationContext.Schedules.Where(x => x.Group == group).ToList();
        }
    }
}
