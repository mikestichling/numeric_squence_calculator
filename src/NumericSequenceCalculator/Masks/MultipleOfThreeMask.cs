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
        public override List<Number> Process(List<Number> numbers)
        {
            return numbers.Select(number => number.Value % 3 == 0 ? new MaskedNumber(number.Value, "C") : new Number(number.Value)).ToList();
        }
    }
}
