namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateseed2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ConvocationRequests", "S_ID", "dbo.Students");
            AddForeignKey("dbo.ConvocationRequests", "S_ID", "dbo.Students", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConvocationRequests", "S_ID", "dbo.Students");
            AddForeignKey("dbo.ConvocationRequests", "S_ID", "dbo.Students", "ID", cascadeDelete: true);
        }
    }
}
