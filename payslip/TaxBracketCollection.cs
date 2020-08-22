using System;
namespace payslip
{
    public class TaxBracketCollection
    {
        private TaxBracket[] taxBrackets;

        public TaxBracketCollection()
        {
            this.taxBrackets = new TaxBracket[5];
            this.taxBrackets[0] = new TaxBracket(0, 18200, 0, 0);
            this.taxBrackets[1] = new TaxBracket(18201, 37000, 0, 0.19);
            this.taxBrackets[2] = new TaxBracket(37001, 87000, 3572, 0.325);
            this.taxBrackets[3] = new TaxBracket(87000, 180000, 19822, 0.37);
            this.taxBrackets[4] = new TaxBracket(180001, long.MaxValue, 54232, 0.45);
        }

        public TaxBracket getTaxBracketFor(long annualSalary)
        {
            foreach(TaxBracket taxBracket in taxBrackets)
            {
                if(annualSalary >= taxBracket.getLowerLimit() & annualSalary <= taxBracket.getUpperLimit())
                {
                   return taxBracket;
                }
            }

            return taxBrackets[taxBrackets.Length - 1];

        }
    }
}
