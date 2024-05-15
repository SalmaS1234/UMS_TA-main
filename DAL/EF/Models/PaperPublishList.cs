using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class PaperPublishList
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("AddRequestPaperPublish")]
        public int ARPB { get; set; }
        public DateTime Checkedat { get; set; }
        public virtual AddRequestPaperPublish AddRequestPaperPublish { get; set; }

    }
}
