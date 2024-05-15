using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ReviewCriterion
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        [ForeignKey("Teacher")]
        public int T_ID { get; set; }

        public string CriterionName { get; set; }
        public string CriterionDescription { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public ICollection<AssignmentReviewCriterion> AssignmentReviewCriteria { get; set; }

    }
}
