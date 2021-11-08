using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.ViewModel
{
    public class VmTripVehicle
    {
        public int id { get; set; }
        public string userName { get; set; }

        public List<VmTrip> trip;
    }

    public class VmTrip
    {
        public int id { get; set; }
        public string sourceName { get; set; }

        public string destinationName { get; set; }
        public string sLat { get; set; }
        public string sLog { get; set; }
        public string dLat { get; set; }
        public string dLog { get; set; }

        public int vechileId { get; set; }
    }

    public class VmTripVehicles
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public List<VmTripVehicle> TripVehicle;
    }
}
