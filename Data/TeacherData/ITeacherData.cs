using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLearningProj.Models;

namespace WebLearningProj.Data.TeacherData
{
    public interface ITeacherData
    {
        List<Teacher> GetTeachers(string scienceDegree,string surname,string subject);
        Teacher GetTeacher(int id);
        Teacher AddTeacher(Teacher teacher);
        void DeleteTeacher(Teacher teacher);
    }
}
