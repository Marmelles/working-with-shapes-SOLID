using SOLID_pattern.Interfaces;
using SOLID_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Solvers
{
    /// <summary>
    /// Решатель задач по фигурам
    /// </summary>
    public class ShapeSolver
    {
        private readonly ILogger _logger;

        public ShapeSolver(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Запуск решателя
        /// </summary>
        public void Solve()
        {
            _logger.Log("Запущен решатель фигур");

            // 1. Выбор фигуры
            var shape = ReadShape();
            if (shape == null)
            {
                Console.WriteLine("Не удалось создать фигуру.");
                return;
            }

            // 2. Выбор действия
            Console.WriteLine("Что посчитать?");
            Console.WriteLine("1. Площадь");
            Console.WriteLine("2. Периметр");
            var choice = ReadValidInt("Выберите (1 или 2): ", 1, 2);

            // 3. Расчёт и вывод
            if (choice == 1)
            {
                var area = shape.CalculateArea();
                Console.WriteLine($"Площадь: {area:F2}");
                _logger.Log($"Рассчитана площадь: {area:F2}");
            }
            else
            {
                var perimeter = shape.CalculatePerimeter();
                Console.WriteLine($"Периметр: {perimeter:F2}");
                _logger.Log($"Рассчитан периметр: {perimeter:F2}");
            }
        }

        private IShape? ReadShape()
        {
            Console.WriteLine("Выберите фигуру:");
            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            var choice = ReadValidInt("Введите номер: ", 1, 2);

            return choice == 1 ? ReadRectangle() : ReadCircle();
        }

        private Rectangle? ReadRectangle()
        {
            var width = ReadPositiveDouble("Введите ширину: ");
            var height = ReadPositiveDouble("Введите высоту: ");
            return new Rectangle(width, height);
        }

        private Circle? ReadCircle()
        {
            var radius = ReadPositiveDouble("Введите радиус: ");
            return new Circle(radius);
        }

        private double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                    return value;
                Console.WriteLine("Ошибка: введите положительное число.");
            }
        }

        private int ReadValidInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                    return value;
                Console.WriteLine($"Ошибка: введите число от {min} до {max}.");
            }
        }
    }
}
