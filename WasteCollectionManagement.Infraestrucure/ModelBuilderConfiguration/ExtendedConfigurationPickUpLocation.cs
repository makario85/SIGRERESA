using WasteCollectionManagement.Model.Models;

namespace System.Data.Entity
{
    public static class ExtendedConfigurationPickUpLocation
    {
        public static void ConfiguratedPickUpLocation(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PickUpLocation>()
                .Property(x => x.TypeContainerId)
                .IsRequired();
        }
    }
}
