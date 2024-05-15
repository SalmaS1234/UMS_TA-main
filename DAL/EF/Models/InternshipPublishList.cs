using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class InternshipPublishList
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Student")]
        public int S_ID { get; set; }

        public string Title { get; set; }

     
        public string Description { get; set; }

        public string Location { get; set; }

        public string Duration { get; set; }

        public string RequiredSkills { get; set; }



        [ForeignKey("Company")]
        public int AllCompanyId { get; set; } // Foreign key referencing the Company model



        [ForeignKey("Intern")]
        public int AllInternId { get; set; } // Foreign key referencing the Intern model


        public virtual Company Company { get; set; }

        public virtual Intern Intern { get; set; }
        public virtual Student Student { get; set; }
    }
}
