using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SubmissionDTO
    {

        public int ID { get; set; }
       
        public int S_ID { get; set; }
        

        public int A_ID { get; set; }

        

        public int T_ID { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string SubmissionContent { get; set; }

    }
}
