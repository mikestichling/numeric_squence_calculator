using System.Collections.Generic;

namespace NumericSequenceCalculator.Domain
{
    public abstract class NumberProcessor
    {
        internal abstract List<Number> Process(List<Number> numbers);

        public abstract string Name { get; }
    }
}