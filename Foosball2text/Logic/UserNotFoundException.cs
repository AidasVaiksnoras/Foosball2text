using System;

namespace Logic
{
    public class UserNotFoundException : Exception
    {
        public string UserName { get; set; }
        public UserNotFoundException() : base() { }
        public UserNotFoundException(string message, string userName) : base(message)
        {
            UserName = userName;
        }
    }
}
