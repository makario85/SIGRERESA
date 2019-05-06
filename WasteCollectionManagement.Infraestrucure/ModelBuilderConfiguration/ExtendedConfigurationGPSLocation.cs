using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteCollectionManagement.Model.Models;

namespace System.Data.Entity
{
    public static class ExtendedConfigurationGPSLocation
    {
        public static void ConfiguratedGPSLocation(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GPSLocation>()
                .HasMany(t => t.PickUpLocations);
        }
    }
}
