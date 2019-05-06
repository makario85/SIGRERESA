namespace WasteCollectionManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CollectionReady = c.Boolean(nullable: false),
                        GPSLocationId = c.Int(nullable: false),
                        BinTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BinTypes", t => t.BinTypeId, cascadeDelete: true)
                .ForeignKey("dbo.GPSLocations", t => t.GPSLocationId, cascadeDelete: true)
                .Index(t => t.GPSLocationId)
                .Index(t => t.BinTypeId);
            
            CreateTable(
                "dbo.BinTypes",
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
                        X = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        GPSLocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bins", "GPSLocationId", "dbo.GPSLocations");
            DropForeignKey("dbo.Bins", "BinTypeId", "dbo.BinTypes");
            DropIndex("dbo.Bins", new[] { "BinTypeId" });
            DropIndex("dbo.Bins", new[] { "GPSLocationId" });
            DropTable("dbo.GPSLocations");
            DropTable("dbo.BinTypes");
            DropTable("dbo.Bins");
        }
    }
}
