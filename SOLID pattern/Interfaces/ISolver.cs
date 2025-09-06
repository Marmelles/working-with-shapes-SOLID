using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Interfaces
{
    public interface ISolver
    {
        /// <summary>
        /// Название задачи (чтобы показать в меню)
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Метод, который запускает решение
        /// </summary>
        void Solve();
    }
}
