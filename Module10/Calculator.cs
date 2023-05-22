using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Calculator : ICalculator
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        void ICalculator.Calc(int x, int y)
        {
            Logger.Event("Начинаю подсчет...");
            Console.WriteLine($"Сумма введенных чисел: {x + y}\n\n");

        }













    }
}
