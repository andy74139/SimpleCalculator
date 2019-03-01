using System;

namespace SimpleCalculator
{
    internal class ConsoleController
    {
        public CalculationStatement GetCalculationStatement()
        {
            return new CalculationStatement();
        }

        public void ResponseCalculationResult(int calculationResult)
        {
        }
    }
}