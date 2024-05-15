using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReasearchCollaborationDTO
    {

        
        public int ID { get; set; }
      
        public int S_ID { get; set; }
        
        public int A_ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public String Status { get; set; }
        public virtual Student Student { get; set; }
        public virtual Alumni Alumni { get; set; }
    }
}
