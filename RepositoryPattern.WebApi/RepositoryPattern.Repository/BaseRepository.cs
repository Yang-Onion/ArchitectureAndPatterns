using System;
using System.Collections.Generic;
using System.Text;
using RepositoryPattern.Domain;

namespace RepositoryPattern.Repository
{
    public  class BaseRepository<T, TPrimarykey> 
    {
        public bool Delete(T aggregateRoot)
        {
            throw new NotImplementedException();
        }

        public TPrimarykey Insert(T aggregateRoot)
        {
            throw new NotImplementedException();
        }

        public T Query(TPrimarykey id)
        {
            throw new NotImplementedException();
        }

        public IEquatable<T> QueryAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(T aggregateRoot)
        {
            throw new NotImplementedException();
        }
    }
}
