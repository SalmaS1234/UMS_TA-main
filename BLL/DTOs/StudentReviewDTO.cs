using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentReviewDTO:StudentDTO
    {
        public List<ReviewDTO> reviews { get; set; }
        public TeacherDTO Teacher { get; set; }
        public SubmissionDTO Submission { get; set; }
        public ConvocationRequestDTO ConvocationRequest { get; set; }
        public AssignmentDTO Assignment { get; set; }
        public InternDTO Intern { get; set; }
        public FeedandSurveryDTO FeedandSurvery { get; set; }

        public StudentReviewDTO()
        {
            reviews = new List<ReviewDTO>();
        }
    }
}
