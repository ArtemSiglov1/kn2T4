using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2
{
    /// <summary>
    /// базовый класс описывающий сотрудника
    /// </summary>
     class Staff
    {
       /// <summary>
       /// поля описывающие фамилию имя 
       /// </summary>
        string surname, name;
        /// <summary>
        /// поля описывающие мин зп и коэфицент повышения
        /// </summary>
        int p,k;
        /// <summary>
        /// свойство для поля фамилии
        /// </summary>
        public string Surname { get => surname; set => surname = value; }
        /// <summary>
        /// свойства для поля имени
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// свйоство для поля мин зп
        /// </summary>
        public int P { get => p; set => p = value; }
        /// <summary>
        /// свойство для поля коэфицента повышения
        /// </summary>
        public int K { get => k; set => k = value; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Staff() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="p">мин зп</param>
        /// <param name="k">коэф повышения</param>
        public Staff(string surname, string name, int p, int k)
        {
            Surname = surname;
            Name = name;
            P = p;
            K = k;
        }
        /// <summary>
        /// виртуальный метод для вывода инфы об объекте
        /// </summary>
        virtual public void Print()
        {
            Console.Write($"{surname}\n{name}\n{p}\n{k}\n"); 
        }
        /// <summary>
        /// метод для рассчета дохода 
        /// </summary>
        /// <returns>мин зп * коэф повышения</returns>
        public virtual int Doxod()
        {
            return k*p;
        }
      
    }
}
