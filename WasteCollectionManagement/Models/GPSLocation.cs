using System.Collections.Generic;

namespace WasteCollectionManagement.Model.Models
{
    public class GPSLocation
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int GPSLocationId { get; set; }
        
        public ICollection<Bin> Bins { get; set; }

        public GPSLocation()
        { }

        public GPSLocation (int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}