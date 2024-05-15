using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentProfileDTO
    {

       
        public int ID { get; set; }
        public int S_ID { get; set; }
        public string PastPerformance { get; set; }
        public string Interests { get; set; }
        public string LearningStyles { get; set; }
    }
}
