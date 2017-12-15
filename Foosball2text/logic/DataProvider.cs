using System.Collections.Generic;
using System.Linq;
namespace Logic
{
    public class UsersDataProvider
    {
        public List<User> UserList { get; set; }
        public User LeftUser { get; set; }
        public User RightUser { get; set; }

        private WebApplication.Helpers.DataProviderEF _database = new WebApplication.Helpers.DataProviderEF();

        public UsersDataProvider()
        {
            LeftUser = new User();
            RightUser = new User();
        }

        public UsersDataProvider(User leftUser, User rightUser)
        {
            LeftUser = leftUser;
            RightUser = rightUser;
        }

        public void LoadData()
        {
            UserList = ServiceClient.GetAllUsers().Result;
        }

        public void CommitBothTeamsData()
        {
            //TODO add check if it NEEDS to be updated
            ServiceClient.PutToDb<User>(LeftUser, Method.Update);
            ServiceClient.PutToDb<User>(RightUser, Method.Update);
        }

        public User AddUser(string name)
        {
            User user = new User(name);

            ServiceClient.PutToDb<User>(user, Method.Insert);

            return user;
        }

        public User GetUserData(string username) //Used only in user info form
        {
            List<User> user = UserList.Where((x) => x.UserName == username).ToList();
            if (user.Count == 0)
                throw new UserNotFoundException("No user was found with Name: " + username, username);
            else
                return user[0]; 
        }

        public bool UserExistsInDb(string username)
        {
            return _database.UserExists(username);
        }

        public User GetUserFromDb(string username)
        {
            var dbUser = _database.GetUser(username);
            User localTypeUser = new User(dbUser.Username, dbUser.GamesPlayed, dbUser.GamesWon, dbUser.MaxSpeed, dbUser.TotalGoals, dbUser.TimePlayed, dbUser.RankPoints);
            return localTypeUser;
        }
    }
}
