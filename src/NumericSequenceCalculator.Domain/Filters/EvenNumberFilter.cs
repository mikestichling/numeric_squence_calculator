using System.Collections.Generic;
using System.Linq;

namespace NumericSequenceCalculator.Domain.Filters
{
    public class EvenNumberFilter : NumberProcessor
    {
        public override List<Number> Process(List<Number> numbers)
        {
            return numbers.Where(num => num.Value % 2 == 0).ToList();
        }
    }
}