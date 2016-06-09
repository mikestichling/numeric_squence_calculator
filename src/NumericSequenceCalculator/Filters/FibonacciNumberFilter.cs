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
            var fibonaccis = new List<int>();

            for (var i = 0; i < numbers.Count; i++)
            {
                var current = numbers[i];

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
