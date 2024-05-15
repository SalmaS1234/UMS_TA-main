using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class InternshipPublishListDTO
    {
        public int ID { get; set; }

        public int S_ID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Duration { get; set; }

        public string RequiredSkills { get; set; }

        public int AllCompanyId { get; set; }
        public int AllInternId { get; set; }
    }
}
