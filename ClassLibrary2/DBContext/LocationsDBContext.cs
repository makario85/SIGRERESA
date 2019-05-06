using WasteCollectionManagement.Model.Models;
using System.Data.Entity;


namespace WasteCollectionManagement.Infrastructure.DBContext
{
    public class LocationsDBContext : DbContext
    {
        public LocationsDBContext()
        {
        }

        public DbSet<GPSLocation> GPSLocation { get; set;}
        public DbSet<BinType> BinTypes { get; set; }
        public DbSet<Bin> Bin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.ConfiguratedGPSLocation();
            modelBuilder.ConfiguratedBinsType();
            modelBuilder.ConfiguratedBins();
        }
    }
}
