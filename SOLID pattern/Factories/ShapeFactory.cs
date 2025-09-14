using SOLID_pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_pattern.Factories
{
    public class ShapeFactory
    {
        // readonly защищает от замены листа в этом классе
        // private защищает от записи из вне
        private readonly List<ShapeOption> _options = new();

        // Отдаём список только на чтение
        public IReadOnlyList<ShapeOption> Options => _options.AsReadOnly();
        //Эквивалентно
        //public IReadOnlyList<ShapeOption> Options
        //{
        //    get { return _options.AsReadOnly(); }
        //}

        /// <summary>
        /// Метод регистрации фигуры
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="create">Функция создания</param>
        public void Register(string name, Func<IShape?> create)
        {
            _options.Add(new ShapeOption(name, create));
        }

        /// <summary>
        /// Выбираем фигуру по индексу
        /// </summary>
        /// <param name="choice"> индекс фигуры</param>
        /// <returns></returns>
        public IShape? Create(int choice)
        {
            return choice >= 1 && choice <= _options.Count
                ? _options[choice - 1].Create()
                : null;
        }
    }
}
