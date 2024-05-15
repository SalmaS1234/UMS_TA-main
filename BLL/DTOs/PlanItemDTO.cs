using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PlanItemDTO
    {
       
        public int ID { get; set; }
       
        public int P_ID { get; set; }
        public string ItemType { get; set; } // course, assignment, resource
        public int ItemIdReference { get; set; }
        public bool IsAdded { get; set; }

    }
}
