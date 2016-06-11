using NUnit.Framework;
using NumericSequenceCalculator.Domain;

namespace NumericSequenceCalculator.Tests.Domain
{
    public class NumberTests
    {
        [Test]
        public void GivenANumber_WhenInstantiatingIt_ThenItShouldBeValid()
        {
            var number = new Number(0);

            Assert.That(number, Is.Not.Null);
        }

        [Test]
        public void GivenANumber_WhenInstantiatingItWithANumber_ThenItShouldBeValid()
        {
            var number = new Number(10);

            Assert.That(number, Is.Not.Null);
        }

        [Test]
        public void GivenANumber_ThenItShouldHaveAValueProperty()
        {
            var number = new Number(10);

            Assert.That(number.Value, Is.EqualTo(10));
        }

        [Test]
        public void GivenANumber_ThenItShouldHaveADisplayValueProperty()
        {
            var number = new Number(10);

            Assert.That(number.DisplayValue, Is.EqualTo("10"));
        }
    }
}
