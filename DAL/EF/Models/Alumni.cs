using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Alumni
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Post { get; set; }
        public string ContactDetails { get; set; }
        public virtual Student Student { get; set; }
    }
}
