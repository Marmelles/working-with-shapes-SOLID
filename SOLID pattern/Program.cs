using SOLID_pattern.Interfaces;
using SOLID_pattern.Services;
using SOLID_pattern.Solvers;

ILogger fileLogger = new FileLogger();
ILogger consoleLogger = new ConsoleLogger();

new ShapeSolver(consoleLogger).Solve();