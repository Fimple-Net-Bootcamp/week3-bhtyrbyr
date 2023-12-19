using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.Wrappers
{
    public abstract class BaseResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; } = true;
        public BaseResponse(string Message)
        {
            this.Message = Message;    
        }
    }
}
