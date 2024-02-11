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
            Console.WriteLine(N);
        }
        /// <summary>
        /// метод для рассчета дохода с учетом количетсва проекта
        /// </summary>
        /// <returns></returns>
        public override int Doxod()
        {
           return base.Doxod()*(n/10);
        }
        
    }
}
