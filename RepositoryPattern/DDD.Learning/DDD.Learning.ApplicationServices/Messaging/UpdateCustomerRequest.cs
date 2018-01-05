using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices.Messaging
{
    public class UpdateCustomerRequest : IntegerIdRequest
    {
        public UpdateCustomerRequest(int customerId) : base(customerId)
        {

        }
        public CustomerPropertiesViewModel CustomerProperties { get; set; }
    }
}
