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
    }
}
