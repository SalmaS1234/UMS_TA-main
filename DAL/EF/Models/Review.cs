using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        [ForeignKey("Teacher")]

        public int T_ID { get; set; }
        [ForeignKey("Submission")]
        public int SubmissionId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string ReviewContent { get; set; }
        public int ReviewScore { get; set; }

        // Navigation properties
       
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }


        public Submission Submission { get; set; }

    }
}
