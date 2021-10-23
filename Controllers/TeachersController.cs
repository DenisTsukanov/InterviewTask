using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebLearningProj.Data.TeacherData;
using WebLearningProj.DictionaryData;
using WebLearningProj.Models;

namespace WebLearningProj.Controllers
{
    [ApiController]
    public class TeachersController : ControllerBase
    {
        ITeacherData _teacherData;
        IDictionaryData _dictionaryData;
        public TeachersController(ITeacherData teacherData, IDictionaryData dictionaryData)
        {
            _teacherData = teacherData;
            _dictionaryData = dictionaryData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetTeachers()
        {
            return Ok(_teacherData.GetTeachers());
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddTeacher(Teacher teacher)
        {
            var science_degree = _dictionaryData.GetScienceDegree(teacher.ScienceDegreeId);
            if(science_degree != null)
            {
                _teacherData.AddTeacher(teacher);
                return Ok();
            }
            return NotFound($"The science degree with Id: {teacher.ScienceDegreeId} was not found");
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            var existing_teacher = _teacherData.GetTeacher(id);
            if (existing_teacher != null)
            {
                _teacherData.DeleteTeacher(existing_teacher);
                return Ok();
            }
            return NotFound($"The student with Id: {id} was not found");
        }
    }
}
