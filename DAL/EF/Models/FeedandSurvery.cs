using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class FeedandSurvery
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public string Subject { get; set;}
        public string Message { get; set;}
        public DateTime created { get; set; }
        public virtual Student Student { get; set; }


    }
}
