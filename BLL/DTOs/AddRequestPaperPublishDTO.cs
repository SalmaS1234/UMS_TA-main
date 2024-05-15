using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AddRequestPaperPublishDTO
    {
        public int ID { get; set; }
       
        public int S_ID { get; set; }
        public string Website { get; set; }
        public DateTime PublishDate { get; set; }
        public int GroupMember { get; set; }
    }
}
