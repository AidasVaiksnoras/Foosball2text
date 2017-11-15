using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
namespace Logic
{
    public class ServiceClient
    {
        static HttpClient client = new HttpClient();
        private StringBuilder stringBuilder = new StringBuilder();
        public ServiceClient()
        {
            client.BaseAddress = new Uri("http://localhost:63526/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void AddGame(Game game)
        {
            client.PutAsJsonAsync($"api/CurrentGame/1", game);
        }

        private void UpdateGame(Game game)
        {
            client.PutAsJsonAsync($"api/CurrentGame/2", game);
        }

        public void OnScoreChanged(object sender, OnScoredEventArgs e)
        {
            UpdateGame(e.Game);
        }
    }
}
