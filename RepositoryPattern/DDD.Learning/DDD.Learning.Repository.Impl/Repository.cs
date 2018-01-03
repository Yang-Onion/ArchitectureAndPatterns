using DDD.Learning.Domain;
using DDD.Learning.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Repository.Impl
{
    public abstract class Repository<DomainType,IdType,DatabaseType>: IUnitOfWorkRepository where DomainType:IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new AccessViolationException("Unit of work can not be null");
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
