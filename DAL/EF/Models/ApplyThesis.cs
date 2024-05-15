using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ApplyThesis
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public string DName { get; set;}
        public int CurrentSemester { get; set;}
        public string TopicName { get; set;}
        public string Supervisor { get; set;}
        public int AddMember { get; set;}
        public DateTime created { get; set;}
        public virtual Student Student { get; set;}
    }
}
