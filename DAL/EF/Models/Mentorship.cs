using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Mentorship
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public string Name { get; set; }
        public string Interests { get; set; }
        public string CareerGoals { get; set; }
        public string MentorPreferences { get; set; }
        public string ApplicationStatus {  get; set; }
        public virtual Student Student { get; set; }
    }
}
