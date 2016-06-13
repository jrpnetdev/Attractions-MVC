namespace Attractions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attractions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Type = c.String(),
                        ImageUrl = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DetailsUrl = c.String(),
                        IsFeatured = c.Boolean(nullable: false),
                        Country = c.String(),
                        Continent = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attractions", "User_Id", "dbo.Users");
            DropIndex("dbo.Attractions", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Attractions");
        }
    }
}
