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
    public class ModelController : ControllerBase
    {
        Helper s = new Helper();
        [HttpGet]
        public ActionResult Get()
        {

            try
            {

                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.ModelList).ToString());




                string input = s.Addjson(constantFile.ModelList).ToString();

                VMModel DeVMModel = JsonConvert.DeserializeObject<VMModel>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMModel, Formatting.Indented);

                return Ok(onString);

               // return Ok(jsonObj);

            }
            catch (Exception ex)
            {

                return new JsonResult(null);
            }
        }
        [HttpPost]
        public ActionResult Post(VMModels m)
        {
            var newModels = "{ 'id': " + m.id + ",'name': '" + m.Name + "','manufactureId':" +m.manufactureid +"}";
           
            try
            {
               
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.ModelList).ToString());
                
                //var model = jsonObj.GetValue("model") as JArray;
                //var Addmmodel = JObject.Parse(newModels);
                //model.Add(Addmmodel);
               

                //jsonObj["model"] = model;
                //string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                //                       Newtonsoft.Json.Formatting.Indented);

                //System.IO.File.WriteAllText(@"D:\Nikhil Pro\JsonOpertioninApi\JsonOpertioninApi\wwwroot\MasterData\Model\ModelList.json", newJsonResult);


                string input = s.Addjson(constantFile.AddModelList).ToString();

                VMModel DeVMModel = JsonConvert.DeserializeObject<VMModel>(input.ToString());

                string onString = JsonConvert.SerializeObject(DeVMModel, Formatting.Indented);

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

                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.DeleteModel).ToString());

                string input = s.Addjson(constantFile.DeleteModelList).ToString();

                VMModel DeVMModel = JsonConvert.DeserializeObject<VMModel>(input);

                string onString = JsonConvert.SerializeObject(DeVMModel, Formatting.Indented);

                return Ok(onString);

            }
            catch (Exception ex)
            {

                return Ok("error:" + null);
            }
          
        }

        [HttpPut]

        public ActionResult Update(VMModels m)
        {
            try
            {
                var newModels = "{ 'id': " + m.id + ",'name': '" + m.Name + "','manufactureId':" + m.manufactureid + "}";
                //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(s.Addjson(constantFile.UpdateModel).ToString());

                string input = s.Addjson(constantFile.UpdateModel).ToString();

                VMModel DeVMModel = JsonConvert.DeserializeObject<VMModel>(input.ToString());

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
