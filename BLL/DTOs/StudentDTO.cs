using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public string Nationality { get; set; }

        public string Department { get; set; }
        public string Mobile { get; set; }
        public DateTime Birthday { get; set; }
        public string NID { get; set; }
        public string PresentAddress { get; set; }
        public string ParmanentAddress { get; set; }
    }
}
