using System.Collections.Generic;
using WebApplication.Models;
using System.Linq;

namespace WebApplication.Helpers
{
    public class DataProviderEF : IDataProvider
    {
        public void InsertNewGame(Game game)
        {
            using (var db = new EFModel())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }
        }

        public Game GetCurrentGame(string leftTeam, string rightTeam)
        {
            Game activeGame = new Game();
            using (var db = new EFModel())
            {
                List < Game > list = db.Games.Where(g => g.LeftUserName == leftTeam && g.RightUserName == rightTeam && g.InProgress == true).ToList();
                if (list.Count()>0)
                    activeGame = list.First();
            }
            return activeGame;
        }

        public Game GetActiveGame()
        {
            Game game;
            using (var db = new EFModel())
            {
                var result = db.Games.ToList().Last();
                game = result;
            }
            return game;
        }

        public void UpdateGame(Game game)
        {
            using (var db = new EFModel())
            {
                db.Entry(game).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void InsertUser(User user)
        {
            using (var db = new EFModel())
            {
                if (db.Users.Where(x => x.Username == user.Username).Count() == 0)
                {
                db.Users.Add(user);
                db.SaveChanges();
                }
            }
        }

        public void UpdateUser(User userToUpdate)
        {
            using (var db = new EFModel())
            {
                List<User> users = db.Users.Where(x => x.Username == userToUpdate.Username).ToList();
                if (users.Count() == 1)
                {
                    users[0].TotalGoals += userToUpdate.TotalGoals;
                    users[0].GamesPlayed += userToUpdate.GamesPlayed;
                    users[0].GamesWon += userToUpdate.GamesWon;
                    users[0].MaxSpeed = users[0].MaxSpeed > userToUpdate.MaxSpeed ? users[0].MaxSpeed : userToUpdate.MaxSpeed;
                    db.Entry(users[0]).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public List<User> GetUsers()
        {
            List<User> data = new List<User>();
            using (var db = new EFModel())
            {
                data = db.Users.ToList();
            }
            return data;
        }

        public User GetUser(string username)
        {
            User user = new User();
            using (var db = new EFModel())
            {
                List<User> data = db.Users.Where(x => x.Username == username).ToList();
                if (data.Count() > 0)
                    user = data[0];
            }
            return user;
        }

        public List<Game> GetLastGames(int number)
        {
            List<Game> data;
            using (var db = new EFModel())
            {
                data = db.Games.OrderBy(x => x.Id).Skip(db.Games.ToList().Count() - number).Take(number).ToList();
            }
            return data;
        }

        public List<User> GetUserCompetitors(string UserName)
        {
            List<User> list = new List<User>();
            using (var db = new EFModel())
            {
                var leftUsers = from games in db.Games
                                join users in db.Users on games.LeftUserName equals users.Username
                                where games.RightUserName == UserName
                                select users;

                var rightUsers = from games in db.Games
                                join users in db.Users on games.RightUserName equals users.Username
                                where games.LeftUserName == UserName
                                select users;

                list = leftUsers.Union(rightUsers).GroupBy(x => x.Username).Select(x =>x.FirstOrDefault()).ToList();
            }
            return list;
        }
        public double GetUserAverageScore(string UserName)
        {
            double average = 0;
            using (var db = new EFModel())
            {
                var rightUsers = from games in db.Games
                                where games.RightUserName == UserName
                                select new { user = UserName, score = games.RightScore };
                var leftUsers = from games in db.Games
                                 where games.LeftUserName == UserName
                                 select new { user = UserName, score = games.LeftScore };

                average = leftUsers.Union(rightUsers).Average(x => x.score);
            }
            return average;
        }
    }
}