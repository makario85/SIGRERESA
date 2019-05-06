using System.Collections.Generic;
using System.Linq;
using WasteCollectionManagement.Model.Models;
using System.Data.Entity;

namespace WasteCollectionManagement.Logic.Services
{
    class CollectionReadyService
    {
        private DbSet<Bin> Repository { get; set; }

        public ICollection<Bin> GetAll()
        {
            return Repository
                .Where(p => p.CollectionReady)
                .Select(x => x)
                .ToList();
        }
    }
}
