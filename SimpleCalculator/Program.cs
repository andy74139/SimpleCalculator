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

        static Program()
        {
            _consoleController = new ConsoleController();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                var calStatement = _consoleController.GetCalculationStatement();
                var result = calStatement.GetResult();
                _consoleController.ResponseCalculationResult(result);
            }
        }
    }
}
