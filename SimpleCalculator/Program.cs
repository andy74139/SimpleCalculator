using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        private static ConsoleController _consoleController;
        private static CalculatorCore _calculatorCore;

        static Program()
        {
            _consoleController = new ConsoleController();
            _calculatorCore = new CalculatorCore();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                var calStatement = _consoleController.GetCalculationStatement();
                var result = _calculatorCore.Calculate(calStatement);
                _consoleController.ResponseCalculationResult(result);
            }
        }
    }
}
