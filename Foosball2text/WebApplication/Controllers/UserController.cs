using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Models;
using WebApplication.Helpers;
namespace WebApplication.Controllers
{
    public class UserController : ApiController
    {
        DataProvider _dataProvider = new DataProvider();
        // GET: api/User
        public IEnumerable<User> Get()
        {
            List<User> list = _dataProvider.GetUsers();
            return list;
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]User value)
        {
            if (id == 1)
                _dataProvider.InsertUser(value);
            else if (id == 2)
                _dataProvider.UpdateUser(value);
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
