namespace PentiaCodeTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarMakes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CarMakeId = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarMakes", t => t.CarMakeId)
                .Index(t => t.CarMakeId);
            
            CreateTable(
                "dbo.CarPurchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                        SalesPersonId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        PricePaid = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: false)
                .ForeignKey("dbo.People", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("dbo.People", t => t.SalesPersonId, cascadeDelete: false)
                .Index(t => t.CustomerId)
                .Index(t => t.CarId)
                .Index(t => t.SalesPersonId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarMakeId = c.Int(nullable: false),
                        CarModelId = c.Int(nullable: false),
                        Colour = c.String(),
                        Extras = c.String(),
                        RecommendPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarMakes", t => t.CarMakeId, cascadeDelete: true)
                .ForeignKey("dbo.CarModels", t => t.CarModelId, cascadeDelete: true)
                .Index(t => t.CarMakeId)
                .Index(t => t.CarModelId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Surname = c.String(maxLength: 100),
                        Address = c.String(),
                        Created = c.DateTime(defaultValueSql:"GETDATE()"),
                        DateOfBirth = c.DateTime(),
                        JobTitle = c.String(),
                        Salary = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarPurchases", "SalesPersonId", "dbo.People");
            DropForeignKey("dbo.CarPurchases", "CustomerId", "dbo.People");
            DropForeignKey("dbo.CarPurchases", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "CarModelId", "dbo.CarModels");
            DropForeignKey("dbo.Cars", "CarMakeId", "dbo.CarMakes");
            DropForeignKey("dbo.CarModels", "CarMakeId", "dbo.CarMakes");
            DropIndex("dbo.Cars", new[] { "CarModelId" });
            DropIndex("dbo.Cars", new[] { "CarMakeId" });
            DropIndex("dbo.CarPurchases", new[] { "SalesPersonId" });
            DropIndex("dbo.CarPurchases", new[] { "CarId" });
            DropIndex("dbo.CarPurchases", new[] { "CustomerId" });
            DropIndex("dbo.CarModels", new[] { "CarMakeId" });
            DropTable("dbo.People");
            DropTable("dbo.Cars");
            DropTable("dbo.CarPurchases");
            DropTable("dbo.CarModels");
            DropTable("dbo.CarMakes");
        }
    }
}
