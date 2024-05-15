using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class AddRequestPaperPublish
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public string Website { get; set; }
        public DateTime PublishDate { get; set; }
        public int GroupMember { get; set; }
        public virtual Student Student { get; set; }
    }
}
