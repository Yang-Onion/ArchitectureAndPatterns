using DDD.Learning.Domain;
using DDD.Learning.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Repository.Memory
{
    public abstract class Repository<DomainType,IdType,DatabaseType>: IUnitOfWorkRepository where DomainType:IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IObjectContextFactory _objectContextFactory;
        public Repository(IUnitOfWork unitOfWork,IObjectContextFactory objectContextFactory)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException("Unit of work can not be null");
            _objectContextFactory = objectContextFactory ?? throw new ArgumentNullException("Object context factory can not be null");
        }

        public void PersistInsertion(IAggregateRoot aggregateRoot)
        {

        }
        public void PersistUpdate(IAggregateRoot aggregateRoot)
        {

        }
        public void PersistDeletion(IAggregateRoot aggregateRoot)
        {

        }

    }
}
