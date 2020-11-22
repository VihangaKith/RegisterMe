namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ComfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
        }
    }
}
