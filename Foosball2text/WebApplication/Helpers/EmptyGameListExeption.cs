using System;

namespace WebApplication.Helpers
{
    public class EmptyGameListExeption : Exception
    {
        public EmptyGameListExeption() : base() { }
        public EmptyGameListExeption(string message) : base(message) { }
    }
}