using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_operations
{
    [Serializable()]
    public class MultipleUsersFoundException : Exception
    {
        public MultipleUsersFoundException() : base() { }
        public MultipleUsersFoundException(string message) : base(message) { }
        public MultipleUsersFoundException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected MultipleUsersFoundException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
