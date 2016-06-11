using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NumericSequenceCalculator.Domain;
using NumericSequenceCalculator.Domain.Filters;
using NumericSequenceCalculator.Domain.Masks;

namespace NumericSequenceCalculator.DomainLogic.AutoFac
{
    public static class Registrations
    {
        public static void RegisterIndividualComponents(ContainerBuilder builder)
        {
            var processors = new List<NumberProcessor>(){ 
                                new OddNumberFilter(), 
                                new EvenNumberFilter(),
                                new CombinationMask(new List<NumberProcessor> { new MultipleOfThreeMask(), new MultipleOfFiveMask(), new MultipleOfFiveAndThreeMask()}),
                                new FibonacciNumberFilter() };

            builder.RegisterType<NumberSequenceLogic>()
                   .As<INumberSequenceLogic>().WithParameter(new TypedParameter(typeof(List<NumberProcessor>), processors));
        }
    }
}
