using System;

namespace NumericSequenceCalculator.Domain.Exceptions
{
    public class NumberArgumentException : ArgumentException
    {
        public NumberArgumentException(int number) 
            : base(string.Format("The number entered has to be positive. You entered: {0}", number))
        {}
    }
}
