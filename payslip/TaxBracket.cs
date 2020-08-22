using System;
namespace payslip
{
    public class TaxBracket
    {

        private long lowerLimit;
        private long upperLimit;
        private long baseTax;
        private double taxFactor;

        public TaxBracket(long lowerLimit, long upperLimit, long baseTax, double taxFactor)
        {
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;
            this.baseTax = baseTax;
            this.taxFactor = taxFactor;
        }

        public long getLowerLimit()
        {
            return this.lowerLimit;
        }

        public long getUpperLimit()
        {
            return this.upperLimit;
        }

        public long getBaseTax()
        {
            return this.baseTax;
        }

        public double getTaxFactor()
        {
            return this.taxFactor;
        }
    }
}
