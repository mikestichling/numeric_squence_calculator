using System.Linq;
using NUnit.Framework;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.Domain.Exceptions;

namespace NumericSequenceCalculator.Tests.Domain
{
    public class NumberSequenceTests
    {
        [Test]
        public void GivenANumberSequence_WhenGettingTheSequencesOfNumbers_ThenItMustReturnAListOfNumbers()
        {
            var number = 10;

            var numbers = new NumberSequence(number).Sequence;

            Assert.That(numbers.Count(), Is.EqualTo(11));
        }

        [Test]
        public void GivenANumberSequence_WhenGettingTheSequencesOfNumbers_ThenItMustReturnNumbersUpToTheNumber()
        {
            var number = 10;

            var numbers = new NumberSequence(number).Sequence;

            Assert.That(numbers[0].Value, Is.EqualTo(0));
            Assert.That(numbers[1].Value, Is.EqualTo(1));
            Assert.That(numbers[2].Value, Is.EqualTo(2));
            Assert.That(numbers[3].Value, Is.EqualTo(3));
            Assert.That(numbers[4].Value, Is.EqualTo(4));
            Assert.That(numbers[5].Value, Is.EqualTo(5));
            Assert.That(numbers[6].Value, Is.EqualTo(6));
            Assert.That(numbers[7].Value, Is.EqualTo(7));
            Assert.That(numbers[8].Value, Is.EqualTo(8));
            Assert.That(numbers[9].Value, Is.EqualTo(9));
        }

        [Test]
        public void GivenANumberSequence_WhenEnteringANegativeValue_ThenItShouldThrowAnException()
        {
            Assert.That(() => new NumberSequence(-10), Throws.TypeOf<NumberArgumentException>());
        }
    }
}
