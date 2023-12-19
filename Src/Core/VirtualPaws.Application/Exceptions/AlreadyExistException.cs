using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.Exceptions
{
    public class AlreadyExistException : Exception
    {
        public AlreadyExistException(string Message): base(Message)
        {}

        public AlreadyExistException() : this("The data to be saved is already in the database.")
        {}
    }
}
