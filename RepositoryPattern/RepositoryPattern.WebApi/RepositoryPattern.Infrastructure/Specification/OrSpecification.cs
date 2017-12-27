using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Infrastructure.Specification
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _leftCondition;
        private readonly ISpecification<T> _rightCondition;
        public OrSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            _leftCondition = leftSpecification;
            _rightCondition = rightSpecification;
        }
        public override bool IsSatisfiedBy(T candidate)
        {
            return _leftCondition.IsSatisfiedBy(candidate) || _rightCondition.IsSatisfiedBy(candidate);
        }
    }
}
