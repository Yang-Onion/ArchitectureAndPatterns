using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices.Messaging
{
    public class GetCustomerResponse : ServiceResponseBase
    {
        public CustomerViewModel Customer { get; set; }
    }
}
