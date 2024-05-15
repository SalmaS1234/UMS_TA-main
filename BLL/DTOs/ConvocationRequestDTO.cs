using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ConvocationRequestDTO
    {
        public int ID { get; set; }
   
        public int S_ID { get; set; }
        public double CGPA { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }
        public int NumberOfGuest { get; set; }
        public string PurchasingGownandCap { get; set; }
    }
}
