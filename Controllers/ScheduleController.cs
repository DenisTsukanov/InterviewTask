using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebLearningProj.Data.ScheduleData;
using WebLearningProj.Data.TeacherData;
using WebLearningProj.DictionaryData;

namespace WebLearningProj.Controllers
{
    
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        IScheduleData _scheduleData;
        public ScheduleController (IScheduleData scheduleData)
        {
            _scheduleData = scheduleData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetSchedule()
        {
            return Ok(_scheduleData.GetSchedule());
        }
    }
}
