using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Utilities
{
    /// <summary>
    /// Статичный класс для вспомогательных функций опроса
    /// </summary>
    public static class InputHelper
    {
        /// <summary>
        /// Опрашивает положительное число с плавающей точкой
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                    return value;
                Console.WriteLine("Введите положительное число.");
            }
        }
        /// <summary>
        /// Опрашивает целочисленное число в отрезке значений
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int ReadValidInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                    return value;
                Console.WriteLine($"Введите число от {min} до {max}.");
            }
        }
    }
}
