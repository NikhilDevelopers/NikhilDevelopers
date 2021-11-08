using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.ViewModel
{
    public class VmChargeStation
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string lat { get; set; }
    }
    public class VmChargeStations
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public List<VmChargeStation> ChargeStation;

    }
}
