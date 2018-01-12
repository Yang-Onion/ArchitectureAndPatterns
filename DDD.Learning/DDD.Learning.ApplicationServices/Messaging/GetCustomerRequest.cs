using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices.Messaging
{
    public class GetCustomerRequest:IntegerIdRequest
    {
        public GetCustomerRequest(int customerId) : base(customerId)
        {
        }
    }

}
