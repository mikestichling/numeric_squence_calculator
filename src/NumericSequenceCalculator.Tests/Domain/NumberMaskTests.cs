using System.Linq;
using NUnit.Framework;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.Domain.Masks;

namespace NumericSequenceCalculator.Tests.Domain
{
    public class NumberMaskTests 
    {
        [Test]
        public void GivenANumberMask_WhenProcessingASequenceUsingTheMultipleOfThreeMask_ThenItShouldReturnTheCorrectNumberOfMasks()
        {
            var mask = new MultipleOfThreeMask();
            var numbers = new NumberSequence(30);

            var maskedNumbers = numbers.Process(mask);

            Assert.That(maskedNumbers.Where(n => n.DisplayValue == "C").Count(), Is.EqualTo(11));
        }

        [Test]
        public void GivenANumberMask_WhenProcessingASequenceUsingTheMultipleOfThreeMask_ThenItShouldMaskTheNumbersThatAreMultiplesOfThree()
        {
            var mask = new MultipleOfThreeMask();
            var numbers = new NumberSequence(3);

            var maskedNumbers = numbers.Process(mask);

            Assert.That(maskedNumbers[0].DisplayValue, Is.EqualTo("C"));
            Assert.That(maskedNumbers[1].DisplayValue, Is.EqualTo("1"));
            Assert.That(maskedNumbers[2].DisplayValue, Is.EqualTo("2"));
            Assert.That(maskedNumbers[3].DisplayValue, Is.EqualTo("C"));
        }

        [Test]
        public void GivenANumberMask_WhenProcessingASequenceUsingTheMultipleOfFiveMask_ThenItShouldReturnTheCorrectNumberOfMasks()
        {
            var mask = new MultipleOfFiveMask();
            var numbers = new NumberSequence(50);

            var maskedNumbers = numbers.Process(mask);

            Assert.That(maskedNumbers.Where(n => n.DisplayValue == "E").Count(), Is.EqualTo(11));
        }

        [Test]
        public void GivenANumberMask_WhenProcessingASequenceUsingTheMultipleOfFiveMask_ThenItShouldMaskTheNumbersThatAreMultiplesOfFive()
        {
            var mask = new MultipleOfFiveMask();
            var numbers = new NumberSequence(5);

            var maskedNumbers = numbers.Process(mask);

            Assert.That(maskedNumbers[0].DisplayValue, Is.EqualTo("E"));
            Assert.That(maskedNumbers[1].DisplayValue, Is.EqualTo("1"));
            Assert.That(maskedNumbers[2].DisplayValue, Is.EqualTo("2"));
            Assert.That(maskedNumbers[3].DisplayValue, Is.EqualTo("3"));
            Assert.That(maskedNumbers[4].DisplayValue, Is.EqualTo("4"));
            Assert.That(maskedNumbers[5].DisplayValue, Is.EqualTo("E"));
        }

        [Test]
        public void GivenANumberMask_WhenProcessingASequenceUsingTheMultipleOfFiveAndThreeMask_ThenItShouldReturnTheCorrectNumberOfMasks()
        {
            var mask = new MultipleOfFiveAndThreeMask();
            var numbers = new NumberSequence(50);

            var maskedNumbers = numbers.Process(mask);

            Assert.That(maskedNumbers.Where(n => n.DisplayValue == "Z").Count(), Is.EqualTo(4));
        }

        [Test]
        public void GivenANumberMask_WhenProcessingASequenceUsingTheMultipleOfFiveAndThreeMask_ThenItShouldMaskTheNumbersThatAreMultiplesOfFiveAndThree()
        {
            var mask = new MultipleOfFiveAndThreeMask();
            var numbers = new NumberSequence(15);

            var maskedNumbers = numbers.Process(mask);

            Assert.That(maskedNumbers[0].DisplayValue, Is.EqualTo("Z"));
            Assert.That(maskedNumbers[1].DisplayValue, Is.EqualTo("1"));
            Assert.That(maskedNumbers[2].DisplayValue, Is.EqualTo("2"));
            Assert.That(maskedNumbers[3].DisplayValue, Is.EqualTo("3"));
            Assert.That(maskedNumbers[4].DisplayValue, Is.EqualTo("4"));
            Assert.That(maskedNumbers[5].DisplayValue, Is.EqualTo("5"));
            Assert.That(maskedNumbers[6].DisplayValue, Is.EqualTo("6"));
            Assert.That(maskedNumbers[7].DisplayValue, Is.EqualTo("7"));
            Assert.That(maskedNumbers[8].DisplayValue, Is.EqualTo("8"));
            Assert.That(maskedNumbers[9].DisplayValue, Is.EqualTo("9"));
            Assert.That(maskedNumbers[10].DisplayValue, Is.EqualTo("10"));
            Assert.That(maskedNumbers[11].DisplayValue, Is.EqualTo("11"));
            Assert.That(maskedNumbers[12].DisplayValue, Is.EqualTo("12"));
            Assert.That(maskedNumbers[13].DisplayValue, Is.EqualTo("13"));
            Assert.That(maskedNumbers[14].DisplayValue, Is.EqualTo("14"));
            Assert.That(maskedNumbers[15].DisplayValue, Is.EqualTo("Z"));
        }
    }
}
