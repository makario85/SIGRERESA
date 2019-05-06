namespace WasteCollectionManagement.Model.Models
{
    public class Bin
    {
        public Bin()
        {
        }
        public int Id { get; set; }

        public bool CollectionReady { get; set; }

        public int GPSLocationId { get; set; }
        public GPSLocation GPSLocation { get; set; }


        public int BinTypeId { get; set; }
        public BinType BinType { get; set; }

        public static Bin Create(GPSLocation gpsLocation, BinType binTypes, bool collectionReady)
        {
            return new Bin
            {
                GPSLocation = gpsLocation,
                BinType = binTypes,
                CollectionReady = collectionReady,
            };
        }
    }
}
