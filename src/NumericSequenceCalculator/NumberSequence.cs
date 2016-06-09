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

        public NumberSequence(int number)
        {
            Guard.IsPositive(number);
            this.sequence = GenerateSequence(number);
        }

        public List<int> Sequence
        {
            get
            {
                return sequence;
            }
        }

        private List<int> GenerateSequence(int number)
        {
            var numbers = new List<int>(number);
            for (var i = 1; i <= number; i++)
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
