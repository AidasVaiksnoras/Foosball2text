﻿using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Helpers;
using WebApplication.Models;
using System.Web.Script.Serialization;

namespace WebApplication.Controllers
{
    public class GameController : ApiController
    {
        DataProvider provider = new DataProvider();
        // GET: api/Game
        public IEnumerable<string> Get()
        {
            string[] gameList = new string[] { };
            try
            {
                 gameList = new string[] { new JavaScriptSerializer().Serialize(provider.GetCurrentGameData()) };
            }
            catch (EmptyGameListExeption e)
            {
                gameList = null;
            }
            return gameList;
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

        // PUT: api/Game/5
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
