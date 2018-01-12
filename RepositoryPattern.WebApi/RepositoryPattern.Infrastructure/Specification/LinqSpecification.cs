using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Infrastructure.Specification
{
    public abstract class LinqSpecification<T> : CompositeSpecification<T>
    {
        public abstract Expression<Func<T, bool>> AsExpression();
        public override bool IsSatisfiedBy(T candidate)
        {
            return AsExpression().Compile()(candidate);
        }
    }
}
