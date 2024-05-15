using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class PlanItem
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("LearningPlan")]
        public int P_ID { get; set; }
        public string ItemType { get; set; } // course, assignment, resource
        public int ItemIdReference { get; set; }
        public bool IsAdded { get; set; }

        // Navigation properties
        
        public LearningPlan LearningPlan { get; set; }

    }
}
