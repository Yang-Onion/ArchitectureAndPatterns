using RepositoryPattern.Domain;
using RepositoryPattern.Infrastructure.Specification;
using RepositoryPattern.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repository
{
    public class CategoryRepository : BaseRepository<Category, int>, ICategoryRepository
    {
        public IEnumerable<Category> FindAll(ISpecification<Category> sepecification)
        {
            throw new NotImplementedException();
        }

        public Category FindOne(ISpecification<Category> sepecification)
        {
            throw new NotImplementedException();
        }
    }
}
