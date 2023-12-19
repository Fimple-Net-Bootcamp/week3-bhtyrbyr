using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.Wrappers
{
    public class ServiceCreateResponse : BaseResponse
    {
        public string ServicesName { get; set; }

        public ServiceCreateResponse(string servicesName, string Message) : base(Message)
        {
            ServicesName = servicesName;
        }
    }
}
