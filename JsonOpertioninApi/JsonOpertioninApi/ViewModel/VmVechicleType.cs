using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.Model
{
    public class VmVechicleType
    {
        public int id { get; set; }
        public string vechicleType { get; set; }
    }

    public class VMvechicleTypes
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public List<VmVechicleType> vechicleType;
    }
}
