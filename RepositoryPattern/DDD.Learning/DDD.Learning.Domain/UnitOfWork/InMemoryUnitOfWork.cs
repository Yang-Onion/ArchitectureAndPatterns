using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace DDD.Learning.Domain.UnitOfWork
{
    public class InMemoryUnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<IAggregateRoot, IUnitOfWorkRepository> _insertedAggreates;
        private readonly Dictionary<IAggregateRoot, IUnitOfWorkRepository> _updatedAggreates;
        private readonly Dictionary<IAggregateRoot, IUnitOfWorkRepository> _deletedAggreates;

        public InMemoryUnitOfWork()
        {
            _insertedAggreates = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            _updatedAggreates = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            _deletedAggreates = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
        }

       

        public void RegisterDeletion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository)
        {
            if (!_deletedAggreates.ContainsKey(aggregateRoot))
            {
                _deletedAggreates.Add(aggregateRoot, repository);

            }
        }

        public void RegisterInsertion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository)
        {
            if (!_insertedAggreates.ContainsKey(aggregateRoot))
            {
                _insertedAggreates.Add(aggregateRoot, repository);
            }
        }

        public void RegisterUpdate(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository)
        {
            if (!_updatedAggreates.ContainsKey(aggregateRoot))
            {
                _updatedAggreates.Add(aggregateRoot,repository);
            }
        }

        public void Commit()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (IAggregateRoot aggreateRoot in _insertedAggreates.Keys)
                {
                    _insertedAggreates[aggreateRoot].
                }
                foreach (IAggregateRoot aggreateRoot in _deletedAggreates.Keys)
                {
                    _deletedAggreates[aggreateRoot]
                }
                foreach (IAggregateRoot aggreateRoot in _deletedAggreates.Keys)
                {
                    _updatedAggreates[aggreateRoot]
                }
            }
            
        }
    }
}
