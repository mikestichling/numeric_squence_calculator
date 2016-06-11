using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumericSequenceCalculator.DomainLogic.Entities;

namespace NumericSequenceCalculator.Tests.DomainLogic
{
    public class ProcessResultTests
    {
        [Test]
        public void GivenAProcessResult_WhenInstantiatingIt_ThenItShouldBeValid()
        {
            var processResult = new ProcessResult(new List<NumberDto>(), "Unknown");

            Assert.That(processResult, Is.Not.Null);
        }

        [Test]
        public void GivenAProcessResult_WhenInterogatingItsProperties_ThenItShouldContainAListOfNumbers()
        {
            var processResult = new ProcessResult(new List<NumberDto>(), "Unknown");

            Assert.That(processResult.Numbers, Is.Not.Null);
        }

        [Test]
        public void GivenAProcessResult_WhenInterogatingItsProperties_ThenItShouldContainTheNameOfTheProcessorApplied()
        {
            var processResult = new ProcessResult(new List<NumberDto>(), "Unknown");

            Assert.That(processResult.ProcessorName, Is.EqualTo("Unknown"));
        }

    }
}
