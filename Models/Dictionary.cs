using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLearningProj.Models
{
    public class Dictionary
    {

    }
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Subject name can't be longer than 50 characters")]
        public string SubjectName { get; set; }
    }
    public class ScienceDegree
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "ScienceDegree name can't be longer than 50 characters")]
        public string ScienceDegreeName { get; set; }
    }
    public class TypeOfStudying
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "TypeOfStudying name can't be longer than 50 characters")]
        public string TypeOfStudyingName { get; set; }
    }
}
