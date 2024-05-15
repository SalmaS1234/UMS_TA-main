namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateing_database_table_teacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        T_ID = c.Int(nullable: false),
                        CourseName = c.String(nullable: false, maxLength: 100),
                        CourseCode = c.String(nullable: false, maxLength: 20),
                        Semester = c.Int(nullable: false),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.T_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.S_ID)
                .Index(t => t.T_ID)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        C_ID = c.Int(nullable: false),
                        AssignmentTitle = c.String(nullable: false, maxLength: 200),
                        AssignmentDescription = c.String(nullable: false),
                        DeadlineDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.C_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.S_ID)
                //.ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .Index(t => t.S_ID)
                .Index(t => t.C_ID);
            
            CreateTable(
                "dbo.AssignmentReviewCriterions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CR_ID = c.Int(nullable: false),
                        A_ID = c.Int(nullable: false),
                        S_ID = c.Int(nullable: false),
                        T_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Assignments", t => t.A_ID, cascadeDelete: true)
                .ForeignKey("dbo.ReviewCriterions", t => t.CR_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.S_ID)
                //.ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.T_ID)
                 //.ForeignKey("dbo.Teachers", t => t.T_ID, cascadeDelete: true)
                .Index(t => t.CR_ID)
                .Index(t => t.A_ID)
                .Index(t => t.S_ID)
                .Index(t => t.T_ID);
            
            CreateTable(
                "dbo.ReviewCriterions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        T_ID = c.Int(nullable: false),
                        CriterionName = c.String(),
                        CriterionDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                //.ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                //.ForeignKey("dbo.Teachers", t => t.T_ID, cascadeDelete: true)
                 .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: false)
                .ForeignKey("dbo.Teachers", t => t.T_ID, cascadeDelete: false)
                .Index(t => t.S_ID)
                .Index(t => t.T_ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        ConfirmPassword = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        Role = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LearningPlans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        PlanName = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        Teacher_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID)
                .Index(t => t.S_ID)
                .Index(t => t.Teacher_ID);
            
            CreateTable(
                "dbo.PlanItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        P_ID = c.Int(nullable: false),
                        ItemType = c.String(),
                        ItemIdReference = c.Int(nullable: false),
                        IsAdded = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LearningPlans", t => t.P_ID, cascadeDelete: true)
                .Index(t => t.P_ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        T_ID = c.Int(nullable: false),
                        SubmissionId = c.Int(nullable: false),
                        ReviewDate = c.DateTime(nullable: false),
                        ReviewContent = c.String(),
                        ReviewScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .ForeignKey("dbo.Submissions", t => t.SubmissionId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.T_ID, cascadeDelete: true)
                .Index(t => t.S_ID)
                .Index(t => t.T_ID)
                .Index(t => t.SubmissionId);
            
            CreateTable(
                "dbo.Submissions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        A_ID = c.Int(nullable: false),
                        T_ID = c.Int(nullable: false),
                        SubmissionDate = c.DateTime(nullable: false),
                        SubmissionContent = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                //.ForeignKey("dbo.Assignments", t => t.A_ID, cascadeDelete: true)
                .ForeignKey("dbo.Assignments", t => t.A_ID, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: false)
                //.ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                //.ForeignKey("dbo.Teachers", t => t.T_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.T_ID, cascadeDelete: false)
                .Index(t => t.S_ID)
                .Index(t => t.A_ID)
                .Index(t => t.T_ID);
            
            CreateTable(
                "dbo.StudentProfiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        PastPerformance = c.String(),
                        Interests = c.String(),
                        LearningStyles = c.String(),
                        Teacher_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID)
                .Index(t => t.S_ID)
                .Index(t => t.Teacher_ID);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ResourceName = c.String(),
                        ResourceDescription = c.String(),
                        ResourceType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Students", "Course_ID", c => c.Int());
            CreateIndex("dbo.Students", "Course_ID");
            AddForeignKey("dbo.Students", "Course_ID", "dbo.Courses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Courses", "T_ID", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Course_ID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "S_ID", "dbo.Students");
            DropForeignKey("dbo.Assignments", "S_ID", "dbo.Students");
            DropForeignKey("dbo.Assignments", "C_ID", "dbo.Courses");
            DropForeignKey("dbo.AssignmentReviewCriterions", "T_ID", "dbo.Teachers");
            DropForeignKey("dbo.AssignmentReviewCriterions", "S_ID", "dbo.Students");
            DropForeignKey("dbo.AssignmentReviewCriterions", "CR_ID", "dbo.ReviewCriterions");
            DropForeignKey("dbo.ReviewCriterions", "T_ID", "dbo.Teachers");
            DropForeignKey("dbo.StudentProfiles", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.StudentProfiles", "S_ID", "dbo.Students");
            DropForeignKey("dbo.Reviews", "T_ID", "dbo.Teachers");
            DropForeignKey("dbo.Reviews", "SubmissionId", "dbo.Submissions");
            DropForeignKey("dbo.Submissions", "T_ID", "dbo.Teachers");
            DropForeignKey("dbo.Submissions", "S_ID", "dbo.Students");
            DropForeignKey("dbo.Submissions", "A_ID", "dbo.Assignments");
            DropForeignKey("dbo.Reviews", "S_ID", "dbo.Students");
            DropForeignKey("dbo.LearningPlans", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.LearningPlans", "S_ID", "dbo.Students");
            DropForeignKey("dbo.PlanItems", "P_ID", "dbo.LearningPlans");
            DropForeignKey("dbo.ReviewCriterions", "S_ID", "dbo.Students");
            DropForeignKey("dbo.AssignmentReviewCriterions", "A_ID", "dbo.Assignments");
            DropIndex("dbo.StudentProfiles", new[] { "Teacher_ID" });
            DropIndex("dbo.StudentProfiles", new[] { "S_ID" });
            DropIndex("dbo.Submissions", new[] { "T_ID" });
            DropIndex("dbo.Submissions", new[] { "A_ID" });
            DropIndex("dbo.Submissions", new[] { "S_ID" });
            DropIndex("dbo.Reviews", new[] { "SubmissionId" });
            DropIndex("dbo.Reviews", new[] { "T_ID" });
            DropIndex("dbo.Reviews", new[] { "S_ID" });
            DropIndex("dbo.PlanItems", new[] { "P_ID" });
            DropIndex("dbo.LearningPlans", new[] { "Teacher_ID" });
            DropIndex("dbo.LearningPlans", new[] { "S_ID" });
            DropIndex("dbo.ReviewCriterions", new[] { "T_ID" });
            DropIndex("dbo.ReviewCriterions", new[] { "S_ID" });
            DropIndex("dbo.AssignmentReviewCriterions", new[] { "T_ID" });
            DropIndex("dbo.AssignmentReviewCriterions", new[] { "S_ID" });
            DropIndex("dbo.AssignmentReviewCriterions", new[] { "A_ID" });
            DropIndex("dbo.AssignmentReviewCriterions", new[] { "CR_ID" });
            DropIndex("dbo.Assignments", new[] { "C_ID" });
            DropIndex("dbo.Assignments", new[] { "S_ID" });
            DropIndex("dbo.Courses", new[] { "Student_ID" });
            DropIndex("dbo.Courses", new[] { "T_ID" });
            DropIndex("dbo.Courses", new[] { "S_ID" });
            DropIndex("dbo.Students", new[] { "Course_ID" });
            DropColumn("dbo.Students", "Course_ID");
            DropTable("dbo.Resources");
            DropTable("dbo.StudentProfiles");
            DropTable("dbo.Submissions");
            DropTable("dbo.Reviews");
            DropTable("dbo.PlanItems");
            DropTable("dbo.LearningPlans");
            DropTable("dbo.Teachers");
            DropTable("dbo.ReviewCriterions");
            DropTable("dbo.AssignmentReviewCriterions");
            DropTable("dbo.Assignments");
            DropTable("dbo.Courses");
        }
    }
}
