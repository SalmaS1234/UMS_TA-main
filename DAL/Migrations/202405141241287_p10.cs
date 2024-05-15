namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Username", c => c.String());
            AddColumn("dbo.Students", "Password", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Students", "ConfirmPassword", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ConfirmPassword");
            DropColumn("dbo.Students", "Password");
            DropColumn("dbo.Students", "Username");
        }
    }
}
