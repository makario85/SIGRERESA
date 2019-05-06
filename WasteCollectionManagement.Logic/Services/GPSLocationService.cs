using System.Collections.Generic;
using System.Linq;
using WasteCollectionManagement.Model.Models;
using System.Data.Entity;

namespace WasteCollectionManagement.Logic.Services
{
    public class GPSLocationService
    {
        private DbSet<GPSLocation> Repository { get; set; }

        public ICollection<GPSLocation> GetAll()
        {
            return Repository
                .Select(x => x)
                .Include(p => p.Bins)
                .ToList();
        }
    }
}
