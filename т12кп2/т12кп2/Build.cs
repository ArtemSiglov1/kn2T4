using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп2
{
    /// <summary>
    /// класс описывающий проект строения
    /// </summary>

    internal class Build
    {
        
            /// <summary>
            /// поле описывающее имя объекта 
            /// </summary>
            public string name;
            /// <summary>
            /// поле описывающее площадь объекта
            /// </summary>
            public double area;
            /// <summary>
            /// поле описывающее количетсва жильцов 
            /// </summary>
            public int kvo;
            /// <summary>
            /// Поле описывающее кол-во этажей
            /// </summary>


            public int floor;
            /// <summary>
            /// конструктор по умолчанию 
            /// </summary>
            public Build() { }
            /// <summary>
            /// конструктор с параметрами строения 
            /// </summary>
            /// <param name="name">название </param>
            /// <param name="area">площадь</param>
            /// <param name="kvo">количество жильцов</param>
            public Build(string name, double area, int kvo)
            {
                this.name = name;
                this.area = area;
                this.kvo = kvo;
            }
            /// <summary>
            /// Метод вывода инф-ии про объект и площади на одного жильца
            /// </summary>
            /// <returns>площадь выделяемая на одного жильца</returns>
            public double Showinfo()
            {
                Console.WriteLine($"Имя объекта:{name}\t Площадь объекта:{area}\t Количество жильцов:{kvo}\t");
                return area / kvo;
            }
            /// <summary>
            /// конструктор с параметрами
            /// </summary>
            /// <param name="name">имя проекта </param>
            /// <param name="area">площадь проекта </param>
            /// <param name="kvo">количество жильцов</param>
            /// <param name="floor">количество этажей</param>
            public Build(string name, double area, int kvo, int floor) : this(name, area, kvo)
            {
                this.floor = floor;
            }

           
    }
}

