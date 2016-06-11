using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericSequenceCalculator.DomainLogic.Entities;

namespace NumericSequenceCalculator.DomainLogic
{
    public interface INumberSequenceLogic
    {
        IList<ProcessResult> GetProcessedList(int number);
    }
}
