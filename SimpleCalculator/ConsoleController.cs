using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    internal class ConsoleController
    {
        public CalculationStatement GetCalculationStatement()
        {
            var operators = new[] { '+', '-', '*', '/', '%' };
            bool isValidCalculation;
            string input;
            do
            {
                Console.WriteLine("Please enter your calculation: ");
                input = Console.ReadLine();
                isValidCalculation = Regex.IsMatch(input, @"^\d+[\+\-\*\/\%]\d+$");
                if (!isValidCalculation)
                    Console.WriteLine("Wrong input!");
            } while (!isValidCalculation);

            var operandsString = input.Split(operators);
            var operand1 = Convert.ToInt32(operandsString[0]);
            var operand2 = Convert.ToInt32(operandsString[1]);
            var @operator = input.Substring(operandsString.First().Length, 1).First();

            return new CalculationStatement(@operator, operand1, operand2);
        }

        public void ResponseCalculationResult(int calculationResult)
        {
            Console.WriteLine("The calculation result is: " + calculationResult);
            Console.WriteLine();
        }
    }
}