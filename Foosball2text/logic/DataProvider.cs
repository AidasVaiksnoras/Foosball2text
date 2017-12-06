using System.Collections.Generic;
using System.Linq;
namespace Logic
{
    public class UsersDataProvider
    {
        public List<UserNONMODEL> UserList { get; set; }
        public UserNONMODEL LeftUser { get; set; }
        public UserNONMODEL RightUser { get; set; }

        public UsersDataProvider()
        {
            LeftUser = new UserNONMODEL();
            RightUser = new UserNONMODEL();
        }

        public UsersDataProvider(UserNONMODEL leftUser, UserNONMODEL rightUser)
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
            ServiceClient.PutToDb<UserNONMODEL>(LeftUser, Method.Update);
            ServiceClient.PutToDb<UserNONMODEL>(RightUser, Method.Update);
        }

        public UserNONMODEL AddUser(string name)
        {
            UserNONMODEL user = new UserNONMODEL();
            user.UserName = name;
            ServiceClient.PutToDb<UserNONMODEL>(user, Method.Insert);

            return user;
        }

        public UserNONMODEL GetUserData(string username)
        {
            List<UserNONMODEL> user = UserList.Where((x) => x.UserName == username).ToList();
            if (user.Count == 0)
                throw new UserNotFoundException("No user was found with Name: " + username, username);
            else
                return user[0]; 
        }
    }
}
