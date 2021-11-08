using JsonOpertioninApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.ViewModel
{
    public class VmVehicle
    {
        public int id { get; set; }
        public string Name { get; set; }
        public VMManufacturer manufacturer;
        public VMModels model;
        public VmVechicleType vechicleType;
        public VMTypeengine typeEngine;
    }
   

    public class VmVehicles
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public List<VmVehicle> vechicles;
    }
}
