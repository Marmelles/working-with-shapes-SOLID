using SOLID_pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Factories
{
    public class ShapeOption
    {
        public string Name { get; }
        public Func<IShape?> Create { get; }

        public ShapeOption(string name, Func<IShape?> create)
        {
            Name = name;
            Create = create;
        }
    }
}
