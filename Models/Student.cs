using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLearningProj.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage = "Name can't be longer than 50 characters")]
        public string Name { get; set; }
        public string Surname { get; set; }
        //public string Patronymic { get; set; }
        //public string Group { get; set; }
        //public DateTime EnrollmentDate { get; set; }
        //[Phone]
        //public string PhoneNumber { get; set; }
        //public string TypeOfStudying { get; set; }
        //public bool IsExpelled { get; set; } = false;
    }
}
