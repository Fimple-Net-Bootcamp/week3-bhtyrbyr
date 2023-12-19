using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.Exceptions
{
    public class NoRecordFoundException : Exception
    {
        public NoRecordFoundException(string Message) : base(Message)
        { }

        public NoRecordFoundException() : this("The data to be deleted does not exist in the database.")
        { }
    }
}

