using DDD.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        CommandResponse Commit();
    }
}
