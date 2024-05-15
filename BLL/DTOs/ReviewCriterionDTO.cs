using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReviewCriterionDTO
    {

        public int ID { get; set; }

        public int S_ID { get; set; }

        public int T_ID { get; set; }

        public string CriterionName { get; set; }
        public string CriterionDescription { get; set; }
    }
}
