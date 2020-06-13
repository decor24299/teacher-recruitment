using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using teacher_recruitment_app.Models;
using teacher_recruitment_app.Utilities;

namespace teacher_recruitment_app.Controllers
{
    public class CitiesController : ApiController
    {
        private Database database;

        public CitiesController()
        {
            database = new Database();
        }

        // GET api/values
        public JsonResult<List<City>> Get(string fields)
        {
            var serializableProperties = PropertiesUtilities.GetSerializableProperties(fields);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new ShouldSerializeContractResolver(serializableProperties)
            };

            return Json(database.Cities.ToList(), settings);
        }

        // GET api/values/5
        public City Get(int id)
        {
            return database.Cities.FirstOrDefault(city => city.Id == id);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
