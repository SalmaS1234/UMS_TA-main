namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asasaaaaaaaaaaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Course_ID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Assignments", "S_ID", "dbo.Students");
            DropIndex("dbo.Students", new[] { "Course_ID" });
            DropIndex("dbo.Courses", new[] { "Student_ID" });
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        Course_ID = c.Int(nullable: false),
                        Student_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_ID, t.Student_ID })
                .ForeignKey("dbo.Courses", t => t.Course_ID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.Course_ID)
                .Index(t => t.Student_ID);
            
            AddForeignKey("dbo.Assignments", "S_ID", "dbo.Students", "ID");
            DropColumn("dbo.Students", "Course_ID");
            DropColumn("dbo.Courses", "Student_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Student_ID", c => c.Int());
            AddColumn("dbo.Students", "Course_ID", c => c.Int());
            DropForeignKey("dbo.Assignments", "S_ID", "dbo.Students");
            DropForeignKey("dbo.CourseStudents", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.CourseStudents", "Course_ID", "dbo.Courses");
            DropIndex("dbo.CourseStudents", new[] { "Student_ID" });
            DropIndex("dbo.CourseStudents", new[] { "Course_ID" });
            DropTable("dbo.CourseStudents");
            CreateIndex("dbo.Courses", "Student_ID");
            CreateIndex("dbo.Students", "Course_ID");
            AddForeignKey("dbo.Assignments", "S_ID", "dbo.Students", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "Student_ID", "dbo.Students", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Students", "Course_ID", "dbo.Courses", "ID", cascadeDelete: true);
        }
    }
}
