using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Interfaces
{
    public interface IShape
    {
        double CalculateArea();      // Вычислить площадь
        double CalculatePerimeter(); // Вычислить периметр
        
    }
}
