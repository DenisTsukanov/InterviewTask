using System.Collections.Generic;
using System.Linq;
using WebLearningProj.Models;

namespace WebLearningProj.StudentData
{
    public class NpgSqlStudentData : IStudentData
    {
        private ApplicationContext _applicationContext;
        public NpgSqlStudentData(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public Student AddStudent(Student student)
        {
            _applicationContext.Students.Add(student);
            _applicationContext.SaveChanges();
            return student;
        }

        public void DeleteStudent(Student student)
        {
            _applicationContext.Students.Remove(student);
            _applicationContext.SaveChanges();
        }

        public Student EditStudent(Student student)
        {
            var existing_student = _applicationContext.Students.Find(student.Id);
            if (existing_student != null)
            {
                existing_student.Name = student.Name;
                existing_student.Surname = student.Surname;
                existing_student.Patronymic = student.Patronymic;
                existing_student.Group = student.Group;
                existing_student.EnrollmentDate = student.EnrollmentDate;
                existing_student.PhoneNumber = student.PhoneNumber;
                existing_student.IsExpelled = student.IsExpelled;
                existing_student.TypeOfStudyingId = student.TypeOfStudyingId;
                _applicationContext.Students.Update(existing_student);
                _applicationContext.SaveChanges();
            }
            return student;
        }

        public Student GetStudent(int id)
        {
            return _applicationContext.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return _applicationContext.Students.ToList();
        }

        public List<Student> GetStudents(string group, string surname, string isExpelled)
        {
            List<Student> studentsList = new List<Student>();
            if (string.IsNullOrWhiteSpace(group) && string.IsNullOrWhiteSpace(surname) && string.IsNullOrWhiteSpace(isExpelled))
            {
                return GetStudents();
            }
            if (!string.IsNullOrWhiteSpace(group))
            {
                group = group.Trim();
                studentsList = _applicationContext.Students.Where(x => x.Group == group).ToList();
            }
            if (!string.IsNullOrWhiteSpace(surname))
            {
                surname = surname.Trim();
                studentsList = _applicationContext.Students.Where(x => x.Surname == surname).ToList();
            }
            if (!string.IsNullOrWhiteSpace(isExpelled))
            {
                isExpelled = isExpelled.Trim();
                if (isExpelled.ToLower()=="true" || isExpelled.ToLower() == "false")
                {
                    studentsList = _applicationContext.Students.Where(x => x.IsExpelled == bool.Parse(isExpelled)).ToList();
                }
            }
            return studentsList;
        }
    }
}
