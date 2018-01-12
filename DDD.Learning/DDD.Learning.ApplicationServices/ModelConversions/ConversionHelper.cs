using DDD.Learning.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.ApplicationServices
{
    public static class ConversionHelper
    {
        public static CustomerViewModel ConvertToViewModel(this Customer customer)
        {
            return new CustomerViewModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                Province = customer.CustomerAddress.Province,
                City = customer.CustomerAddress.City,
                County = customer.CustomerAddress.County,
                District = customer.CustomerAddress.District,
                Town = customer.CustomerAddress.Town,
                PostalCode = customer.CustomerAddress.PostalCode
            };
        }
        public static IEnumerable<CustomerViewModel> ConvertToViewModels(this IEnumerable<Customer> customers)
        {
            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            foreach (Customer customer in customers)
            {
                customerViewModels.Add(customer.ConvertToViewModel());
            }
            return customerViewModels;
        }

    }
}
