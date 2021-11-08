using JsonOpertioninApi.Model;
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
    public class VechicleTypeController : ControllerBase
    {
        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {

           
            try
            {

              
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.TyreList).ToString());
                string input = s.Addjson(constantFile.VechicleTypeList).ToString();

                VMvechicleTypes DeVMTyreTypes = JsonConvert.DeserializeObject<VMvechicleTypes>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);




               // return Ok(jsonObj);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }
        [HttpPost]
        public ActionResult Post(VmVechicleType t)
        {
            var newtyreName = "{ 'id': " + t.id + ",'tyreName': '" + t.vechicleType + "'}";
            
            try
            {
               
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.TyreList).ToString());
                
                //var newtyre = jsonObj.GetValue("tyreType") as JArray;
                //var AddnewtyreName = JObject.Parse(newtyreName);
                //newtyre.Add(AddnewtyreName);

                //jsonObj["tyreType"] = newtyre;
                //string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                //                       Newtonsoft.Json.Formatting.Indented);

                //System.IO.File.WriteAllText(@"D:\Nikhil Pro\JsonOpertioninApi\JsonOpertioninApi\wwwroot\MasterData\Tyre\TyreTypeList.json", newJsonResult);

                string input = s.Addjson(constantFile.AddVechicleTypeList).ToString();

                VMvechicleTypes DeVMTyreTypes = JsonConvert.DeserializeObject<VMvechicleTypes>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);



            }
            catch (Exception ex)
            {

                return new JsonResult("Add Error : " + ex.Message.ToString());
            }
            //return new JsonResult(Response.StatusCode + "Add Sucessfully");
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            try
            {

                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.TyreDelete).ToString());

                string input = s.Addjson(constantFile.DeletevechicleType).ToString();

                VMvechicleTypes DeVMTyreTypes = JsonConvert.DeserializeObject<VMvechicleTypes>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);

            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
            // return new JsonResult(Response.StatusCode + id +"Delete Sucessfully");
        }

        [HttpPut]

        public ActionResult Update(VmVechicleType t)
        {
            try
            {
                var newtyreName = "{ 'id': " + t.id + ",'tyreName': '" + t.vechicleType + "'}";
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.UpdateTyre).ToString());
                string input = s.Addjson(constantFile.UpdatevechicleType).ToString();

                VMvechicleTypes DeVMTyreTypes = JsonConvert.DeserializeObject<VMvechicleTypes>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);
               
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
        }
    }
}
