using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.Model
{
    public class VMModels
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int manufactureid { get; set; }
    }


    public class VMModel
    {

        public int statusCode { get; set; }
        public string statusMessage { get; set; }
        public List<VMModels> Model;
    }
}
