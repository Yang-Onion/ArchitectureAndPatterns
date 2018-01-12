using DDD.Learning.ApplicationServices.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices
{
    public interface ICustomerService
    {
        GetCustomerResponse GetCustomer(GetCustomerRequest getCustomerRequest);
        GetCustomersResponse GetAllCustomers();
        InsertCustomerResponse InsertCustomer(InsertCustomerRequest insertCustomerRequest);
        UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest updateCustomerRequest);
        DeleteCustomerResponse DeleteCustomer(DeleteCustomerRequest deleteCustomerRequest);
    }
}
