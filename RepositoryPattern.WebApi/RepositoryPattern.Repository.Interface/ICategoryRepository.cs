using RepositoryPattern.Domain;
using RepositoryPattern.Infrastructure.Specification;
using System.Collections.Generic;

namespace RepositoryPattern.Repository.Interface
{
    public interface ICategoryRepository:IRepository<Category,int>
    {
        Category FindOne(ISpecification<Category> sepecification);
        IEnumerable<Category> FindAll(ISpecification<Category> sepecification);
    }
}
