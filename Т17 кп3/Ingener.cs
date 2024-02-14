using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    /// <summary>
    /// 
    /// </summary>
    internal class Ingener:Staff
    {
        /// <summary>
        /// 
        /// </summary>
        int proekt;
        /// <summary>
        /// 
        /// </summary>
        public int Proekt { get => proekt; set => proekt = value; }
        /// <summary>
        /// 
        /// </summary>
        public Ingener() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="dateB"></param>
        /// <param name="p"></param>
        /// <param name="proekt"></param>
        public Ingener(string name,string surname,DateTime dateB,int p,int proekt):base(name,surname,dateB,p) 
        {
         this.proekt = proekt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Output()
        {
            return $"{base.Output()}Кол-во проектов-{proekt}";
        }
        /// <summary>
        /// метод для расчета дохода
        /// </summary>
        /// <param name="k">коэф повышения</param>
        /// <param name="n">норма</param>
        /// <returns>базовый метод для расчета дохода +4.8*кол-во проектов</returns>
        public override double Doxod(int k,int n)
        {
            return base.Doxod(k,n)+4.8*proekt;
        }
        /// <summary>
        /// Метод для ввода информации об объекте
        /// </summary>
        /// <returns>Конструктор с параметрами</returns>
        new public static Ingener Enter()
        {
            try
            {
                Console.WriteLine("Введите фамилию:");
                string surname = Console.ReadLine();
                Console.WriteLine("Введите имя:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения:");
                DateTime DateB = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Введите мин зп:");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество проектов:");
                int proekt = int.Parse(Console.ReadLine());
                return new Ingener(surname, name, DateB, p, proekt);
            }
            catch { Console.WriteLine("not corect data"); return null; }
        }
    }
}
