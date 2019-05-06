﻿using WasteCollectionManagement.Model.Models;

namespace System.Data.Entity
{
    public static class ExtendedConfigurationGPSLocation
    {
        public static void ConfiguratedGPSLocation(this DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GPSLocation>()
                .HasMany(t => t.Bins);
        }
    }
}