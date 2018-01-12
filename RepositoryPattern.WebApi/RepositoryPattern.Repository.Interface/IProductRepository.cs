using RepositoryPattern.Domain;
using RepositoryPattern.Infrastructure.Specification;
using System.Collections.Generic;

namespace RepositoryPattern.Repository.Interface
{
    public interface IProductRepository:IRepository<Product,string>
    {
        Product FindOne(ISpecification<Product> sepecification);
        IEnumerable<Product> FindAll(ISpecification<Product> sepecification);
    }
}
