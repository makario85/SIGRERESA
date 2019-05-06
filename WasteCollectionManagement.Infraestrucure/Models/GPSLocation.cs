using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteCollectionManagement.Model.Models
{
    public class GPSLocation
    {
        public int Id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public GPSLocation (int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public ICollection<PickUpLocation> PickUpLocations { get; set; }
    }
}