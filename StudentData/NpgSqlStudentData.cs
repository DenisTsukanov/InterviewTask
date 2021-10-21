using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLearningProj.Models;

namespace WebLearningProj.StudentData
{
    public class NpgSqlStudentData : IStudentData
    {
        private StudentContext _studentContext;
        public NpgSqlStudentData(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public Student AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
            _studentContext.SaveChanges();
            return student;
        }

        public void DeleteStudent(Student student)
        {
            _studentContext.Students.Remove(student);
            _studentContext.SaveChanges();
        }

        public Student EditStudent(Student student)
        {
            var existing_student = _studentContext.Students.Find(student.Id);
            if(existing_student != null)
            {
                existing_student.Name = student.Name;
                _studentContext.Students.Update(existing_student);
                _studentContext.SaveChanges();
            }
            return student;
        }

        public Student GetStudent(int id)
        {
            return _studentContext.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return _studentContext.Students.ToList();
        }
    }
}
