using JsonOpertioninApi.Model;
using JsonOpertioninApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {

           
            try
            {

              
               // dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.vechicleList).ToString());
                string input = s.Addjson(constantFile.vechicleList).ToString();
                VmVehicles DeVMTyreTypes = JsonConvert.DeserializeObject<VmVehicles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);



                //return Ok(jsonObj);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }
        [HttpPost]
        public ActionResult Post(VmVehicles m)
        {
           
          
            try
            {
                //  var newmanufacturer = "{ 'id': " + m.id + ",'name': '" + m.Name + ",'typeEngine:'" + m.typeEngine + "','Manufacturer':" + m.manufacturer + ",'model':" + m.model + ",'tyreType':" + m.tyreType + "}";
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.Addvechicle).ToString());

                // return Ok(jsonObj);

                string input = s.Addjson(constantFile.vechicleList).ToString();
                VmVehicles DeVMTyreTypes = JsonConvert.DeserializeObject<VmVehicles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);
            }
            catch (Exception ex)
            {

                return new JsonResult("Add Error : " + ex.Message.ToString());
            }
           // return new JsonResult(Response.StatusCode + "Add Sucessfully");
            
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            try
            {
               
               // dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.DeletevechicleList).ToString());
                string input = s.Addjson(constantFile.DeletevechicleList).ToString();
                VmVehicles DeVMTyreTypes = JsonConvert.DeserializeObject<VmVehicles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);
                //return Ok(jsonObj);
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
           
        }

        [HttpPut]

        public ActionResult Update(VmVehicles m)
        {
            try
            {
                 //var newmanufacturer = "{ 'id': " + m.id + ",'name': '" + m.Name + ",'typeEngine:'" + m.typeEngine + "','Manufacturer':" + m.manufacturer + ",'model':" + m.model + ",'tyreType':" + m.tyreType + "}";
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.UpdatevechicleList).ToString());
                string input = s.Addjson(constantFile.UpdatevechicleList).ToString();
                VmVehicles DeVMTyreTypes = JsonConvert.DeserializeObject<VmVehicles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);
                //return Ok(jsonObj);
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
        }

    }
}
