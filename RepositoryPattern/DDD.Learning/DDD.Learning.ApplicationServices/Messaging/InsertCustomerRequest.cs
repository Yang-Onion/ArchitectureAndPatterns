using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices.Messaging
{
    public class InsertCustomerRequest : ServiceRequestBase
    {
        public CustomerPropertiesViewModel CustomerProperties { get; set; }
    }
}
