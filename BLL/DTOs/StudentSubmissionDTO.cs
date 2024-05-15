using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentSubmissionDTO:StudentDTO
    {
        public List<SubmissionDTO> submissions { get; set; }
        public ConvocationRequestDTO ConvocationRequest { get; set; }
        public AssignmentDTO Assignment { get; set; }
        public InternDTO Intern { get; set; }
        public FeedandSurveryDTO FeedandSurvery { get; set; }
        public StudentSubmissionDTO()
        {
            submissions = new List<SubmissionDTO>();
        }
    }
}
