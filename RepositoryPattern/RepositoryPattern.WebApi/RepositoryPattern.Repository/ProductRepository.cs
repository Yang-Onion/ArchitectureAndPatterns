using RepositoryPattern.Domain;
using RepositoryPattern.Infrastructure.Specification;
using RepositoryPattern.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repository
{
    public class ProductRepository : BaseRepository<Product, string>, IProductRepository
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id=Guid.NewGuid().ToString(),Name=""},
            new Product{Id=Guid.NewGuid().ToString(),Name=""}
        };
        public IEnumerable<Product> FindAll(ISpecification<Product> sepecification)
        {
            throw new NotImplementedException();
        }

        public Product FindOne(ISpecification<Product> sepecification)
        {
            throw new NotImplementedException();
        }
    }
}
