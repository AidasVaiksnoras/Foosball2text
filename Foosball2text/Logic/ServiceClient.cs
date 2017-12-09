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

            //TODO remove test
            WebApplication.Controllers.GameController gc = new WebApplication.Controllers.GameController();
            gc.Get(string1, string2);

            var response = client.GetAsync(apiString).Result; //FIXME
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                string responseString = responseContent.ReadAsStringAsync().Result;

                gameFromDb = JsonConvert.DeserializeObject<Game>(responseString);
            }
            else
                throw new HttpRequestException("Uri \"" + apiString + "\" did not return a result");


                return gameFromDb;
        }

        static public void OnScoreChanged(object sender, OnScoredEventArgs e)
        {
            PutToDb<Game>(e.Game, Method.Update);
        }

        static public async Task<List<UserNONMODEL>> GetAllUsers()
        {
            HttpResponseMessage msg = await client.GetAsync($"api/User").ConfigureAwait(false); ;
            List<UserNONMODEL> list = null;
            if (msg.IsSuccessStatusCode)
            {
                list = await msg.Content.ReadAsAsync<List<UserNONMODEL>>();
            }
            return list;
        }
    }
}
