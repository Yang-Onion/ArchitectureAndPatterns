using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Domain
{
    public abstract class Entity<TPrimaryKey>:IEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }

    public abstract class Entity : Entity<string>, IEntity
    {

    }
}
