using SOLID_pattern.Factories;
using SOLID_pattern.Interfaces;
using SOLID_pattern.Models;
using SOLID_pattern.Utilities;
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
        private readonly ShapeFactory _factory;

        public ShapeSolver(ILogger logger, ShapeFactory factory)
        {
            _logger = logger;
            _factory = factory;
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
            var choice = InputHelper.ReadValidInt("Выберите (1 или 2): ", 1, 2);

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
            _logger.Log("Запущен решатель фигур");

            // Показываем доступные фигуры
            Console.WriteLine("Выберите фигуру:");
            for (int i = 0; i < _factory.Options.Count; i++)
            {
                var shapeOption = _factory.Options[i];
                Console.WriteLine($"{i + 1}. {shapeOption.Name}");
            }

            var choice = InputHelper.ReadValidInt("Выберите: ", 1, _factory.Options.Count);
            var shape = _factory.Create(choice);

            return shape;
        }


    }
}
