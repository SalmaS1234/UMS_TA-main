using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentAssisgnmentDTO:StudentDTO
    {
        public List<AssignmentDTO> Assignments { get; set; }
        public StudentAssisgnmentDTO()
        {
            Assignments = new List<AssignmentDTO>();
        }

    }
}
