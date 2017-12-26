using RepositoryPattern.Domain;
using RepositoryPattern.Repository.Interface;
using System;

namespace RepositoryPattern.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool Delete(Customer aggregate)
        {
            throw new NotImplementedException();
        }

        public Customer FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public string Insert(Customer aggregate)
        {
            throw new NotImplementedException();
        }

        public Customer Query(string id)
        {
            throw new NotImplementedException();
        }

        public Customer Query(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer aggregate)
        {
            throw new NotImplementedException();
        }

    }
}
