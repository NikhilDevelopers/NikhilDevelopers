using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.ViewModel
{
    public class VmOwner
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<VmVehicle> vechicles;


    }

    public class VmOwners
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }
        public List<VmOwner> owner ;

    }
}
