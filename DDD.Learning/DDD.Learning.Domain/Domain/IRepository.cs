using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain.Domain
{
    public interface IRepository<AggregateRoot,IdType>:IReadOnlyRepository<AggregateRoot,IdType> where  AggregateRoot :IAggregateRoot
    {
        void Insert(AggregateRoot aggregate);
        void Delete(AggregateRoot aggregate);
        void Update(AggregateRoot aggregate);
    }
}
