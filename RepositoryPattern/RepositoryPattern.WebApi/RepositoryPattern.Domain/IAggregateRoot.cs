using System;

namespace RepositoryPattern.Domain
{
    public interface IAggregateRoot<TPrimaryKey>:IEntity<TPrimaryKey>
    {
    }
    public interface IAggregateRoot : IAggregateRoot<string>, IEntity
    {

    }
}
