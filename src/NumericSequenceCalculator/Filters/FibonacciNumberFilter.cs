using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Domain.Filters
{
    public class FibonacciNumberFilter : NumberFilter
    {
        public override List<int> Process(List<int> numbers)
        {
            if (numbers.Count <= 2)
                return numbers;

            var fibonaccis = new List<int>() { 0, 1 }; //by definition the Fibonacci sequence starts with 0 and 1.

            var excludingZero = numbers.Where(n => n != 0).ToList();

            for (var i = 0; i < excludingZero.Count(); i++)
            {
                var current = excludingZero[i];

                if (OutOfBounds(i))
                {
                    fibonaccis.Add(current);
                    continue;
                }

                if (current == fibonaccis[fibonaccis.Count - 1] + fibonaccis[fibonaccis.Count - 2])
                {
                    fibonaccis.Add(current);
                }
            }

            return fibonaccis;
        }

        private bool OutOfBounds(int i)
        {
            return i - 1 < 0 || i - 2 < 0;
        }
    }
}
