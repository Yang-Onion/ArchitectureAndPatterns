using RepositoryPattern.Domain;
using RepositoryPattern.Infrastructure;

namespace RepositoryPattern.Repository.Interface
{
    public interface ICustomerRepository:IRepository<Customer,string>
    {
        Customer FindByName(string name);
    }
}
