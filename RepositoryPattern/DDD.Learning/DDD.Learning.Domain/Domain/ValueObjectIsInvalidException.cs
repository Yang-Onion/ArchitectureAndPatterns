using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Learning.Domain
{
    public class ValueObjectIsInvalidException:Exception
    {
        public ValueObjectIsInvalidException(string message) : base(message)
        {

        }
    }
}
