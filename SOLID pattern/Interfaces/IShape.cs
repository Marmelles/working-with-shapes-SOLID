using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Interfaces
{
    public interface IShape
    {
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        double CalculateArea();
        /// <summary>
        /// Вычесление периметра
        /// </summary>
        /// <returns></returns>
        double CalculatePerimeter(); 
        
    }
}
