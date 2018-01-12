using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain.Domain
{
    public interface IReadOnlyRepository<AggregateRoot,IdType> where AggregateRoot:IAggregateRoot
    {
        AggregateRoot FindById(IdType id);
        IEnumerable<AggregateRoot> FindAll();
    }
}
