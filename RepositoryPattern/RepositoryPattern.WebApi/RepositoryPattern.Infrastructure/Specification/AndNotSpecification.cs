using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Infrastructure.Specification
{
    public class AndNotSpecification<T>:CompositeSpecification<T>
    {
        private readonly ISpecification<T> _leftCondition;
        private readonly ISpecification<T> _rightCondition;
        public AndNotSpecification(ISpecification<T> leftCondition, ISpecification<T> rightCondition)
        {
            _leftCondition = leftCondition;
            _rightCondition = rightCondition;
        }
        public override bool IsSatisfiedBy(T candidate)
        {
            return (_leftCondition.IsSatisfiedBy(candidate) && _rightCondition.IsSatisfiedBy(candidate)) != true;
        }

    }
}
