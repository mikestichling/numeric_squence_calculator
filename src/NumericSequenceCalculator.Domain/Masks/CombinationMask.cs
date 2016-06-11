using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Domain.Masks
{
    public class CombinationMask : NumberProcessor
    {
        private List<NumberProcessor> processors;
        public CombinationMask(List<NumberProcessor> processors)
        {
            this.processors = processors;
        }


        internal override List<Number> Process(List<Number> numbers)
        {
            var output = numbers;
            foreach (var processor in processors)
            {
                output = processor.Process(output);
            }

            return output;
        }

        public override string Name
        {
            get { return "Multiples of Three, Five or Both"; }
        }
    }
}
