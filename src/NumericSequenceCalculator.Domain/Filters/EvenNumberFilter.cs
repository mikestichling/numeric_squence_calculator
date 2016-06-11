using System;
using System.Collections.Generic;
using System.Linq;

namespace NumericSequenceCalculator.Domain.Filters
{
    public class EvenNumberFilter : NumberProcessor
    {
        internal override List<Number> Process(List<Number> numbers)
        {
            return numbers.Where(num => num.Value % 2 == 0).ToList();
        }

        public override string Name
        {
            get { return "Even Numbers"; }
        }
    }
}