using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Domain
{
    public class Product:AggregateRoot<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool IsNew { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
