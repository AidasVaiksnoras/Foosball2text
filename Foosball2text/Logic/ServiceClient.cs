using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Models;
using Newtonsoft.Json;

namespace Logic
{
    public enum Method { Insert, Update};
    public static class ServiceClient
    {
        static HttpClient client = new HttpClient();
        static private StringBuilder stringBuilder = new StringBuilder();

        static ServiceClient()
        {
            client.BaseAddress = new Uri("http://localhost:63526/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static public void PutToDb<T>(T instance, Method method)
        {
            string apiString = instance.GetType().Name;      

            switch (method)
            {
                case Method.Insert:
                {
                    apiString += "/1";
                    break;
                }
                case Method.Update:
                {
                    apiString += "/2";
                    break;
                }
            }
            client.PutAsJsonAsync($"api/" + apiString, instance); //NOTE: make sure the Type of the instance and controller match
        }

        static public Game GetCurrentGameFromDbAsync(string string1, string string2)
        {
            string apiString = "api/Game";
            apiString += "/" + string1 + "/" + string2;

            Game gameFromDb = null;

            //FIXME wont work without creating a GameController (SOMETIMES throws 'internal server error')
            WebApplication.Controllers.GameController gc = new WebApplication.Controllers.GameController();
            var testReturn = gc.Get(string1, string2);
            gameFromDb = JsonConvert.DeserializeObject<Game>(testReturn);
            /*using (client)
            {
                var response = client.GetAsync(apiString).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    gameFromDb = (Game)serializer.DeserializeObject(responseString);
                }
                else
                    throw new HttpRequestException("Uri \"" + apiString + "\" has returned an error: " + response.StatusCode);
            }*/

            return gameFromDb;
        }

        static public void OnScoreChanged(object sender, OnScoredEventArgs e)
        {
            PutToDb<Game>(e.Game, Method.Update);
        }

        static public async Task<List<User>> GetAllUsers()
        {
            HttpResponseMessage msg = await client.GetAsync($"api/User").ConfigureAwait(false); ;
            List<User> list = null;
            if (msg.IsSuccessStatusCode)
            {
                list = await msg.Content.ReadAsAsync<List<User>>();
            }
            return list;
        }
    }
}
