using WasteCollectionManagement.Model.Models;

namespace System.Data.Entity
{
    public static class ExtendedConfigurationBinsType
    {
        public static void ConfiguratedBinsType(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinType>()
                .Property(e => e.Id)
                .HasDatabaseGeneratedOption(ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
