namespace WasteCollectionManagement.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WasteCollectionManagement.Model.DBContext;
    using WasteCollectionManagement.Model.Models;

    public sealed class Configuration : DbMigrationsConfiguration<LocationsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LocationsDBContext context)
        {
            var coordinates = new List<GPSLocation>
            {
                new GPSLocation (20,54),
                new GPSLocation (23,54),
                new GPSLocation (25,54),
                new GPSLocation (27,54),
                new GPSLocation (35,54),
                new GPSLocation (42,54),
                new GPSLocation (46,60),
                new GPSLocation (48,65),
                new GPSLocation (50,65),
                new GPSLocation (58,65),
                new GPSLocation (2,30),
                new GPSLocation (4,34),
                new GPSLocation (6,34),
                new GPSLocation (12,80),
                new GPSLocation (18,80),
                new GPSLocation (25,80),
                new GPSLocation (25,84),
                new GPSLocation (25,90),
                new GPSLocation (25,99),
            };
            if (!context.GPSLocation.Any())
            {
                context.GPSLocation.AddRange(coordinates);
            }
            
            var containerTypeOrange = ContainerTypeBuilder.Create()
                                                          .ColouredOrange()
                                                          .WithDescription(ContainerTypeDescription.Orange.ToString())
                                                          .Build();

            var containerTypeYellow = ContainerTypeBuilder.Create()
                                                          .ColouredYellow()
                                                          .WithDescription(ContainerTypeDescription.Yellow.ToString())
                                                          .Build();

            var containerTypeBrown = ContainerTypeBuilder.Create()
                                                          .ColouredBrown()
                                                          .WithDescription(ContainerTypeDescription.Brown.ToString())
                                                          .Build();

            var containerTypeGreen = ContainerTypeBuilder.Create()
                                                          .ColouredGreen()
                                                          .WithDescription(ContainerTypeDescription.Green.ToString())
                                                          .Build();

            var containerTypeBlue = ContainerTypeBuilder.Create()
                                                          .ColouredBlue()
                                                          .WithDescription(ContainerTypeDescription.Blue.ToString())
                                                          .Build();

            var containerType = new List<ContainerType>
            {
                containerTypeOrange,
                containerTypeYellow,
                containerTypeBrown,
                containerTypeBlue,
                containerTypeGreen,
            };
            if (!context.ContainerType.Any())
            {
                context.ContainerType.AddRange(containerType);
            }
            
            var pickuplocations = new List<PickUpLocation>
            {
                PickUpLocation.Create(coordinates[0], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[0], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[0], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),false),
                PickUpLocation.Create(coordinates[1], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[1], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),false),
                PickUpLocation.Create(coordinates[1], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),true),
                PickUpLocation.Create(coordinates[2], containerType.SingleOrDefault(ct => ct.Id == containerTypeGreen.Id),true),
                PickUpLocation.Create(coordinates[2], containerType.SingleOrDefault(ct => ct.Id == containerTypeBlue.Id),false),
                PickUpLocation.Create(coordinates[3], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[3], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[3], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),true),
                PickUpLocation.Create(coordinates[4], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),false),
                PickUpLocation.Create(coordinates[4], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[4], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),false),
                PickUpLocation.Create(coordinates[5], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[6], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[6], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[6], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),false),
                PickUpLocation.Create(coordinates[7], containerType.SingleOrDefault(ct => ct.Id == containerTypeGreen.Id),false),
                PickUpLocation.Create(coordinates[7], containerType.SingleOrDefault(ct => ct.Id == containerTypeBlue.Id),false),
                PickUpLocation.Create(coordinates[8], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[9], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[9], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[9], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),false),
                PickUpLocation.Create(coordinates[10], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[10], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),false),
                PickUpLocation.Create(coordinates[10], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),false),
                PickUpLocation.Create(coordinates[11], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),false),
                PickUpLocation.Create(coordinates[11], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[11], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),true),
                PickUpLocation.Create(coordinates[12], containerType.SingleOrDefault(ct => ct.Id == containerTypeGreen.Id),true),
                PickUpLocation.Create(coordinates[12], containerType.SingleOrDefault(ct => ct.Id == containerTypeBlue.Id),true),
                PickUpLocation.Create(coordinates[13], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[14], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[14], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[14], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),true),
                PickUpLocation.Create(coordinates[15], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[15], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),false),
                PickUpLocation.Create(coordinates[15], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),false),
                PickUpLocation.Create(coordinates[16], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),true),
                PickUpLocation.Create(coordinates[16], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),true),
                PickUpLocation.Create(coordinates[16], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),true),
                PickUpLocation.Create(coordinates[17], containerType.SingleOrDefault(ct => ct.Id == containerTypeOrange.Id),false),
                PickUpLocation.Create(coordinates[17], containerType.SingleOrDefault(ct => ct.Id == containerTypeYellow.Id),false),
                PickUpLocation.Create(coordinates[17], containerType.SingleOrDefault(ct => ct.Id == containerTypeBrown.Id),false),
                PickUpLocation.Create(coordinates[18], containerType.SingleOrDefault(ct => ct.Id == containerTypeGreen.Id),true),
                PickUpLocation.Create(coordinates[18], containerType.SingleOrDefault(ct => ct.Id == containerTypeBlue.Id),true),
            };
            if (!context.PickUpLocation.Any())
            {
                context.PickUpLocation.AddRange(pickuplocations);
            }

            context.SaveChanges();
        }
    }
}
