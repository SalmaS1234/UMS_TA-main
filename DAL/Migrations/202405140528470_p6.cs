namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "T_ID", "dbo.Teachers");
            AddColumn("dbo.Teachers", "Course_ID", c => c.Int());
            AddColumn("dbo.Courses", "Teacher_ID", c => c.Int());
            CreateIndex("dbo.Teachers", "Course_ID");
            CreateIndex("dbo.Courses", "Teacher_ID");
            AddForeignKey("dbo.Teachers", "Course_ID", "dbo.Courses", "ID");
            AddForeignKey("dbo.Courses", "Teacher_ID", "dbo.Teachers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "Course_ID", "dbo.Courses");
            DropIndex("dbo.Courses", new[] { "Teacher_ID" });
            DropIndex("dbo.Teachers", new[] { "Course_ID" });
            DropColumn("dbo.Courses", "Teacher_ID");
            DropColumn("dbo.Teachers", "Course_ID");
            AddForeignKey("dbo.Courses", "T_ID", "dbo.Teachers", "ID", cascadeDelete: true);
        }
    }
}
