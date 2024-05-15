using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Submission
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        [ForeignKey("Assignment")]

        public int A_ID { get; set; }

        [ForeignKey("Teacher")]

        public int T_ID { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string SubmissionContent { get; set; }
        public Teacher Teacher { get; set; }    

        // Navigation properties
      
        public Student Student { get; set; }
       
        public Assignment Assignment { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
