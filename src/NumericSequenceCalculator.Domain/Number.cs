namespace NumericSequenceCalculator.Domain
{
    public class Number
    {
        private readonly int number;
        public Number(int number)
        {
            this.number = number;
        }

        public int Value
        {
            get
            {
                return this.number;
            }
        }

        public virtual string DisplayValue
        {
            get
            {
                return this.number.ToString();
            }
        }
    }
}