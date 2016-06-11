using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericSequenceCalculator.Domain.Filters;

namespace NumericSequenceCalculator.Domain.Masks
{
    public class MultipleOfThreeMask : NumberProcessor
    {
        internal override List<Number> Process(List<Number> numbers)
        {
            return numbers.Select(number => number.Value % 3 == 0 ? 
                new MaskedNumber(number.Value, "C") 
                : new Number(number.Value)).ToList();
        }

        public override string Name
        {
            get { return "Multiples of Three"; }
        }
    }
}
