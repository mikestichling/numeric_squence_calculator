using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.DomainLogic.Entities;

namespace NumericSequenceCalculator.DomainLogic
{
    public class NumberSequenceLogic : INumberSequenceLogic
    {
        
        private List<NumberProcessor> processors;

        public NumberSequenceLogic()
            : this(new List<NumberProcessor>())
        {}
        
        public NumberSequenceLogic(List<NumberProcessor> processors)
        {
            this.processors = processors;
        }

        public IList<ProcessResult> GetProcessedList(int number)
        {
            var numberSequence = new NumberSequence(number);
            var results = new List<ProcessResult>();
                
            //add the actual sequence of numbers to the results.
            results.Add(new ProcessResult(numberSequence));

            //go through each registered processor and add the resultant sequence to the result.
            foreach (var processor in processors)
            {
                var processedSequence = numberSequence.Process(processor);
                results.Add(new ProcessResult(processedSequence, processor.Name));

            }

            return results;
        }
    }
}
