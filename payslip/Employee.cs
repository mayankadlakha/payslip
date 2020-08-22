using System;
namespace payslip
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private long annualSalary;
        private long superRate;

        public Employee(string firstName, string lastName, long annualSalary, long superRate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.annualSalary = annualSalary;
            this.superRate = superRate;
        }

        public string getName()
        {
            return this.firstName + ' ' + this.lastName;
        }

        public long getAnnualSalary()
        {
            return this.annualSalary;
        }

        public long getSuperRate()
        {
            return this.superRate;
        }

    }
}
