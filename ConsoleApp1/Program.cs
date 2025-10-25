using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            while (true)
            {
                Console.Write("x= ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ввод пуст. Повторите попытку.");
                    continue;
                }

                if (!double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out x))
                {
                    Console.WriteLine("Некорректный формат числа. Введите число, например 2.5");
                    continue;
                }

                if (x <= 1)
                {
                    Console.WriteLine("Функция не определена для x <= 1. Требуется x > 1.");
                    continue;
                }

                break;
            }

            double y = Math.Log10(x - 1);
            Console.WriteLine("y = {0:F2}", y);
        }
    }
}
