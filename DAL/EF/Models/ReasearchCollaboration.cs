using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ReasearchCollaboration
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID {  get; set; }
        [ForeignKey("Alumni")]
        public int A_ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set;}
        public String Status { get; set;}
        public virtual Student Student { get; set;}
        public virtual Alumni Alumni { get; set;}
    }
}
