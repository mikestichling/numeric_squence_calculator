using System.Collections.Generic;

namespace NumericSequenceCalculator.Domain
{
    public abstract class NumberProcessor
    {
        public abstract List<Number> Process(List<Number> numbers);
    }
}