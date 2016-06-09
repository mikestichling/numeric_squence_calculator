using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NumericSequenceCalculator.Domain.Filters;
using NumericSequenceCalculator.Domain.Guards;

namespace NumericSequenceCalculator.Domain
{
    public class NumberSequence
    {
        private List<int> sequence;

        public NumberSequence(int amount)
        {
            Guard.IsPositive(amount);
            this.sequence = GenerateSequence(amount);
        }

        public List<int> Sequence
        {
            get
            {
                return sequence;
            }
        }

        private List<int> GenerateSequence(int amount)
        {
            var numbers = new List<int>(amount);
            for (var i = 0; i <= amount; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        public List<int> Filter(NumberFilter filter)
        {
            return filter.Process(this.sequence);
        }
    }
}
