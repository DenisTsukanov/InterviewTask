using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLearningProj.Models;

namespace WebLearningProj.Data.ScheduleData
{
    public interface IScheduleData
    {
        public List<Schedule> GetSchedule();
    }
}
