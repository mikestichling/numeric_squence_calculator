using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Domain
{
    public class MaskedNumber : Number
    {
        private string mask;
        public MaskedNumber(int number, string mask) : base(number)
        {
            this.mask = mask;
        }

        public override string DisplayValue
        {
            get
            {
                return this.mask;
            }
        }
    }
}
