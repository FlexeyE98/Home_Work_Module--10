using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Module10
{



    public class Program
    {
        static ILogger logger { get; set; }
        static void Main(string[] args)
        {
            logger = new Logger();
            Calculator calculator = new Calculator(logger);
            while (true)
            {

                try
                {
                    Console.WriteLine("Калькулятор сложения двух чисел.\n\nВведите два числа:\n");
                    Console.Write("Первое число: ");
                    int number1 = int.Parse(Console.ReadLine());
                    Console.Write("Второе число: ");
                    int number2 = int.Parse(Console.ReadLine());
                    ((ICalculator)calculator).Calc(number1, number2);

                }
                catch (FormatException)
                {
                    logger.Error("Произошла ошибка...");
                    Console.WriteLine("\nВведено некорректное значение\n");
                    
                }
            }


        }

    }


    public interface ICalculator
    {

        public void Calc(int x, int y);

    }

    public interface ILogger
    {
        void Error(string message);
        void Event(string message);
    
    }







}