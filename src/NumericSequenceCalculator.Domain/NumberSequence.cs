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
        private readonly List<Number> sequence;

        public NumberSequence(int amount)
        {
            Guard.IsPositive(amount);
            this.sequence = GenerateSequence(amount);
        }

        public List<Number> Sequence
        {
            get
            {
                return sequence;
            }
        }

        public List<Number> Process(NumberProcessor processor)
        {
            return processor.Process(this.sequence);
        }

        public string Name
        {
            get
            {
                return string.Format("Sequence of numbers from 0 to {0}", this.sequence.Count - 1);
            }
        }

        private List<Number> GenerateSequence(int amount)
        {
            var numbers = new List<Number>(amount);
            for (var i = 0; i <= amount; i++)
            {
                numbers.Add(new Number(i));
            }
            return numbers;
        }
    }
}
