using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace т15кп1
{
    internal class Sportiki
    {
        /// <summary>
        /// поля описывающие ФИО
        /// </summary>
        string surname, name, otchestvo;
        /// <summary>
        /// Поля описывающие рост и вес спортсмена
        /// </summary>
        double height, weight;
        /// <summary>
        /// поля описывающее счетчик
        /// </summary>
        public static int count;
        /// <summary>
        /// свойство поля фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                string x = Surname == "" ? "Фамилии нет" : surname;
                return x;
            }
            set { surname = value; }
        }
        /// <summary>
        /// свойство поля имя
        /// </summary>
        public string Name
        {
            get
            {
                string x = Name == "" ? "Имени нет" : name;
                return x;
            }
            set { name = value; }
        }
        /// <summary>
        /// свойство поля отчество
        /// </summary>
        public string Otchestvo
        {
            get
            {
                string x = Otchestvo == "" ? "Имени нет" : otchestvo;
                return x;
            }
            set { otchestvo = value; }
        }
        /// <summary>
        /// свойство поля рост
        /// </summary>
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>
        /// свойство поля вес
        /// </summary>
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Sportiki() { }
        /// <summary>
        /// конструктор для инициализаци счетчика
        /// </summary>
        static Sportiki()
        {
            count = 0;
        }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="otchestvo">отчество</param>
        /// <param name="height">рост</param>
        /// <param name="weight">вес</param>
        public Sportiki(string surname, string name, string otchestvo, double height, double weight)
        {
            Surname = surname;
            Name = name;
            Otchestvo = otchestvo;
            Height = height;
            Weight = weight;
            if (Weight>70)
            {
                count++;
            }
            
        }
        /// <summary>
        /// метод для вывода информации о спортсменах
        /// </summary>
        /// <returns>ФИО,рост,вес</returns>
        public override string ToString()
        {
            return $"Surname-{surname}\nName-{name}\nOtchestvo-{otchestvo}\nHeight-{height}\nWeight-{weight}\n";
        }
       
    }
}
