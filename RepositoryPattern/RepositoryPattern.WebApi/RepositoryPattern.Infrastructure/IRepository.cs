using RepositoryPattern.Domain;
using System;

namespace RepositoryPattern.Infrastructure
{
    public interface IRepository<AggregateRoot,IdType> where AggregateRoot : IAggregateRoot<IdType>
    {
        IdType Insert(AggregateRoot aggregateRoot);
        bool Delete(AggregateRoot aggregateRoot);

        bool Update(AggregateRoot aggregateRoot);
        AggregateRoot Query(IdType id);

    }
}
