using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    internal interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
    }

    internal abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T item);
        public CompositeSpecification<T> And(ISpecification<T> other) => new AndSpecification<T>(this, other);
        public CompositeSpecification<T> Or(ISpecification<T> other) => new OrSpecification<T>(this, other);
    }

    internal class AndSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _right = right;
            _left = left;
        }

        public override bool IsSatisfiedBy(T item)
        {
            return _right.IsSatisfiedBy(item) && _left.IsSatisfiedBy(item);
        }
    }

    internal class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;

        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _right = right;
            _left = left;
        }

        public override bool IsSatisfiedBy(T item)
        {
            return _right.IsSatisfiedBy(item) || _left.IsSatisfiedBy(item);
        }
    }
}
