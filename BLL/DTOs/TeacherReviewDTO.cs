using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeacherReviewDTO:TeacherDTO
    {
        public List<ReviewDTO> Reviews { get; set; }
        public List<SubmissionDTO> Submissions { get; set; }
        public TeacherReviewDTO()
        {
            Reviews = new List<ReviewDTO>();
            Submissions = new List<SubmissionDTO>();
        }
    }
}
