using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeacherCourseDTO: TeacherDTO
    {
        public List<CourseDTO> Courses { get; set; }
        public TeacherCourseDTO()
        {
            Courses = new List<CourseDTO>();
        }
    }
}
