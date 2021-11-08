using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.Model
{
    public class VMManufacturer
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    public class VMManufacturerRes
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public List<VMManufacturer> manufacturer;
    }
}
