using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Interfaces
{
    /// <summary>
    /// Логгер
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Запись лога
        /// </summary>
        /// <param name="message"></param>
        void Log(string message);
    }
}
