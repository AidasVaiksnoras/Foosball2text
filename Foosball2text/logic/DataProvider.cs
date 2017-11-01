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
        public List<User> UserList { get; set; }
        public User LeftUser { get; set; }
        public User RightUser { get; set; }

        private ReadOperations _ro = new ReadOperations();
        private WriteOperations _wo = new WriteOperations();

        public UsersDataProvider()
        {
            UserList = new List<User>();
            LeftUser = new User();
            RightUser = new User();
        }

        public void LoadData()
        {
            UserList = _ro.GetAllUserData();
        }

        public void CommitData()
        {
            _wo.UpdateUserPlayData(LeftUser);
            _wo.UpdateUserPlayData(RightUser);
        }

        public User AddUser(string name)
        {
            if (!_wo.UserExists(name))
                _wo.InsertNewUser(name);

            return _ro.GetUsersData(name);
        }

        //TODO remove the following
        public User GetUserData(string name)
        {
            var users = UserList.Where(x => x.UserName == name);
            if (users.Count() == 1)
                return users.Last();
            else if (users.Count() < 1)
                throw new UserNotFoundException(name);
            else //Multiple users found - return one
                return users.Last();
        }

        public void UpdateOldUser(User replacingUser)
        {
            var users = UserList.Where(x => x.UserName == replacingUser.UserName);
            if (users.Count() < 1)
                throw new UserNotFoundException(replacingUser.UserName);
            var oldUser = users.Last();
            int oldUserIndex = UserList.IndexOf(oldUser);

            UserList[oldUserIndex] = replacingUser;
        }

    }
}
