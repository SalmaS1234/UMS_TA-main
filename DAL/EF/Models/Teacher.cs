using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Course")]
        public int C_ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; } // student, teacher, etc.
        public Course Course { get; set; }

        // Navigation properties
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<StudentProfile> StudentProfiles { get; set; }
        public virtual ICollection<LearningPlan> LearningPlans { get; set; }

        public Teacher()
        {
            Courses = new List<Course>();
            LearningPlans = new List<LearningPlan>();
            Submissions = new List<Submission>();
            Reviews = new List<Review>();
            StudentProfiles = new List<StudentProfile>();
        }
    }
}
