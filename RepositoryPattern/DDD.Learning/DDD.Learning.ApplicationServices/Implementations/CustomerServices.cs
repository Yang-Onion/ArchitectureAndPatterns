using System;
using System.Collections.Generic;
using System.Text;
using DDD.Learning.ApplicationServices.Messaging;
using DDD.Learning.Domain;
using DDD.Learning.Domain.UnitOfWork;
using DDD.Learning.Repository.Interface;

namespace DDD.Learning.ApplicationServices.Implementations
{
    public class CustomerServices : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerServices(ICustomerRepository customerRepository,IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException();
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException();
        }
        public DeleteCustomerResponse DeleteCustomer(DeleteCustomerRequest deleteCustomerRequest)
        {
            throw new NotImplementedException();
        }

        public GetCustomersResponse GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public GetCustomerResponse GetCustomer(GetCustomerRequest getCustomerRequest)
        {
            var getCustomerResponse = new GetCustomerResponse();
            Customer customer = null;
            try
            {
                customer = _customerRepository.FindById(getCustomerRequest.Id);
                if (customer == null)
                {
                    getCustomerResponse.Exception = new Exception("");
                }
                else
                {
                    getCustomerResponse.Customer = customer.ConvertToViewModel();
                }
            }
            catch (Exception ex)
            {
                getCustomerResponse.Exception =ex;
            }
            return getCustomerResponse;
        }

        public InsertCustomerResponse InsertCustomer(InsertCustomerRequest insertCustomerRequest)
        {
            throw new NotImplementedException();
        }

        public UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest updateCustomerRequest)
        {
            throw new NotImplementedException();
        }
    }
}
