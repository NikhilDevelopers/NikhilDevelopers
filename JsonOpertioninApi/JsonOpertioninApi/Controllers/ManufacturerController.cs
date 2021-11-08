using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JsonOpertioninApi.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace JsonOpertioninApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {

           
            try
            {

                
                //JObject json = JObject.Parse(s.Addjson(constantFile.Manufacturername).ToString());
                string input = s.Addjson(constantFile.ManufacturerList).ToString();
                //object stjson = json["manufacturer"];
              
                VMManufacturerRes Demanufacturer = JsonConvert.DeserializeObject<VMManufacturerRes>(input.ToString());
               // var Demanufacturers = JsonConvert.DeserializeObject<List<VMManufacturer>>(stjson.ToString());
                string  onString = JsonConvert.SerializeObject(Demanufacturer, Formatting.Indented);

                //var report = (VMManufacturer)Newtonsoft.Json.JsonConvert.DeserializeObject(stjson.ToString(), typeof(VMManufacturer));
                // string jsonString  = JsonConvert.SerializeObject(Manufacturer,Formatting.Indented);







                // Deserialize
                // var obj = JsonSerializer.Deserialize<VMManufacturer>(jsonString);

                //foreach (var item in jsonObj["manufacturer"])
                //{
                //    Manufacturer = new Manufacturer
                //    {
                //        id = Convert.ToInt32(item["id"].ToString()),

                //        Name = item["name"].ToString(),

                //    };
                //    jsonString = jsonString+ Newtonsoft.Json.JsonConvert.SerializeObject(Manufacturer);

                //}

                //j = JsonConvert.DeserializeObject<Manufacturer>(ManufacturerList.ToString()).ToString();

                //return Ok(json);




                // return Ok(Manufacturer);
                //return Ok(user);
                return Ok(onString);
            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }
        [HttpPost]
        public ActionResult Post(VMManufacturer m)
        {
            var newmanufacturer = "{ 'id': " + m.id + ",'name': '" + m.Name + "'}";
            //var newmanufacturer = "{ 'statusCode': 200,'statusMessage': 'Ok','manufacturer': [{ 'id': " + m.id + ",'name': '" + m.Name + "'}]}";

            try
            {
                // var json = File.ReadAllText(jsonFile);
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.Manufacturername).ToString());
                //var jsonObj = JObject.Parse(jsonObjs);
                //dynamic jsonObj = JsonConvert.DeserializeObject(jsonObjs);
                //var manufacturer = jsonObj.GetValue("manufacturer") as JArray;
                //var Addmanufacturer = JObject.Parse(newmanufacturer);
                //manufacturer.Add(Addmanufacturer);

                //jsonObj["manufacturer"] = manufacturer;
                //string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                //                       Newtonsoft.Json.Formatting.Indented);

                //System.IO.File.WriteAllText(@"D:\Nikhil Pro\JsonOpertioninApi\JsonOpertioninApi\wwwroot\MasterData\Manufacturer\ManufacturerList.json", newJsonResult);



              
                string input = s.Addjson(constantFile.AddManufacturerList).ToString();
              
                VMManufacturerRes Demanufacturer = JsonConvert.DeserializeObject<VMManufacturerRes>(input.ToString());
                
                string onString = JsonConvert.SerializeObject(Demanufacturer, Formatting.Indented);

                return  Ok(onString);

            }
            catch (Exception ex)
            {

                return Ok("Add Error : " + ex.Message.ToString());
            }
           
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            try
            {

                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.ManufacturerDelete).ToString());

               
                string input = s.Addjson(constantFile.DeleteManufacturerList).ToString();
               

                VMManufacturerRes Demanufacturer = JsonConvert.DeserializeObject<VMManufacturerRes>(input.ToString());
               
                string onString = JsonConvert.SerializeObject(Demanufacturer, Formatting.Indented);

                return Ok(onString);
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
            // return new JsonResult(Response.StatusCode + id +"Delete Sucessfully");
        }

        [HttpPut]

        public ActionResult Update(VMManufacturer m)
        {
            try
            {
                var newmanufacturer = "{ 'id': " + m.id + ",'name': '" + m.Name + "'}";
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.UpdateManufacturerList).ToString());


              
                string input = s.Addjson(constantFile.UpdateManufacturerList).ToString();
                
                VMManufacturerRes Demanufacturer = JsonConvert.DeserializeObject<VMManufacturerRes>(input.ToString());
               
                string onString = JsonConvert.SerializeObject(Demanufacturer, Formatting.Indented);

                return Ok(onString);

               
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
        }
    }
}
