using System.Collections.Generic;
using System.Linq;
namespace Logic
{
    public class UsersDataProvider
    {
        public List<User> UserList { get; set; }
        public User LeftUser { get; set; }
        public User RightUser { get; set; }

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
            ServiceClient.PutToDb<User>(LeftUser, Method.Update);
            ServiceClient.PutToDb<User>(RightUser, Method.Update);
        }

        public User AddUser(string name)
        {
            User user = new User();
            user.UserName = name;
            ServiceClient.PutToDb<User>(user, Method.Insert);

            return user;
        }

        public User GetUserDataFromLocalList(string username)
        {
            List<User> user = UserList.Where((x) => x.UserName == username).ToList();
            if (user.Count == 0)
                throw new UserNotFoundException("No user was found with Name: " + username, username);
            else
                return user[0]; 
        }
    }
}
