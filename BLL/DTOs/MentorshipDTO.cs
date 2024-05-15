using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MentorshipDTO
    {
        
        public int ID { get; set; }
        
        public int S_ID { get; set; }
        public string Name { get; set; }
        public string Interests { get; set; }
        public string CareerGoals { get; set; }
        public string MentorPreferences { get; set; }
        public string ApplicationStatus { get; set; }
    }
}
