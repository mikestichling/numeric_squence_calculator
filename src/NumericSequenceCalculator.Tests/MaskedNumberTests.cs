using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumericSequenceCalculator.Domain;

namespace NumericSequenceCalculator.Tests
{
    public class MaskedNumberTests
    {
        [Test]
        public void GivenAMaskedNumber_WhenInstantiatingIt_ThenItShouldBeValid()
        {
            var number = new MaskedNumber(0, "C");

            Assert.That(number, Is.Not.Null);
        }

        [Test]
        public void GivenANumber_WhenInstantiatingItWithANumberAndAMask_ThenItShouldBeValid()
        {
            var number = new MaskedNumber(10, "C");

            Assert.That(number, Is.Not.Null);
        }

        [Test]
        public void GivenANumber_ThenItShouldHaveAValueProperty()
        {
            var number = new MaskedNumber(10, "C");

            Assert.That(number.Value, Is.EqualTo(10));
        }

        [Test]
        public void GivenANumber_ThenItShouldHaveADisplayValueProperty()
        {
            var number = new MaskedNumber(10, "C");

            Assert.That(number.DisplayValue, Is.EqualTo("C"));
        }
    }
}
