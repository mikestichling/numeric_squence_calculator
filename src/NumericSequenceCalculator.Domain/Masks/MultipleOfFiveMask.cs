using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericSequenceCalculator.Domain.Filters;

namespace NumericSequenceCalculator.Domain.Masks
{
    public class MultipleOfFiveMask : NumberProcessor
    {
        internal override List<Number> Process(List<Number> numbers)
        {
            return numbers.Select(number => number.Value % 5 == 0 ? 
                new MaskedNumber(number.Value, "E") 
                : number).ToList();
        }

        public override string Name
        {
            get { return "Multiples of Five"; }
        }
    }
}
