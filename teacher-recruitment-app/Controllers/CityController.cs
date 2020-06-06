using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using teacher_recruitment_app.Models;

namespace teacher_recruitment_app.Controllers
{
    public class CityController : ApiController
    {
        private Database database;

        public CityController()
        {
            database = new Database();
        }

        // GET api/values
        public IEnumerable<City> Get()
        {
            return database.Cities.ToList();
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
