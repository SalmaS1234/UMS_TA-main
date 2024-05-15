using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseDTO
    {

        public int ID { get; set; }
        
        public int S_ID { get; set; }
       
        public int T_ID { get; set; }

        public string CourseName { get; set; }

        public string CourseCode { get; set; }
        public int Semester { get; set; }
    }
}
