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
            Game activeGame;
            using (var db = new EFModel())
            {
                activeGame = db.Games.Where(g => g.LeftUserName == leftTeam && g.RightUserName == rightTeam && g.InProgress == true).First();
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

        //FIXME Does not update user somehow
        public void UpdateUser(User userToUpdate)
        {
            using (var db = new EFModel())
            {
                List<User> users = db.Users.Where(x => x.Username == userToUpdate.Username).ToList();
                if (users.Count() == 1)
                {
                    users[0] = userToUpdate;
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
            User user;
            using (var db = new EFModel())
            {
                user = db.Users.Where(x => x.Username == username).First();
            }
            return user;
        }


    }
}
