﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebLearningProj.Models;
using WebLearningProj.StudentData;

namespace WebLearningProj.Controllers
{
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentData _studentData;
        public StudentsController(IStudentData studentData)
        {
            _studentData = studentData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStudents()
        {
            return Ok(_studentData.GetStudents());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetStudent(int id)
        {
            if (_studentData.GetStudent(id) != null)
            {
                return Ok(_studentData.GetStudent(id));
            }
            else
            {
                return NotFound($"The student with Id: {id} was not found");
            }
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddStudent(Student student)
        {
            _studentData.AddStudent(student);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + student.Id,student);
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _studentData.GetStudent(id);
            if(student != null)
            {
                _studentData.DeleteStudent(student);
                return Ok();
            }
            return NotFound($"The student with Id: {id} was not found");
        }
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditStudent(int id,Student student)
        {
            var _student = _studentData.GetStudent(id);
            if (_student != null)
            {
                student.Id = _student.Id;
                _studentData.EditStudent(student);
                return Ok();
            }
            return NotFound($"The student with Id: {id} was not found");
        }
    }
}