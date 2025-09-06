using SOLID_pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Models
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        // Проверяет, может ли существовать такой треугольник
        public static bool IsValid(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                return false;

            return (sideA + sideB > sideC) &&
                   (sideA + sideC > sideB) &&
                   (sideB + sideC > sideA);
        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValid(sideA, sideB, sideC))
                throw new InvalidOperationException("Треугольник с такими сторонами не существует.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2; // полупериметр
            double area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            return area;
        }
        public double CalculatePerimeter() {
            return SideA + SideB + SideC;
        }

    }
}
