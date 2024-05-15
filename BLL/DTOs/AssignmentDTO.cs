using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AssignmentDTO
    {

      
        public int ID { get; set; }
       
        public int S_ID { get; set; }
       
        public int C_ID { get; set; }

        public string AssignmentTitle { get; set; }

        public string AssignmentDescription { get; set; }
        public DateTime DeadlineDate { get; set; }

    }
}
