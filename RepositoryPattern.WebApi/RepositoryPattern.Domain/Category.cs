using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Domain
{
    public class Category:AggregateRoot<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
