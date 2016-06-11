using NumericSequenceCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.DomainLogic.Entities
{
    public class ProcessResult
    {
        public ProcessResult(List<NumberDto> numbers, string name)
        {
            this.Numbers = numbers;
            this.ProcessorName = name;
        }

        internal ProcessResult(List<Number> numbers, string name)
        {
            this.Numbers = numbers.Select(number => new NumberDto(number)).ToList();
            this.ProcessorName = name;
        }

        internal ProcessResult(NumberSequence numberSequence)
        {
            this.Numbers = numberSequence.Sequence.Select(number => new NumberDto(number)).ToList();
            this.ProcessorName = numberSequence.Name;
        }

        public List<NumberDto> Numbers { get; set; }
        public string ProcessorName { get; set; }
    }
}
