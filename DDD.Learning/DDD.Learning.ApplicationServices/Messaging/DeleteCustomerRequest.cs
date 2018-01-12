using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices.Messaging
{
    public class DeleteCustomerRequest:IntegerIdRequest
    {
        public DeleteCustomerRequest(int customerId) : base(customerId)
        {

        }
    }

}
