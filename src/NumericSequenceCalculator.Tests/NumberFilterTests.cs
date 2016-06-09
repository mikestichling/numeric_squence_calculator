using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.Domain.Filters;

namespace NumericSequenceCalculator.Tests
{
    public class NumberFilterTests
    {
        [Test]
        public void GivenAnEvenFilter_WhenFilteringASequence_ThenItShouldOnlyReturnEvenNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(10);

            var filterNumbers = numbers.Filter(new EvenNumberFilter());

            Assert.That(filterNumbers.Count(), Is.EqualTo(5));
        }

        [Test]
        public void GivenAnEvenFilter_WhenFilteringASequence_ThenItShouldOnlyReturnTheCorrectEvenNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(10);

            var filterNumbers = numbers.Filter(new EvenNumberFilter());

            Assert.That(filterNumbers[0], Is.EqualTo(2));
            Assert.That(filterNumbers[1], Is.EqualTo(4));
            Assert.That(filterNumbers[2], Is.EqualTo(6));
            Assert.That(filterNumbers[3], Is.EqualTo(8));
            Assert.That(filterNumbers[4], Is.EqualTo(10));
        }

        [Test]
        public void GivenAnOddFilter_WhenFilteringASequence_ThenItShouldOnlyReturnOddNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(10);

            var filterNumbers = numbers.Filter(new OddNumberFilter());

            Assert.That(filterNumbers.Count(), Is.EqualTo(5));
        }

        [Test]
        public void GivenAnOddFilter_WhenFilteringASequence_ThenItShouldOnlyReturnTheCorrectOddNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(10);

            var filterNumbers = numbers.Filter(new OddNumberFilter());

            Assert.That(filterNumbers[0], Is.EqualTo(1));
            Assert.That(filterNumbers[1], Is.EqualTo(3));
            Assert.That(filterNumbers[2], Is.EqualTo(5));
            Assert.That(filterNumbers[3], Is.EqualTo(7));
            Assert.That(filterNumbers[4], Is.EqualTo(9));
        }

        [Test]
        public void GivenAnFibonacciFilter_WhenFilteringASequence_ThenItShouldOnlyReturnFibonacciNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(10);

            var filterNumbers = numbers.Filter(new FibonacciNumberFilter());

            Assert.That(filterNumbers.Count(), Is.EqualTo(5));
        }

        [Test]
        public void GivenAnFibonacciFilter_WhenFilteringASequenceWithOneNumber_ThenItShouldOnlyReturnFibonacciNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(1);

            var filterNumbers = numbers.Filter(new FibonacciNumberFilter());

            Assert.That(filterNumbers.Count(), Is.EqualTo(1));
        }

        [Test]
        public void GivenAnFibonacciFilter_WhenFilteringASequenceWithALargeNumber_ThenItShouldOnlyReturnFibonacciNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(100);

            var filterNumbers = numbers.Filter(new FibonacciNumberFilter());

            Assert.That(filterNumbers.Count(), Is.EqualTo(10));
        }

        [Test]
        public void GivenAnFibonacciFilter_WhenFilteringASequence_ThenItShouldOnlyReturnTheCorrectFibonacciNumbersFromTheSequence()
        {
            var numbers = new NumberSequence(10);

            var filterNumbers = numbers.Filter(new FibonacciNumberFilter());

            Assert.That(filterNumbers[0], Is.EqualTo(1));
            Assert.That(filterNumbers[1], Is.EqualTo(2));
            Assert.That(filterNumbers[2], Is.EqualTo(3));
            Assert.That(filterNumbers[3], Is.EqualTo(5));
            Assert.That(filterNumbers[4], Is.EqualTo(8));
        }
    }
}
