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
    public class OwnerController : ControllerBase
    {
        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {


            try
            {

                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.OwnerList).ToString());

                string input = s.Addjson(constantFile.OwnerList).ToString();

                VmOwners DeVmOwners = JsonConvert.DeserializeObject<VmOwners>(input.ToString());
                //List<VmOwners> DeVmOwners = JsonConvert.DeserializeObject<List<VmOwners>>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVmOwners, Formatting.Indented);

                return Ok(onString);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }
        [HttpPost]
        public ActionResult Post(VmOwners m)
        {


            try
            {
                
                //var newmanufacturer = "{ 'id': " + m.id + ",'name': '" + m.Name + ",'vechicleName:'" + m.vechicleName + "}";
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.AddOwner).ToString());
                string input = s.Addjson(constantFile.AddOwner).ToString();

                VmOwners DeVmOwners = JsonConvert.DeserializeObject<VmOwners>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVmOwners, Formatting.Indented);

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

                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.DeleteOwner).ToString());
                string input = s.Addjson(constantFile.DeleteOwner).ToString();

                VmOwners DeVmOwners = JsonConvert.DeserializeObject<VmOwners>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVmOwners, Formatting.Indented);

                return Ok(onString);
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }

        }

        [HttpPut]

        public ActionResult Update(VmOwners m)
        {
            try
            {

                 //var newmanufacturer = "{ 'id': " + m.id + ",'name': '" + m.Name + ",'vechicleName:'" + m.vechicleName + "}";
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.UpdateOwner).ToString());

                string input = s.Addjson(constantFile.UpdateOwner).ToString();

                VmOwners DeVmOwners = JsonConvert.DeserializeObject<VmOwners>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVmOwners, Formatting.Indented);

                return Ok(onString);
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
        }
    }
}
