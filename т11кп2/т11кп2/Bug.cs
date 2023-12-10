using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т11кп2
{
    /// <summary>
    /// класс описывающий насекомого 
    /// </summary>
    internal class Bug
    {
        /// <summary>
        /// поля описывающие название , пищу ,среду обитания
        /// </summary>
        public string name, eat, areal;
        /// <summary>
        /// поле описывающее скорость передвижения 
        /// </summary>
        public double speed;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Bug() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="eat">пища</param>
        /// <param name="areal">среда обитания</param>
        /// <param name="speed">скоросмть передвижения</param>
        public Bug(string name, string eat, string areal, double speed)
        {
            this.name = name;
            this.eat = eat;
            this.areal = areal;
            this.speed = speed;
        }
        /// <summary>
        /// метод для вывода информации о насекомом
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return $"Название насекомого-{name}\t скорость передвижения-{speed}км.ч\t пища-{eat}\t среда обитания-{areal}";
        }
    }
}
