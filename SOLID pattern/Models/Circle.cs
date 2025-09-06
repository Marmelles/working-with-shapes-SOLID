using SOLID_pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Models
{
    public class Circle : IShape
    {

        //Убрали set что бы не испортить фигуру после создания
        //Или нужно задать сеттер с проверкой, если хотим менять фигуру
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0.");
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius; // Длина окружности
        }
    }
}
