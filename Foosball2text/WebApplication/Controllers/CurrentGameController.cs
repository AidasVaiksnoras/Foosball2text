using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Helpers;
using WebApplication.Models;
using System.Web.Script.Serialization;

namespace WebApplication.Controllers
{
    public class CurrentGameController : ApiController
    {
        DataProvider provider = new DataProvider();
        // GET: api/CurrentGame
        public IEnumerable<string> Get()
        {
            return new string[] { new JavaScriptSerializer().Serialize(provider.GetCurrentGameData()) };
        }

        // GET: api/CurrentGame/5
        public string Get(int id)
        {
            return "";
        }

        // POST: api/CurrentGame
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CurrentGame/5
        public void Put(int id, [FromBody]Game value)
        {
            if (id == 1) 
                provider.InsertNewGame(value);
            else
                provider.UpdateGame(value);
        }

        // DELETE: api/CurrentGame/5
        public void Delete(int id)
        {
        }
    }
}
