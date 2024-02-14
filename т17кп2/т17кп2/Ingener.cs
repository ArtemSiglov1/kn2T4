using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2
{
    /// <summary>
    /// наследуемый класс описывающий инженера
    /// </summary>
    partial class Ingener:Staff
    {
        /// <summary>
        /// поле описывающее количество проектов
        /// </summary>
        int n;
         /// <summary>
         /// свойство для поля количества объектов 
         /// </summary>
        public int N { get => n; set => n = value; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Ingener() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="p">мин зп</param>
        /// <param name="k">коэф повышения</param>
        /// <param name="n">кол-во проектов</param>
        public Ingener(string surname,string name,int p,int k,int n):base(surname, name,p,k)
        {
            N = n;
        }
        /// <summary>
        /// метод для вывода инфы об объекте
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Proects-{n}");
        }
        /// <summary>
        /// метод для рассчета дохода с учетом количетсва проекта
        /// </summary>
        /// <returns></returns>
        public override int Doxod()
        {
            if (n > 10)
            {
                return base.Doxod() * (n / 10);
            }
            else { return base.Doxod(); }
        }
        /// <summary>
        /// Метод для ввода информации об объекте
        /// </summary>
        /// <returns>Конструктор с параметрами</returns>
       new public static Ingener Enter()
        {
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя:"); 
            string name= Console.ReadLine();
            Console.WriteLine("Введите мин зп:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф повышения:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество проектов:");
            int n=int.Parse(Console.ReadLine());
            return new Ingener(surname, name, p, k, n);
        }
        
    }
}
