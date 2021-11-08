using JsonOpertioninApi.Model;
using JsonOpertioninApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonOpertioninApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripVehicleController : ControllerBase
    {

        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {

            try
            {

                string input = s.Addjson(constantFile.TripVehicleList).ToString();
                VmTripVehicles DeVMTyreTypes = JsonConvert.DeserializeObject<VmTripVehicles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);


            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }


        }


        [HttpPost]
        public ActionResult Post(VmTripVehicle m)
        {
            var newModels = "{ 'id': " + m.id + ",'name': '" + m.userName + "','trip':" + m.trip + "}";

            try
            {

               

                string input = s.Addjson(constantFile.AddTripVehicle).ToString();

                VmTripVehicles DeVMModel = JsonConvert.DeserializeObject<VmTripVehicles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMModel, Formatting.Indented);

                return Ok(onString);


            }
            catch (Exception ex)
            {

                return new JsonResult("Add Error : " + ex.Message.ToString());
            }
            
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            try
            {

                
                string input = s.Addjson(constantFile.DeleteTripVehicle).ToString();

                VmTripVehicles DeVMModel = JsonConvert.DeserializeObject<VmTripVehicles>(input);

                string onString = JsonConvert.SerializeObject(DeVMModel, Formatting.Indented);

                return Ok(onString);

            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }

        }

    }
}
