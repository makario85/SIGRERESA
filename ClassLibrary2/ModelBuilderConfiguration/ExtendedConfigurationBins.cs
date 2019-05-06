using WasteCollectionManagement.Model.Models;

namespace System.Data.Entity
{
    public static class ExtendedConfigurationBins
    {
        public static void ConfiguratedBins(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bin>()
                .Property(x => x.BinTypeId)
                .IsRequired();
            modelBuilder.Entity<Bin>()
                .Property(x => x.GPSLocationId)
                .IsRequired();
        }
    }
}
