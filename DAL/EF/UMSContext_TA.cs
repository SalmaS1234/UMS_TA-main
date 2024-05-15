using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class UMSContext_TA: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<PaperPublishList> paperPublishLists { get; set; }
        public DbSet<FeedandSurvery> feedandSurveries { get; set; }
        public DbSet<ConvocationRequest> convocationRequests { get; set; }
        public DbSet<CertificationTable> certificationTables { get; set; }
        public DbSet<ApplyThesis> ApplyTheses { get; set; }
        public DbSet<AddRequestPaperPublish> addRequestPaperPublishes { get; set; }

        public DbSet<Company> companies { get; set; }
        public DbSet<Intern> interns { get; set; }
        public DbSet<InternshipPublishList> internshipPublishLists { get; set; }




        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<AssignmentReviewCriterion> AssignmentReviewCriterions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<LearningPlan> LearningPlans { get; set; }
        public DbSet<PlanItem> PlanItems { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewCriterion> ReviewCriterions { get; set; }
        public DbSet<StudentProfile> StudentProfiles { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Alumni> Alumnis { get; set; }
        public DbSet<CareerInsights>CareerInsights { get; set; }
        public DbSet<Mentorship>Mentorships { get; set; }
        public DbSet<ReasearchCollaboration>ReasearchCollaborations { get; set; }





        public UMSContext_TA() : base("name=UMSContext_TA")
        {
            // Increase command timeout to 5 minutes (300 seconds)
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 300;
        }







        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConvocationRequest>().HasRequired(c => c.Student)
                .WithMany(s => (ICollection<ConvocationRequest>)s.convocationRequests)
                .HasForeignKey(c => c.S_ID)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Assignment>()
               .HasRequired(a => a.Student)
               .WithMany()
               .HasForeignKey(a => a.S_ID)
               .WillCascadeOnDelete(false); // Disable cascade delete here

            modelBuilder.Entity<Course>()
                .HasRequired(c => c.Student)
                .WithMany()
                .HasForeignKey(c => c.S_ID)
                .WillCascadeOnDelete(true); // Keep cascade delete for Courses if necessary
        }

    }
}
