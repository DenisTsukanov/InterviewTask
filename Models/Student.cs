using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebLearningProj.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage = "Name can't be longer than 50 characters")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public string Group { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public int TypeOfStudyingId { get; set; }
        [ForeignKey("TypeOfStudyingId")]
        public TypeOfStudying TypeOfStudying { get; set; }
        [Required]
        public bool IsExpelled { get; set; } = false;
    }
}
