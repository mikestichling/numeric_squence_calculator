using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.DomainLogic.Entities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NumericSequenceCalculator.Tests")]
namespace NumericSequenceCalculator.DomainLogic
{
    public class NumberSequenceLogic : INumberSequenceLogic
    {

        private readonly List<NumberProcessor> processors;

        public NumberSequenceLogic()
            : this(new List<NumberProcessor>())
        { }

        public NumberSequenceLogic(List<NumberProcessor> processors)
        {
            this.processors = processors;
        }

        public IList<ProcessResult> GetProcessedSequence(int number)
        {
            var numberSequence = new NumberSequence(number);
            var results = new List<ProcessResult>();

            //add the actual sequence of numbers to the results.
            AddUnprocessedSequenceToResult(numberSequence, results);

            //go through each registered processors and add the resultant sequence to the result.
            AddResultOfEachProcessToResult(numberSequence, results);

            return results;
        }

        private void AddResultOfEachProcessToResult(NumberSequence numberSequence, List<ProcessResult> results)
        {
            foreach (var processor in processors)
            {
                var processedSequence = numberSequence.Process(processor);
                results.Add(new ProcessResult(processedSequence, processor.Name));
            }
        }

        private static void AddUnprocessedSequenceToResult(NumberSequence numberSequence, List<ProcessResult> results)
        {
            results.Add(new ProcessResult(numberSequence));
        }
    }
}
