using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Models;
using WebApplication.Helpers;

namespace WebApplication.Controllers
{
    public class UserController : ApiController
    {
        DataProviderEF _dataProvider = new DataProviderEF();
        // GET: api/User
        public IEnumerable<User> Get()
        {
            List<User> list = _dataProvider.GetUsers();
            return list;
        }

        // GET: api/User/5
        public User Get(string id)
        {
            return _dataProvider.GetUser(id);
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]User value)
        {
            value.TimePlayed = "0000-00-00T00:00:00Z";
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
