using System.Collections.Generic;
using WebLearningProj.Models;

namespace WebLearningProj.StudentData
{
    public interface IStudentData
    {
        List<Student> GetStudents();
        List<Student> GetStudents(string group, string surname, string isExpelled);
        Student GetStudent(int id);
        Student AddStudent(Student student);
        void DeleteStudent(Student student);
        Student EditStudent(Student student);
    }
}
