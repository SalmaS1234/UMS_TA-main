using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentandFeedandSurveryDTO:StudentDTO
    {
        public List<FeedandSurveryDTO> feedandSurveries { get; set; }
        public StudentandFeedandSurveryDTO()
        {
            feedandSurveries = new List<FeedandSurveryDTO >();
        }
    }
}
