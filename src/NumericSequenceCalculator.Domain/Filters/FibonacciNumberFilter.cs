using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Domain.Filters
{
    public class FibonacciNumberFilter : NumberProcessor
    {
        internal override List<Number> Process(List<Number> numbers)
        {
            if (numbers.Count <= 2)
                return numbers;

            var fibonaccis = new List<Number>() { new Number(0), new Number(1) }; //by definition the Fibonacci sequence starts with 0 and 1.

            var excludingZero = numbers.Where(n => n.Value != 0).ToList();

            for (var i = 0; i < excludingZero.Count(); i++)
            {
                var current = excludingZero[i].Value;

                if (OutOfBounds(i))
                {
                    fibonaccis.Add(new Number(current));
                    continue;
                }

                if (current == fibonaccis[fibonaccis.Count - 1].Value + fibonaccis[fibonaccis.Count - 2].Value)
                {
                    fibonaccis.Add(new Number(current));
                }
            }

            return fibonaccis;
        }

        public override string Name
        {
            get { return "Fibonacci Sequence"; }
        }

        private bool OutOfBounds(int i)
        {
            return i - 1 < 0 || i - 2 < 0;
        }
    }
}
