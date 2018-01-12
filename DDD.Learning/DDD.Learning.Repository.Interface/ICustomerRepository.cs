using DDD.Learning.Domain;
using DDD.Learning.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Repository.Interface
{
    public interface ICustomerRepository: IRepository<Customer,int>
    {

    }
}
