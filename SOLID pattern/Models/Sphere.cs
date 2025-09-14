using SOLID_pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Models
{
    public class Sphere : I3DShape
    {
        public double Radius { get; set; }

        public double CalculateArea() => 4 * Math.PI * Radius * Radius; 

        public double CalculateVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3); 
    }
}
