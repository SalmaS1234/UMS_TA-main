using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class CertificationTable
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ConvocationRequest")]
        public int C_ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public int GraduationYear { get; set; }
        public virtual Student Student { get; set; }
        public virtual ConvocationRequest ConvocationRequest { get; set; }

    }
}
