using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReviewDTO
    {
        
        public int ID { get; set; }
        
        public int S_ID { get; set; }
       

        public int T_ID { get; set; }
      
        public int SubmissionId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string ReviewContent { get; set; }
        public int ReviewScore { get; set; }

    }
}
