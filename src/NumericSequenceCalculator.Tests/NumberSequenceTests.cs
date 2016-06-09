using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.Domain.Exceptions;

namespace NumericSequenceCalculator.Tests
{
    public class NumberSequenceTests
    {
        [Test]
        public void GivenANumberSequence_WhenGettingTheSequencesOfNumbers_ThenItMustReturnAListOfNumbers()
        {
            var number = 10;

            var numbers = new NumberSequence(number).Sequence;

            Assert.That(numbers.Count(), Is.EqualTo(10));
        }

        [Test]
        public void GivenANumberSequence_WhenGettingTheSequencesOfNumbers_ThenItMustReturnNumbersUpToTheNumber()
        {
            var number = 10;

            var numbers = new NumberSequence(number).Sequence;

            Assert.That(numbers[0], Is.EqualTo(1));
            Assert.That(numbers[1], Is.EqualTo(2));
            Assert.That(numbers[2], Is.EqualTo(3));
            Assert.That(numbers[3], Is.EqualTo(4));
            Assert.That(numbers[4], Is.EqualTo(5));
            Assert.That(numbers[5], Is.EqualTo(6));
            Assert.That(numbers[6], Is.EqualTo(7));
            Assert.That(numbers[7], Is.EqualTo(8));
            Assert.That(numbers[8], Is.EqualTo(9));
            Assert.That(numbers[9], Is.EqualTo(10));
        }

        [Test]
        public void GivenANumberSequence_WhenEnteringANegativeValue_ThenItShouldThrowAnException()
        {
            Assert.That(() => new NumberSequence(-10), Throws.TypeOf<NumberArgumentException>());
        }
    }
}
