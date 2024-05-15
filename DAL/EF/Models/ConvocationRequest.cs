using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ConvocationRequest
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
        public double CGPA { get; set; }
        public string Major { get; set;}
        public string Minor { get; set;}
        public int NumberOfGuest { get; set; }
        public string PurchasingGownandCap {  get; set; }
        public  Student Student { get; set; }
    }
}
