using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Domain
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }

    public interface IEntity : IEntity<string>
    {

    }
}
