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
            UserList = _ro.GetAllUserData();
        }

        public void CommitBothTeamsData()
        {
            _wo.UpdateUserPlayData(LeftUser);
            _wo.UpdateUserPlayData(RightUser);
        }

        public User AddUser(string name)
        {
            _wo.InsertNewUser(name);

            return _ro.GetUsersData(name);
        }
    }
}
