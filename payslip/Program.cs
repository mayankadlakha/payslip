using System;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            long annualSalaryLong = 0; // Should this be null?
            long superRateLong = 0; 
            ConsoleParser consoleParser = new ConsoleParser();

            consoleParser.outputToUser("Welcome to the payslip generator!");

            string firstName = consoleParser.getUserInput("Please input your name: ");
            string lastName = consoleParser.getUserInput("Please input your surname: ");
            string annualSalaryString = consoleParser.getUserInput("Please enter your annual salary: ");
            string superRateString = consoleParser.getUserInput("Please enter your super rate: ");
            string paymentStartDate = consoleParser.getUserInput("Please enter your payment start date: ");
            string paymentEndDate = consoleParser.getUserInput("Please enter your payment end date: ");
            try
            {
                annualSalaryLong = long.Parse(annualSalaryString);
                superRateLong = long.Parse(superRateString);
            }
            catch (FormatException e)
            {
                consoleParser.outputToUser("Error: Annual salary and super must be numbers.");
                Environment.Exit(0); //Applciation.Exit
            }

            Employee employee = new Employee(firstName, lastName, annualSalaryLong, superRateLong);

            Payslip payslip = new Payslip(employee);


            //Output

            consoleParser.outputToUser("Your payslip has been generated: ");
            consoleParser.outputToUser("Name: " + employee.getName());
            consoleParser.outputToUser("Pay period: " + paymentStartDate + "-" + paymentEndDate);
            consoleParser.outputToUser("Salary: " + employee.getAnnualSalary());
            consoleParser.outputToUser("Gross Income: " + payslip.getGrossIncome() );
            consoleParser.outputToUser("Income Tax: " + payslip.getIncomeTax());
            consoleParser.outputToUser("Net Income: " + payslip.getNetIncome());
            consoleParser.outputToUser("Super: " + payslip.getSuper() );

        }
    }
}

//Todo
//Validation of input values