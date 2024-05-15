namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "C_ID", c => c.Int(nullable: true));
            CreateIndex("dbo.Teachers", "C_ID");
            AddForeignKey("dbo.Teachers", "C_ID", "dbo.Courses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "C_ID", "dbo.Courses");
            DropIndex("dbo.Teachers", new[] { "C_ID" });
            DropColumn("dbo.Teachers", "C_ID");
        }
    }
}
