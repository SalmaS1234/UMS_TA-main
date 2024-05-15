using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int S_ID { get; set; }
          [ForeignKey("Teacher")]
        public int T_ID { get; set; }


         [Required]
        [StringLength(100)]
        public string CourseName { get; set; }

        [Required]
        [StringLength(20)]
        public string CourseCode { get; set; }
        public int Semester { get; set; }

        // Foreign key
       

        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public ICollection<Student> Students { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public Course()
        {
            Students = new List<Student>();
           Assignments = new List<Assignment>();
            Teachers = new List<Teacher>();

        }

    }
}
