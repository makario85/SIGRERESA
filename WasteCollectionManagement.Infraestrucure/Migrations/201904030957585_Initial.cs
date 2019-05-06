namespace WasteCollectionManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContainerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GPSLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        x = c.Int(nullable: false),
                        y = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickUpLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReadyToGetCollected = c.Boolean(nullable: false),
                        TypeContainerId = c.Int(nullable: false),
                        LocationGPS_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContainerTypes", t => t.TypeContainerId, cascadeDelete: true)
                .ForeignKey("dbo.GPSLocations", t => t.LocationGPS_Id)
                .Index(t => t.TypeContainerId)
                .Index(t => t.LocationGPS_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PickUpLocations", "LocationGPS_Id", "dbo.GPSLocations");
            DropForeignKey("dbo.PickUpLocations", "TypeContainerId", "dbo.ContainerTypes");
            DropIndex("dbo.PickUpLocations", new[] { "LocationGPS_Id" });
            DropIndex("dbo.PickUpLocations", new[] { "TypeContainerId" });
            DropTable("dbo.PickUpLocations");
            DropTable("dbo.GPSLocations");
            DropTable("dbo.ContainerTypes");
        }
    }
}
