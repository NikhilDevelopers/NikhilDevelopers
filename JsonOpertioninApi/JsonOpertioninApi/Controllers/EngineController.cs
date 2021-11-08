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
    public class EngineController : ControllerBase
    {
        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {


            try
            {


                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.EngineList).ToString());
                string input = s.Addjson(constantFile.EngineList).ToString();

                VMTypeengines DeVMTyreTypes = JsonConvert.DeserializeObject<VMTypeengines>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);


                //return Ok(jsonObj);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }

        public ActionResult Get1()
        {


            try
            {


                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.EngineList).ToString());
                string input = s.Addjson(constantFile.EngineList).ToString();

                VMTypeengines DeVMTyreTypes = JsonConvert.DeserializeObject<VMTypeengines>(input.ToString());

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
        public ActionResult Post(VMTypeengine t)
        {
            var newTypeengine = "{ 'id': " + t.Id + ",'engineName': '" + t.engineName + "'}";

            try
            {

                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.EngineList).ToString());

                //var newTypeengines = jsonObj.GetValue("typeEngine") as JArray;
                //var AddnewTypeengines = JObject.Parse(newTypeengine);
                //newTypeengines.Add(AddnewTypeengines);

                //jsonObj["typeEngine"] = newTypeengines;
                //string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                //                       Newtonsoft.Json.Formatting.Indented);

                //System.IO.File.WriteAllText(@"D:\Nikhil Pro\JsonOpertioninApi\JsonOpertioninApi\wwwroot\MasterData\Engine\TypeEngineList.json", newJsonResult);
                string input = s.Addjson(constantFile.AddEngineList).ToString();

                VMTypeengines DeVMTyreTypes = JsonConvert.DeserializeObject<VMTypeengines>(input.ToString());

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

               // dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.EngineDelete).ToString());
                string input = s.Addjson(constantFile.EngineDelete).ToString();

                VMTypeengines DeVMTyreTypes = JsonConvert.DeserializeObject<VMTypeengines>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMTyreTypes, Formatting.Indented);

                return Ok(onString);
                //return Ok(jsonObj);
            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
            // return new JsonResult(Response.StatusCode + id +"Delete Sucessfully");
        }

        [HttpPut]

        public ActionResult Update(VMTypeengine t)
        {
            try
            {
                var newTypeengine = "{ 'id': " + t.Id + ",'engineName': '" + t.engineName + "'}";
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.UpdateEngine).ToString());
                string input = s.Addjson(constantFile.UpdateEngine).ToString();

                VMTypeengines DeVMTyreTypes = JsonConvert.DeserializeObject<VMTypeengines>(input.ToString());

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
