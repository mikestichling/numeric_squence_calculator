using System.Collections.Generic;

namespace NumericSequenceCalculator.Domain.Filters
{
    public abstract class NumberFilter
    {
        public abstract List<int> Process(List<int> numbers);  

    }
}