using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumericSequenceCalculator.Domain.Masks;

namespace NumericSequenceCalculator.Tests.Domain
{
    public class NumberProcessorTests
    {
        [Test]
        public void GivenANumberProcessor_WhenGettingTheName_ThenItShouldReturnTheNameOfTheProcessor()
        {
            var numberProcessor = new MultipleOfFiveAndThreeMask();

            Assert.That(numberProcessor.Name, Is.EqualTo("Multiples of Five and Three"));
        }
    }
}
