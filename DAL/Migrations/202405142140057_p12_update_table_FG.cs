namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p12_update_table_FG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumni",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        Name = c.String(),
                        Department = c.String(),
                        Company = c.String(),
                        Post = c.String(),
                        ContactDetails = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .Index(t => t.S_ID);
            
            CreateTable(
                "dbo.CareerInsights",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        SubmissionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .Index(t => t.S_ID);
            
            CreateTable(
                "dbo.Mentorships",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        Name = c.String(),
                        Interests = c.String(),
                        CareerGoals = c.String(),
                        MentorPreferences = c.String(),
                        ApplicationStatus = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .Index(t => t.S_ID);
            
            CreateTable(
                "dbo.ReasearchCollaborations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        A_ID = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        SubmissionDate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Alumni", t => t.A_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: false)
                //.ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .Index(t => t.S_ID)
                .Index(t => t.A_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReasearchCollaborations", "S_ID", "dbo.Students");
            DropForeignKey("dbo.ReasearchCollaborations", "A_ID", "dbo.Alumni");
            DropForeignKey("dbo.Mentorships", "S_ID", "dbo.Students");
            DropForeignKey("dbo.CareerInsights", "S_ID", "dbo.Students");
            DropForeignKey("dbo.Alumni", "S_ID", "dbo.Students");
            DropIndex("dbo.ReasearchCollaborations", new[] { "A_ID" });
            DropIndex("dbo.ReasearchCollaborations", new[] { "S_ID" });
            DropIndex("dbo.Mentorships", new[] { "S_ID" });
            DropIndex("dbo.CareerInsights", new[] { "S_ID" });
            DropIndex("dbo.Alumni", new[] { "S_ID" });
            DropTable("dbo.ReasearchCollaborations");
            DropTable("dbo.Mentorships");
            DropTable("dbo.CareerInsights");
            DropTable("dbo.Alumni");
        }
    }
}
