using System;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleParser consoleParser = new ConsoleParser();

            consoleParser.outputToUser("Welcome to the payslip generator!");

            string firstName = consoleParser.getUserInput("Please input your name: ");

            string lastName = consoleParser.getUserInput("Please input your surname: ");

            Employee userInput = new Employee(firstName, lastName);
            Console.WriteLine("Name: " + userInput.getEmployeeName());

        }
    }
}