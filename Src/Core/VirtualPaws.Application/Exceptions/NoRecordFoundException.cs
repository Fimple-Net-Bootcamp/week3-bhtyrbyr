using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.Exceptions
{
    public class NoRecordFoundException : Exception
    {
        public NoRecordFoundException(string RepoName) : base($"Data is not available in the repository of entity {RepoName}.")
        { }

        public NoRecordFoundException() : this("The data does not exist in the database.")
        { }
    }
}

