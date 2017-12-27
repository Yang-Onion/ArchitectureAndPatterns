using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Infrastructure.Specification
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _wrapped;
        private readonly ISpecification<T> _rightCondition;
        public NotSpecification(ISpecification<T> wrapped)
        {
            _wrapped = wrapped;
        }
        public override bool IsSatisfiedBy(T candidate)
        {
            return  !_wrapped.IsSatisfiedBy(candidate);
        }
    }
}
