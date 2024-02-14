using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    /// <summary>
    /// наследуемый класс описывающий менеджера
    /// </summary>
    internal class Meneger:Staff
    {
        
        /// <summary>
        /// поле объема проданной продукции
        /// </summary>
        int ob;
        /// <summary>
        /// свойство для поля объема
        /// </summary>
        public int Ob { get => ob; set => ob = value; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Meneger() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="dateB">дата рождения</param>
        /// <param name="p">мин зп</param>
        /// <param name="ob">объем</param>
        public Meneger(string name, string surname, DateTime dateB, int p, int ob) : base(name,surname,dateB,p)
        {
            this.ob = ob;
        }
        /// <summary>
        /// метод для вывода инф об объекте
        /// </summary>
        /// <returns>базовый метод для вывода и поля наследуемого класса</returns>
        public override string Output() 
        {
            return $"{base.Output()} {ob}";
        }
        /// <summary>
        /// метод для расчета дохода
        /// </summary>
        /// <param name="k">коэф повышения</param>
        /// <param name="n">норма</param>
        /// <returns>
        /// базовый метод доход+1процент от нормы
        /// базовый доход
        /// </returns>
        public override double Doxod(int k,int n)
        {
            
            
            if (ob > n)
            {
                return base.Doxod(k, n)+(n*0.01);
            }
            else
            {
                return base.Doxod(k, n) ;
            }
        }
        /// <summary>
        /// Метод для ввода информации об объекте
        /// </summary>
        /// <returns>Конструктор с параметрами</returns>
        new public static Meneger Enter()
        {
            try
            {
                Console.WriteLine("Введите фамилию:");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите имя:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения:");
                DateTime DateB = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите Мин зп:");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите проданный объем:");
                int ob = int.Parse(Console.ReadLine());
                return new Meneger(surname, name, DateB, p, ob);
            }
            catch { Console.WriteLine("not corect data"); return  null ;}
        }
    }
}
