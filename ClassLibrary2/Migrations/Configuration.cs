namespace WasteCollectionManagement.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WasteCollectionManagement.Infrastructure.DBContext;
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

            var BinTypesOrange = BinTypesBuilder.Create()
                                                          .ColouredOrange()
                                                          .WithDescription(BinTypesDescription.Orange.ToString())
                                                          .Build();

            var BinTypesYellow = BinTypesBuilder.Create()
                                                          .ColouredYellow()
                                                          .WithDescription(BinTypesDescription.Yellow.ToString())
                                                          .Build();

            var BinTypesBrown = BinTypesBuilder.Create()
                                                          .ColouredBrown()
                                                          .WithDescription(BinTypesDescription.Brown.ToString())
                                                          .Build();

            var BinTypesGreen = BinTypesBuilder.Create()
                                                          .ColouredGreen()
                                                          .WithDescription(BinTypesDescription.Green.ToString())
                                                          .Build();

            var BinTypesBlue = BinTypesBuilder.Create()
                                                          .ColouredBlue()
                                                          .WithDescription(BinTypesDescription.Blue.ToString())
                                                          .Build();

            var binTypes = new List<BinType>
            {
                BinTypesOrange,
                BinTypesYellow,
                BinTypesBrown,
                BinTypesBlue,
                BinTypesGreen,
            };
            if (!context.BinTypes.Any())
            {
                context.BinTypes.AddRange(binTypes);
            }

            var bin = new List<Bin>
            {
                Bin.Create(coordinates[0], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[0], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[0], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),false),
                Bin.Create(coordinates[1], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[1], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),false),
                Bin.Create(coordinates[1], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),true),
                Bin.Create(coordinates[2], binTypes.SingleOrDefault(ct => ct.Id == BinTypesGreen.Id),true),
                Bin.Create(coordinates[2], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBlue.Id),false),
                Bin.Create(coordinates[3], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[3], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[3], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),true),
                Bin.Create(coordinates[4], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),false),
                Bin.Create(coordinates[4], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[4], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),false),
                Bin.Create(coordinates[5], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[6], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[6], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[6], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),false),
                Bin.Create(coordinates[7], binTypes.SingleOrDefault(ct => ct.Id == BinTypesGreen.Id),false),
                Bin.Create(coordinates[7], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBlue.Id),false),
                Bin.Create(coordinates[8], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[9], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[9], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[9], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),false),
                Bin.Create(coordinates[10], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[10], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),false),
                Bin.Create(coordinates[10], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),false),
                Bin.Create(coordinates[11], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),false),
                Bin.Create(coordinates[11], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[11], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),true),
                Bin.Create(coordinates[12], binTypes.SingleOrDefault(ct => ct.Id == BinTypesGreen.Id),true),
                Bin.Create(coordinates[12], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBlue.Id),true),
                Bin.Create(coordinates[13], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[14], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[14], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[14], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),true),
                Bin.Create(coordinates[15], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[15], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),false),
                Bin.Create(coordinates[15], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),false),
                Bin.Create(coordinates[16], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),true),
                Bin.Create(coordinates[16], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),true),
                Bin.Create(coordinates[16], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),true),
                Bin.Create(coordinates[17], binTypes.SingleOrDefault(ct => ct.Id == BinTypesOrange.Id),false),
                Bin.Create(coordinates[17], binTypes.SingleOrDefault(ct => ct.Id == BinTypesYellow.Id),false),
                Bin.Create(coordinates[17], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBrown.Id),false),
                Bin.Create(coordinates[18], binTypes.SingleOrDefault(ct => ct.Id == BinTypesGreen.Id),true),
                Bin.Create(coordinates[18], binTypes.SingleOrDefault(ct => ct.Id == BinTypesBlue.Id),true),
            };
            if (!context.Bin.Any())
            {
                context.Bin.AddRange(bin);
            }

            context.SaveChanges();
        }
    }
}
