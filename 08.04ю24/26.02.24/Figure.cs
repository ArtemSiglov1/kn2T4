using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    /// <summary>
    /// абстрактный класс описывающий фигуру
    /// </summary>
    interface IFigure
    {   
        /// <summary>
        /// свойство названия фигуры
        /// </summary>
        string Name { get; set ; }
        /// <summary>
        /// абстрактный метод нахождения площади
        /// </summary>
        /// <returns>площадь фигуры</returns>
         double Area();
        /// <summary>
        /// абстрактный метод нахождения периметра
        /// </summary>
        /// <returns>периметр</returns>
         double Perimeter();
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        string ToString();
    }
}
