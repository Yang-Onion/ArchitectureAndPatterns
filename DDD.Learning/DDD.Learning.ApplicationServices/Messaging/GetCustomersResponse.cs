using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices.Messaging
{
    public class GetCustomersResponse : ServiceResponseBase
    {
        public IEnumerable<CustomerViewModel> Customers { get; set; }
    }
}
