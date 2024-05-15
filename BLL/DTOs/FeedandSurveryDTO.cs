using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeedandSurveryDTO
    {
        public int ID { get; set; }
        public int S_ID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime created { get; set; }
    }
}
