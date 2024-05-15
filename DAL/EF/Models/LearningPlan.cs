using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class LearningPlan
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public string PlanName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        // Navigation properties
       
        public Student Student { get; set; }
        public ICollection<PlanItem> PlanItems { get; set; }

    }
}
