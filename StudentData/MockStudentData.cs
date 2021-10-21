using System;
using System.Collections.Generic;
using System.Linq;
using WebLearningProj.Models;

namespace WebLearningProj.StudentData
{
    public class MockStudentData : IStudentData
    {
        private List<Student> students = new List<Student>()
        {
            new Student()
            {   Id = 1,
                Name="Shtemp",
                Surname="Lisov",
                //Group="228",
                //EnrollmentDate=DateTime.Now.AddDays(5),
                //IsExpelled=false,
                //Patronymic="Fedosovich",
                //PhoneNumber="+380955291404",
                //TypeOfStudying = "Ochka"
            },
            new Student()
            {   Id = 2,
                Name="Nastya",
                Surname="Cherrikova",
                //Group="104",
                //EnrollmentDate=DateTime.Now.AddDays(2),
                //IsExpelled=false,
                //Patronymic="Denisovna",
                //PhoneNumber="+380955297777",
                //TypeOfStudying = "ZaOchka"
            }
        };
        public Student AddStudent(Student student)
        {
            student.Id = 111;
            students.Add(student);
            return student;
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
        }

        public Student EditStudent(Student student)
        {
            var existingStudent = GetStudent(student.Id);
            existingStudent.Name = student.Name;
            existingStudent.Surname = student.Surname;
            return existingStudent;
        }

        public Student GetStudent(int id)
        {
            return students.SingleOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
