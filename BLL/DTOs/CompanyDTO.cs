using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CompanyDTO
    {
        public int ID { get; set; }
        public int S_ID { get; set; }

        public string Name { get; set; }
        public string Industry { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
