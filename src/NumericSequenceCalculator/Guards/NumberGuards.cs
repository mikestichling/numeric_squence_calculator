using NumericSequenceCalculator.Domain.Exceptions;

namespace NumericSequenceCalculator.Domain.Guards
{
    public static partial class Guard
    {
        public static void IsPositive(int number)
        {
            if (number < 0)
                throw new NumberArgumentException(number);
        }
    }
}
