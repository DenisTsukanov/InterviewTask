using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLearningProj.Models;

namespace WebLearningProj.Data.TeacherData
{
    public class NpgSqlTeacherData : ITeacherData
    {
        ApplicationContext _applicationContext;
        public NpgSqlTeacherData(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public List<Teacher> GetTeachers ()
        {
            return _applicationContext.Teachers.ToList(); 
        }
        public Teacher GetTeacher(int id)
        {
            return _applicationContext.Teachers.Find(id);
        }

        public Teacher AddTeacher(Teacher teacher)
        {
            _applicationContext.Teachers.Add(teacher);
            _applicationContext.SaveChanges();
            return teacher;
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _applicationContext.Teachers.Remove(teacher);
            _applicationContext.SaveChanges();
        }
    }
}
