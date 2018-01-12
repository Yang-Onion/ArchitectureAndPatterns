using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Infrastructure.Specification
{
    public class AddSpecification<T>: CompositeSpecification<T>
    {
        private readonly ISpecification<T> _leftCondition;
        private readonly ISpecification<T> _rightCondition;
        public AddSpecification(ISpecification<T> leftCondition, ISpecification<T> rightCondition)
        {
            _leftCondition = leftCondition;
            _rightCondition = rightCondition;
        }
        public override bool IsSatisfiedBy(T candidate)
        {
            return _leftCondition.IsSatisfiedBy(candidate) && _rightCondition.IsSatisfiedBy(candidate);
        }
    }
}
