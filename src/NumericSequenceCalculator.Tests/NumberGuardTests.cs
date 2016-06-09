using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.Domain.Exceptions;
using NumericSequenceCalculator.Domain.Guards;

namespace NumericSequenceCalculator.Tests
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
