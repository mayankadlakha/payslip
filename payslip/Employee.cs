using System;
namespace payslip
{
    public class Employee
    {
        private String firstName;
        private String lastName;

        public Employee(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public String getEmployeeName()
        {
            return this.firstName + ' ' + this.lastName;
        }

      
    }
}
