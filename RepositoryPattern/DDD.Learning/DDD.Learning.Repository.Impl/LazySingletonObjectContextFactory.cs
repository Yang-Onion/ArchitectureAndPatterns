using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Repository.Memory
{
    public class LazySingletonObjectContextFactory : IObjectContextFactory
    {
        public InMemoryDatabaseObjectContext Create()
        {
            throw new NotImplementedException();
        }
    }
}
