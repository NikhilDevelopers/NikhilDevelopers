using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.Model
{
    public class VMTypeengine
    {
        public int Id { get; set; }
        public string engineName { get; set; }
    }
    public class VMTypeengines
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public List<VMTypeengine> TypeEngine ;
    }
}
