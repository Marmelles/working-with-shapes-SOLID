using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Interfaces
{
    public interface ISolver
    {
        string Name { get; }  // Название задачи (чтобы показать в меню)
        void Solve();          // Метод, который запускает решение
    }
}
