using SOLID_pattern.Factories;
using SOLID_pattern.Interfaces;
using SOLID_pattern.Models;
using SOLID_pattern.Services;
using SOLID_pattern.Solvers;
using SOLID_pattern.Utilities;

// 1.S — Single Responsibility Principle (Принцип единственной ответственности) #SRP
// Один класс - одна задача
// Один класс - один логгер 
ILogger fileLogger = new FileLogger();
ILogger consoleLogger = new ConsoleLogger();


// O — Open/Closed Principle (Принцип открытости/закрытости)
// Открыт для расширения, закрыт для модификации.
// Можем добавлять фигуры не меняя класс ShapeSolver
// Регистрация фигур
var factory = new ShapeFactory();
factory.Register("Прямоугольник", () =>
{
    var width = InputHelper.ReadPositiveDouble("Ширина: ");
    var height = InputHelper.ReadPositiveDouble("Высота: ");
    return new Rectangle(width, height);
});

factory.Register("Круг", () =>
{
    var radius = InputHelper.ReadPositiveDouble("Радиус: ");
    return new Circle(radius);
});

factory.Register("Треугольник", () =>
{
    while (true)
    {
        var sideA = InputHelper.ReadPositiveDouble("Сторона A: ");
        var sideB = InputHelper.ReadPositiveDouble("Сторона B: ");
        var sideC = InputHelper.ReadPositiveDouble("Сторона C: ");

        if (Triangle.IsValid(sideA, sideB, sideC))
            return new Triangle(sideA, sideB, sideC);

        Console.WriteLine("Ошибка: такой треугольник не может существовать.");
    }
});

// Создаём решатель с готовой фабрикой
var solver = new ShapeSolver(consoleLogger, factory);
solver.Solve();