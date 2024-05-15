using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentCourseAssisgnmentSubmissionReviewConvocationInternComapanyDTO:StudentDTO
    {
        public List<ReviewDTO> Reviews { get; set; }
        public List<SubmissionDTO> Submissions { get; set; }
        public List<CourseDTO> Courses { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<ConvocationRequest>convocationRequests { get; set; }
        public List<FeedandSurvery> feedandSurveries { get; set; }
        
        public StudentCourseAssisgnmentSubmissionReviewConvocationInternComapanyDTO()
        {
            Reviews = new List<ReviewDTO>();
            Submissions = new List<SubmissionDTO>();
            Courses = new List<CourseDTO>();
            Assignments  = new List<Assignment>();
            convocationRequests= new List<ConvocationRequest>();
            feedandSurveries = new List<FeedandSurvery>();
        }
    }
}
