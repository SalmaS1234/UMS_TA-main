using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class StudentProfile
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public string PastPerformance { get; set; }
        public string Interests { get; set; }
        public string LearningStyles { get; set; }

        // Navigation properties
        
        public Student Student { get; set; }

    }
}
