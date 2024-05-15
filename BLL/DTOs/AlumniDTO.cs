using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AlumniDTO
    {
        
        public int ID { get; set; }
        public int S_ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Post { get; set; }
        public string ContactDetails { get; set; }
    }
}
