using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Assignment
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        [ForeignKey("Course")]
        public int C_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string AssignmentTitle { get; set; }

        [Required]
        public string AssignmentDescription { get; set; }
        public DateTime DeadlineDate { get; set; }

        // Foreign key

        // public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public Course Course { get; set; }
      
        public ICollection<Submission> Submissions { get; set; }
        public ICollection<AssignmentReviewCriterion> AssignmentReviewCriteria { get; set; }

    }
}
