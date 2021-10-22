using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebLearningProj.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public int ScienceDegreeId { get; set; }
        [ForeignKey("ScienceDegreeId")]
        public ScienceDegree ScienceDegree { get; set; }
        [Required]
        public string Position { get; set; }
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
