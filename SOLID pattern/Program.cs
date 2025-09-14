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


// 2.O — Open/Closed Principle (Принцип открытости/закрытости)
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

// 3.L — Liskov Substitution Principle (Принцип подстановки Лисков)
// Поведение классов одного интерфейса одинаковое, без исключений.
// Классы не предают свой интерфейс и все работают.
// Инициализация не в счёт потому что он даже не создастся.
// В коде где работает с дитём интерфейса, любой класс должен отрабатывать без исключений.
// Пример можно увидеть в любой фигуре (нет исключений в методах классов)

//4. I — Interface Segregation Principle (Принцип разделения интерфейсов)
// Классы интерфеса не должны реализовывать не нужные им методы из интерфейса
// Нужно разделять интерфесы
// Например если будет работа с 3Д фигурами, то 2Д фигуры не должны реализовать методы 3Д фигур (Например подсчёт объёма)
// Я разделил интерфес 2д фигур на интерфесы периметра и площади, таким образом смог создать интерфес для 3д фигур не содержащих периметра, но содержащих площадь и объём
// Пример в фигуре Models/Sphere


// Создаём решатель с готовой фабрикой
var solver = new ShapeSolver(consoleLogger, factory);
solver.Solve();