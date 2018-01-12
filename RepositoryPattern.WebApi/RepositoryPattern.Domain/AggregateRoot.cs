using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Domain
{
    public  class AggregateRoot<TPrimaryKey> : Entity<TPrimaryKey>,IAggregateRoot<TPrimaryKey>
    {

    }
    public class AggregateRoot : AggregateRoot<string>, IAggregateRoot
    {

    }
}
