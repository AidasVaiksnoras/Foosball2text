using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Helpers;
using WebApplication.Models;
using System.Web.Script.Serialization;

namespace WebApplication.Controllers
{
    public class GameController : ApiController
    {
        IDataProvider provider = new DataProviderEF();
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        // GET: api/Game
        public IEnumerable<string> Get()
        {
            string[] gameList = new string[] { };
            try
            {
                 gameList = new string[] { serializer.Serialize(provider.GetActiveGame()) };
            }
            catch (EmptyGameListExeption e)
            {
                gameList = null;
            }
            return gameList;
        }

        [Route("api/Game/{leftname}/{rightname}")]
        public string Get(string leftName, string rightName)
        {
            Game gameEntity;
            try
            {
                gameEntity = provider.GetCurrentGame(leftName, rightName);
            }
            catch (EmptyGameListExeption e)
            {
                gameEntity = null;
            }

            var json = serializer.Serialize(gameEntity);

            return json;
        }

        // GET: api/Game/5
        public string Get(int id)
        {
            return "";
        }

        // POST: api/Game
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Game/???
        public void Put(int id, [FromBody]Game value)
        {
            if (id == 1) 
                provider.InsertNewGame(value);
            else
                provider.UpdateGame(value);
        }

        // DELETE: api/Game/5
        public void Delete(int id)
        {
        }
    }
}
