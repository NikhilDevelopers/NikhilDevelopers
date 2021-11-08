using JsonOpertioninApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.ViewModel
{
    public class VmProfile
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public List<VmVechileInfo> vechicles;
    }

    public class VmVechileInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        
        public string color { get; set; }
        public int Regno { get; set; }
        public string insuranceExpDate { get; set; }
        public VMManufacturer manufacturer;
        public VMModels model;
        public VmVechicleType vechicleType;
        public  VMTypeengine typeEngine;
    }

    public class VmProfiles
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public VmProfile owner;
    }


}
