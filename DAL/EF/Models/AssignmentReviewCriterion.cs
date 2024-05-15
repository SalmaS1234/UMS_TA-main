using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class AssignmentReviewCriterion
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ReviewCriterion")]
        public int CR_ID { get; set; }
        [ForeignKey("Assignment")]
        public int A_ID { get; set; }

        [ForeignKey("Student")]
        public int S_ID { get; set; }

        [ForeignKey("Teacher")]
        public int T_ID { get; set; }

        public Assignment Assignment { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        
        public ReviewCriterion ReviewCriterion { get; set; }

    }
}
