namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p11_create_token_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAT = c.DateTime(nullable: false),
                        DeletedAT = c.DateTime(nullable: false),
                        UserID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tokens");
        }
    }
}
