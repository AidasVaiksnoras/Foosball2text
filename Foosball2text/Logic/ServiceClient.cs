using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Logic
{
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

        static public void AddGame(Game game)
        {
            client.PutAsJsonAsync($"api/CurrentGame/1", game);
        }

        static private void UpdateGame(Game game)
        {
            client.PutAsJsonAsync($"api/CurrentGame/2", game);
        }

        static public void OnScoreChanged(object sender, OnScoredEventArgs e)
        {
            UpdateGame(e.Game);
        }

        static public void InsertUser(User user)
        {
            client.PutAsJsonAsync($"api/User/1", user);
        }

        static public void UpdateUser(User user)
        {
            client.PutAsJsonAsync($"api/User/2", user);
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
