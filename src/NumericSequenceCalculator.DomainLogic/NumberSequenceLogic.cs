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

            AddUnprocessedSequenceToResult(numberSequence, results);

            AddResultOfEachProcessToResult(numberSequence, results);

            return results;
        }

        private void AddResultOfEachProcessToResult(NumberSequence numberSequence, List<ProcessResult> results)
        {
            //go through each registered processors and add the resultant sequence to the result.
            foreach (var processor in processors)
            {
                var processedSequence = numberSequence.Process(processor);
                results.Add(new ProcessResult(processedSequence, processor.Name));
            }
        }

        private static List<ProcessResult> AddUnprocessedSequenceToResult(NumberSequence numberSequence, List<ProcessResult> results)
        {
            //add the actual sequence of numbers to the results.
            results.Add(new ProcessResult(numberSequence));
            return results;
        }
    }
}
