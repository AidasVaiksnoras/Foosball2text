using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.Helpers
{
    interface IDataProvider
    {
        void InsertNewGame(Game game);
        Game GetCurrentGame(string leftTeam, string rightTeam);
        Game GetActiveGame();
        void UpdateGame(Game game);
        void InsertUser(User user);
        void UpdateUser(User userToUpdate);
        List<User> GetUsers();
        User GetUser(string username);
        List<Game> GetLastGames(int number);
        List<User> GetUserCompetitors(string UserName);
        double GetUserAverageScore(string UserName);
    }
}
