using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterUpdate(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);
        void RegisterInsertion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);

        void RegisterDeletion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);

        void Commit();
    }
}
