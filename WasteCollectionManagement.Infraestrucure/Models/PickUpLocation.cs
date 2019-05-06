using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteCollectionManagement.Model.Models
{
    public class PickUpLocation
    {
        public int Id { get; set; }

        public bool ReadyToGetCollected { get; set; }

        public ContainerType TypeContainer { get; set; }

        public GPSLocation LocationGPS { get; set; }

        public int TypeContainerId { get; set; }

        public static PickUpLocation Create(GPSLocation gpsLocation, ContainerType typeContainer, bool readyToGetCollected)
        {
            return new PickUpLocation
            {
                LocationGPS = gpsLocation,
                TypeContainer = typeContainer,
                ReadyToGetCollected = readyToGetCollected,
            };
        }
    }
}
