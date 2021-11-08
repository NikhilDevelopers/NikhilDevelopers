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
    public class ProfileController : ControllerBase
    {
        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {

            try
            {

                string input = s.Addjson(constantFile.ProfileDetail).ToString();

                VmProfiles Profiles = JsonConvert.DeserializeObject<VmProfiles>(input.ToString());
               
                string onString = JsonConvert.SerializeObject(Profiles, Formatting.Indented);

                return Ok(onString);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }
       
        [HttpPost("AddVehicle")]
        public ActionResult Post(VmVechileInfo m)
        {
            //var newModels = "{ 'id': " + m.id + ",'name': '" + m.Name + "','manufactureId':" + m.manufactureid + "}";
            try
            {
                string input = s.Addjson(constantFile.AddVechile).ToString();

                VmProfiles DeVMModel = JsonConvert.DeserializeObject<VmProfiles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMModel, Formatting.Indented);

                return Ok(onString);


            }
            catch (Exception ex)
            {

                return new JsonResult("Add Error : " + ex.Message.ToString());
            }
            
        }

        [HttpDelete("deleteVehicle/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {

               
                string input = s.Addjson(constantFile.DeleteVechile).ToString();


                VmProfiles DeVMModel = JsonConvert.DeserializeObject<VmProfiles>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMModel, Formatting.Indented);

                return Ok(onString);
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }

        }

        [HttpGet("NearchargeStation/{Lat}")]
        public ActionResult GetNearPowerstation(string Lat)
        {

            try
            {

                string input = s.Addjson(constantFile.NearPowerStation).ToString();

                VmChargeStations ChargeStation = JsonConvert.DeserializeObject<VmChargeStations>(input.ToString());

                string onString = JsonConvert.SerializeObject(ChargeStation, Formatting.Indented);

                return Ok(onString);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }

        [HttpGet("GetNearPowerstationFromTo/{From}/{To}")]
        public ActionResult GetNearPowerstationFromTo(string From,string To)
        {

            try
            {

                string input = s.Addjson(constantFile.NearPowerStationFromTo).ToString();

                VmChargeStations ChargeStation = JsonConvert.DeserializeObject<VmChargeStations>(input.ToString());

                string onString = JsonConvert.SerializeObject(ChargeStation, Formatting.Indented);

                return Ok(onString);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }
    }
}
