using NumericSequenceCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.DomainLogic.Entities
{
    public class NumberDto
    {
        internal NumberDto(Number number)
        {
            this.Value = number.Value;
            this.DisplayValue = number.DisplayValue;
        }

        public int Value { get; set; }
        public string DisplayValue { get; set; }
    }
}
