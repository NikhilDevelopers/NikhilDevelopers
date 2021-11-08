using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.Model
{
    public class Helper
    {
        public object Addjson(string File)
        {
           
            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{File }");
            var JSON = System.IO.File.ReadAllText(folderDetails);

            //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(JSON);
            return JSON;
        }
       
    }
}
