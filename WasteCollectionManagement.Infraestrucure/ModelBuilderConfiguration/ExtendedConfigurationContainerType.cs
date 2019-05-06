using WasteCollectionManagement.Model.Models;

namespace System.Data.Entity
{
    public static class ExtendedConfigurationContainerType
    {
        public static void ConfiguratedContainerType(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContainerType>()
                .Property(e => e.Id)
                .HasDatabaseGeneratedOption(ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}
