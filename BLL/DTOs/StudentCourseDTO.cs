using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentCourseDTO:StudentDTO
    {
        public List<CourseDTO> Courses { get; set; }
        public StudentCourseDTO() {
            Courses = new List<CourseDTO>();
        }
    }
}
