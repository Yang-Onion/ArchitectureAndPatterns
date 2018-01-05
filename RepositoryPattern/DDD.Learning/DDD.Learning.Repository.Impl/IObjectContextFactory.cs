using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Repository.Memory
{
    public interface IObjectContextFactory
    {
        InMemoryDatabaseObjectContext Create();
    }
}
