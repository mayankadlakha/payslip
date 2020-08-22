using System;
namespace payslip
{
    public class Payslip
    {
        private Employee employee;
        


        public Payslip(Employee employee )
        {
            this.employee = employee;
        }

        public long getGrossIncome()
        {
            long annualSalary = this.employee.getAnnualSalary();
            Int32 monthsInAYear = 12;
            return annualSalary / monthsInAYear;
        }

        public long getIncomeTax()
        {
            TaxBracketCollection taxBracketCollection = new TaxBracketCollection();
            TaxBracket taxBracket = taxBracketCollection.getTaxBracketFor(this.employee.getAnnualSalary());
            return (long)((taxBracket.getBaseTax() + (this.employee.getAnnualSalary() - taxBracket.getLowerLimit()) * taxBracket.getTaxFactor()) / 12);
        }

        public long getNetIncome()
        {
            return this.getGrossIncome() - this.getIncomeTax();
        }

        public long getSuper()
        {
            return this.getGrossIncome() * this.employee.getSuperRate() / 100;
        }
    }
}
