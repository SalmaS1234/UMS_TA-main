namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_datatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddRequestPaperPublishes", "GroupMember", c => c.Int(nullable: false));
            AlterColumn("dbo.ApplyThesis", "AddMember", c => c.Int(nullable: false));
            AlterColumn("dbo.CertificationTables", "GraduationYear", c => c.Int(nullable: false));
            AlterColumn("dbo.ConvocationRequests", "CGPA", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ConvocationRequests", "CGPA", c => c.String());
            AlterColumn("dbo.CertificationTables", "GraduationYear", c => c.String());
            AlterColumn("dbo.ApplyThesis", "AddMember", c => c.String());
            AlterColumn("dbo.AddRequestPaperPublishes", "GroupMember", c => c.String());
        }
    }
}
