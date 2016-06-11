using NUnit.Framework;
using NumericSequenceCalculator.Domain.Exceptions;
using NumericSequenceCalculator.Domain.Guards;

namespace NumericSequenceCalculator.Tests.Domain
{
    public class NumberGuardTests
    {
        [Test]
        public void GivenAGuard_WhenCheckingAPositiveNumberIsPositive_ThenItShouldSucceed()
        {
            Assert.DoesNotThrow(() => Guard.IsPositive(10));
        }

        [Test]
        public void GivenAGuard_WhenCheckingANegativeNumberIsPositive_ThenItShouldFail()
        {
            Assert.That(() => Guard.IsPositive(-10), Throws.Exception.TypeOf<NumberArgumentException>());
        }
    }
    
}
