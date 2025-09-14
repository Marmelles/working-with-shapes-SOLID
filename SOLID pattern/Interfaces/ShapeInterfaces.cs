using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Interfaces
{
    
    public interface ICalculatePerimeter
    {
        /// <summary>
        /// Вычесление периметра
        /// </summary>
        /// <returns>Значение периметра фигуры</returns>
        double CalculatePerimeter();
    }
    public interface ICalculateArea
    {
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Значение площади фигуры</returns>
        double CalculateArea();
    }
    public interface ICalculateVolume
    {
        /// <summary>
        /// Вычисление объёма
        /// </summary>
        /// <returns>Значение объёма фигуры</returns>
        double CalculateVolume();
    }
    public interface I3DShape : ICalculateArea, ICalculateVolume { }
    public interface IShape : ICalculateArea, ICalculatePerimeter { }
}
