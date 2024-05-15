using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ApplyThesisDTO
    {
        public int ID { get; set; }
        
        public int S_ID { get; set; }
        public string DName { get; set; }
        public int CurrentSemester { get; set; }
        public string TopicName { get; set; }
        public string Supervisor { get; set; }
        public int AddMember { get; set; }
        public DateTime created { get; set; }
    }
}
