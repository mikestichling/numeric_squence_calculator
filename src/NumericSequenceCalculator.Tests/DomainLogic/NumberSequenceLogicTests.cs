using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.Domain.Filters;
using NumericSequenceCalculator.DomainLogic;
using NumericSequenceCalculator.DomainLogic.Entities;

namespace NumericSequenceCalculator.Tests.DomainLogic
{
    public class NumberSequenceLogicTests
    {
        [Test]
        public void GivenANumberSequenceLogic_WhenInstantiatingIt_ThenItShouldBeValid()
        {
            var numberSequenceLogic = new NumberSequenceLogic();

            Assert.That(numberSequenceLogic, Is.Not.Null);
        }

        [Test]
        public void GivenANumberSequenceLogic_WhenGettingAProcessedList_ThenItShouldReturnProcessResult()
        {
            var numberSequenceLogic = new NumberSequenceLogic();

            var result = numberSequenceLogic.GetProcessedSequence(10);

            Assert.That(result, Is.TypeOf<List<ProcessResult>>());
        }

        [Test]
        public void GivenANumberSequenceLogicWithAnSingleProcessor_WhenGettingAProcessedList_ThenItShouldReturnTwoProcessResults()
        {
            var numberSequenceLogic = new NumberSequenceLogic(new List<NumberProcessor> { new EvenNumberFilter() });

            var result = numberSequenceLogic.GetProcessedSequence(10);

            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void GivenANumberSequenceLogicWithAnOddNumberFilter_WhenGettingAProcessedList_ThenItShouldReturnTwoProcessResultsWithTheCorrectSequencesInEach()
        {
            var numberSequenceLogic = new NumberSequenceLogic(new List<NumberProcessor> { new OddNumberFilter() });

            var result = numberSequenceLogic.GetProcessedSequence(10);

            Assert.That(result[0].ProcessorName, Is.EqualTo("Sequence of numbers from 0 to 10"));
            Assert.That(result[1].ProcessorName, Is.EqualTo("Odd Numbers"));

            Assert.That(result[0].Numbers[0].Value, Is.EqualTo(0));
            Assert.That(result[0].Numbers[1].Value, Is.EqualTo(1));
            Assert.That(result[0].Numbers[2].Value, Is.EqualTo(2));
            Assert.That(result[0].Numbers[3].Value, Is.EqualTo(3));
            Assert.That(result[0].Numbers[4].Value, Is.EqualTo(4));
            Assert.That(result[0].Numbers[5].Value, Is.EqualTo(5));
            Assert.That(result[0].Numbers[6].Value, Is.EqualTo(6));
            Assert.That(result[0].Numbers[7].Value, Is.EqualTo(7));
            Assert.That(result[0].Numbers[8].Value, Is.EqualTo(8));
            Assert.That(result[0].Numbers[9].Value, Is.EqualTo(9));
            Assert.That(result[0].Numbers[10].Value, Is.EqualTo(10));

            Assert.That(result[1].Numbers[0].Value, Is.EqualTo(1));
            Assert.That(result[1].Numbers[1].Value, Is.EqualTo(3));
            Assert.That(result[1].Numbers[2].Value, Is.EqualTo(5));
            Assert.That(result[1].Numbers[3].Value, Is.EqualTo(7));
            Assert.That(result[1].Numbers[4].Value, Is.EqualTo(9));
        }
    }
}
