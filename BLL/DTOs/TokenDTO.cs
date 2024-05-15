using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {

        
        public int ID { get; set; }
      
        public string TKey { get; set; }
     
        public DateTime CreatedAT { get; set; }
       
        public DateTime? DeletedAT { get; set; }
      
        public string UserID { get; set; }
    }
}
