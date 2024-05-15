using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Token
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string TKey { get; set; }
        [Required]
        public DateTime CreatedAT { get; set; }
        [Required]
        public DateTime? DeletedAT { get; set;}
        [Required]
        public string UserID {  get; set; }

    }
}
