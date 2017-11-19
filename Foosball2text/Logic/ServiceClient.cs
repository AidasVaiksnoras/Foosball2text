using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            client.PutAsJsonAsync($"api/" + apiString, instance);
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
