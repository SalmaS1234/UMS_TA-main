namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table_inter_internshiplisting_companyasasa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        Name = c.String(),
                        Industry = c.String(),
                        Location = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .Index(t => t.S_ID);
            
            CreateTable(
                "dbo.Interns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Education = c.String(),
                        Skills = c.String(),
                        Company_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.Company_ID)
                .Index(t => t.S_ID)
                .Index(t => t.Company_ID);
            
            CreateTable(
                "dbo.InternshipPublishLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        S_ID = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Location = c.String(),
                        Duration = c.String(),
                        RequiredSkills = c.String(),
                        AllCompanyId = c.Int(nullable: false),
                        AllInternId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Companies", t => t.AllCompanyId, cascadeDelete: true)
                .ForeignKey("dbo.Interns", t => t.AllInternId, cascadeDelete: false)
                .ForeignKey("dbo.Students", t => t.S_ID, cascadeDelete: false)
                .Index(t => t.S_ID)
                .Index(t => t.AllCompanyId)
                .Index(t => t.AllInternId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InternshipPublishLists", "S_ID", "dbo.Students");
            DropForeignKey("dbo.InternshipPublishLists", "AllInternId", "dbo.Interns");
            DropForeignKey("dbo.InternshipPublishLists", "AllCompanyId", "dbo.Companies");
            DropForeignKey("dbo.Companies", "S_ID", "dbo.Students");
            DropForeignKey("dbo.Interns", "Company_ID", "dbo.Companies");
            DropForeignKey("dbo.Interns", "S_ID", "dbo.Students");
            DropIndex("dbo.InternshipPublishLists", new[] { "AllInternId" });
            DropIndex("dbo.InternshipPublishLists", new[] { "AllCompanyId" });
            DropIndex("dbo.InternshipPublishLists", new[] { "S_ID" });
            DropIndex("dbo.Interns", new[] { "Company_ID" });
            DropIndex("dbo.Interns", new[] { "S_ID" });
            DropIndex("dbo.Companies", new[] { "S_ID" });
            DropTable("dbo.InternshipPublishLists");
            DropTable("dbo.Interns");
            DropTable("dbo.Companies");
        }
    }
}
