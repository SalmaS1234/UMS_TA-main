namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class toukir11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "Student_ID", c => c.Int());
            CreateIndex("dbo.Assignments", "Student_ID");
            AddForeignKey("dbo.Assignments", "Student_ID", "dbo.Students", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignments", "Student_ID", "dbo.Students");
            DropIndex("dbo.Assignments", new[] { "Student_ID" });
            DropColumn("dbo.Assignments", "Student_ID");
        }
    }
}
