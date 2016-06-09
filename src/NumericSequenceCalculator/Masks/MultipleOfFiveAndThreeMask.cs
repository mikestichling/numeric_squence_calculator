using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericSequenceCalculator.Domain.Filters;

namespace NumericSequenceCalculator.Domain.Masks
{
    public class MultipleOfFiveAndThreeMask : NumberProcessor
    {
        public override List<Number> Process(List<Number> numbers)
        {
            var maskedNumbers = new List<Number>();
            foreach (var number in numbers)
            {
                maskedNumbers.Add(number.Value % 5 == 0 && number.Value % 3 == 0 ? new MaskedNumber(number.Value, "Z") : new Number(number.Value));
            }

            return maskedNumbers;
        }
    }
}
