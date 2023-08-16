using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    internal class CustomerAdult : CompositeSpecification<Customer>
    {
        public override bool IsSatisfiedBy(Customer item)
        {
            return item.Age >= 18;
        }
    }

    internal class CustomerNotTooOld : CompositeSpecification<Customer>
    {
        public override bool IsSatisfiedBy(Customer item)
        {
            return item.Age < 90;
        }
    }

    internal class CustomerStartWithM : CompositeSpecification<Customer>
    {
        public override bool IsSatisfiedBy(Customer item)
        {
            return item.Firstname.StartsWith("M");
        }
    }

    internal class CustomerIsAdmin : CompositeSpecification<Customer>
    {
        public override bool IsSatisfiedBy(Customer item)
        {
            return item.IsAdmin == true;
        }
    }
}
