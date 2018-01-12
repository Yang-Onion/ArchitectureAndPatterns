using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain
{
    public static class CustomerBusinessRule
    {
        public static readonly BusinessRule CustomerNameRequired = new BusinessRule("A customer must have a name");
    }
}
