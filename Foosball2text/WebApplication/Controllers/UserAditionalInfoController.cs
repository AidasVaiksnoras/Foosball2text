using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Helpers;
using WebApplication.Models;
using System.Web.Script.Serialization;

namespace WebApplication.Controllers
{
    public class UserAditionalInfoController : ApiController
    {
        IDataProvider provider = new DataProviderEF();
        // GET: api/UserAditionalInfo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserAditionalInfo/5
        public double Get(string id)
        {
            return provider.GetUserAverageScore(id);
        }

        // POST: api/UserAditionalInfo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserAditionalInfo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserAditionalInfo/5
        public void Delete(int id)
        {
        }
    }
}
