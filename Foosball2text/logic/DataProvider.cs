using SQL_operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class UsersDataProvider
    {
        public List<User> Data { get; set; }
        public User LeftUser { get; set; }
        public User RightUser { get; set; }

        public UsersDataProvider()
        {
            Data = new List<User>();
            LeftUser = new User();
            RightUser = new User();
        }

        public void LoadData()
        {
            Data = SerializationHandler.ReadFromXML<User>();
        }

        public void SaveData()
        {
            SerializationHandler.WriteToXML<User>(Data);
        }

        public User AddUser(string name)
        {
            if (!Data.Any(x => x.UserName == name))
            {
                User user = new User(name);
                Data.Add(new User(name));
                return user;
            }
            else
                return GetUserData(name);
        }

        public User GetUserData(string name)
        {
            var users = Data.Where(x => x.UserName == name);
            if (users.Count() == 1)
                return users.Last();
            else if (users.Count() < 1)
                throw new UserNotFoundException(name);
            else //Multiple users found - return one
                return users.Last();
        }

        public void UpdateOldUser(User replacingUser)
        {
            var users = Data.Where(x => x.UserName == replacingUser.UserName);
            if (users.Count() < 1)
                throw new UserNotFoundException(replacingUser.UserName);
            //TODO add MultipleUsersFound exception
            var oldUser = users.Last();
            int oldUserIndex = Data.IndexOf(oldUser);

            Data[oldUserIndex] = replacingUser;
        }

    }
}
