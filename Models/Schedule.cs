using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebLearningProj.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Semestr { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Group { get; set; }
    }
}
