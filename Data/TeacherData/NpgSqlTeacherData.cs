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
        public List<Teacher> GetTeachers()
        {
            return _applicationContext.Teachers.ToList();
        }
        public List<Teacher> GetTeachers(string scienceDegree, string surname, string subject)
        {
            List<Teacher> teachersList = new List<Teacher>();
            if (string.IsNullOrWhiteSpace(scienceDegree) && string.IsNullOrWhiteSpace(surname) && string.IsNullOrWhiteSpace(subject))
            {
                return GetTeachers();
            }
            if (!string.IsNullOrWhiteSpace(scienceDegree))
            {
                scienceDegree = scienceDegree.Trim();
                teachersList = (from t in _applicationContext.Teachers
                                join sd in _applicationContext.ScienceDegrees on t.ScienceDegreeId equals sd.Id
                                where sd.ScienceDegreeName == scienceDegree
                                select t).ToList();
            }
            if (!string.IsNullOrWhiteSpace(subject))
            {
                subject = subject.Trim();
                teachersList = (from t in _applicationContext.Teachers
                                join schdl in _applicationContext.Schedules on t.Id equals schdl.TeacherId
                                join sbjct in _applicationContext.Subjects on schdl.SubjectId equals sbjct.Id
                                where sbjct.SubjectName == subject
                                select t).Distinct().ToList();
            }
            if (!string.IsNullOrWhiteSpace(surname))
            {
                surname = surname.Trim();
                teachersList = _applicationContext.Teachers.Where(x => x.Surname == surname).ToList();
            }
            return teachersList;
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
