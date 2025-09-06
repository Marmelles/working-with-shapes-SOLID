using SOLID_pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Models
{
    public class Rectangle : IShape
    {
        //Убрали set что бы не испортить фигуру после создания
        //Или нужно задать сеттер с проверкой, если хотим менять фигуру
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0)
                throw new ArgumentException("Ширина должна быть больше 0.");
            if (height <= 0)
                throw new ArgumentException("Высота должна быть больше 0.");
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
