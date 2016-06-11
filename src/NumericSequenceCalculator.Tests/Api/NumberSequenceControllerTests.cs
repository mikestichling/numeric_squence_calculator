using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumericSequenceCalculator.DomainLogic;
using NumericSequenceCalculator.DomainLogic.Entities;
using NumericSequenceCalculator.WebApi.Controllers;

namespace NumericSequenceCalculator.Tests.Api
{
    public class NumberSequenceControllerTests
    {
        [Test]
        public void GivenANumberSequenceController_WhenGettingWithANumber_ThenItShouldWork()
        {
            var controller = GivenANumberSequenceController();

            var result = controller.Get(10);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void GivenANumberSequenceController_WhenGettingWithANumber_ThenItShouldAListOfProcessResults()
        {
            var controller = GivenANumberSequenceController();

            var result = controller.Get(10);

            Assert.That(result, Is.TypeOf<List<ProcessResult>>());
        }

        [Test]
        public void GivenANumberSequenceController_WhenGettingWithANumberAndTheDefaultProcessor_ThenItShouldReturnTheCorrectResult()
        {
            var controller = GivenANumberSequenceController();

            var result = controller.Get(10).ToList();

            Assert.That(result[0].ProcessorName, Is.EqualTo("Sequence of numbers from 0 to 10"));

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
        }

        private NumberSequenceController GivenANumberSequenceController()
        {
            var numberSequenceLogic = new NumberSequenceLogic();
            var controller = new NumberSequenceController(numberSequenceLogic);
            return controller;
        }
    }
}
