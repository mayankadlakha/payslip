using System;
namespace payslip
{
    public class ConsoleParser
    {
        public ConsoleParser()
        {
        }

        public void outputToUser(string output)
        {
            Console.WriteLine(output);
        }

        public string getUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            return userInput;
        }

    }
}


