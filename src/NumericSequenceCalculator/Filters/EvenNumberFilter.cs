using System.Collections.Generic;
using System.Linq;

namespace NumericSequenceCalculator.Domain.Filters
{
    public class EvenNumberFilter : NumberFilter
    {
        public override List<int> Process(List<int> numbers)
        {
            return numbers.Where(num => num % 2 == 0).ToList();
        }
    }
}