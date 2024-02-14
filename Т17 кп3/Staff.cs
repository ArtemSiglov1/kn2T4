using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    /// <summary>
    /// Класс описывающий сотрудника
    /// </summary>
    internal class Staff
    {
        /// <summary>
        /// поля имени и фамилии сотрудника
        /// </summary>
        string name,surname;
        /// <summary>
        /// поле даты рождения
        /// </summary>
        DateTime dateB;
        /// <summary>
        /// поле мин зп
        /// </summary>
        int p;
        /// <summary>
        /// свойство для поля имени
        /// </summary>
        public string Name { get => name==""?"no":name; set => name = value; }
        /// <summary>
        /// свойство для поля фамилии
        /// </summary>
        public string Surname { get => surname==""?"no":surname; set => surname = value; }
        /// <summary>
        /// свойство для поля даты рождения
        /// </summary>
        public DateTime DateB { get => dateB; set => dateB = value; }
        /// <summary>
        /// свойство для поля мин зп
        /// </summary>
        public int P { get => p; set => p = value; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
       

        public Staff() { }
        /// <summary>
        /// конструктор с параметами
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="dateB">дата рождения</param>
        /// <param name="p">мин зп</param>
        public Staff(string name, string surname, DateTime dateB, int p)
        {
            Name = name;
            Surname = surname;
            DateB = dateB;
            P = p; 
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public virtual string Output()
        {
            return $"Name-{name}\nSurname-{surname}\nDate B-{dateB.ToShortDateString()}\nminZp-{p}";
        }
        /// <summary>
        /// метод для расчета дохода
        /// </summary>
        /// <param name="k">коэф повышения</param>
        /// <param name="n">норма</param>
        /// <returns>мин зп*коэф повышения</returns>
        public virtual double Doxod(int k,int n)
        {
            return p*k;
        }
        /// <summary>
        /// Метод для ввода информации об объекте
        /// </summary>
        /// <returns>Конструктор с параметрами</returns>
        public static Staff Enter()
        {
            try
            {
                Console.WriteLine("Введите фамилию:");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите имя:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите мин зп:");
                DateTime DateB = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите коэф повышения:");
                int p = int.Parse(Console.ReadLine());

                return new Staff(surname, name, DateB, p);
            }
            catch { Console.WriteLine("not corect data"); return null; }
        }

    }
}
