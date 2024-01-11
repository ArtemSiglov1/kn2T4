using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т13кп3
{
    /// <summary>
    /// класс описывающий действия между 2 переменными 
    /// </summary>
    internal class Exp
    {
        /// <summary>
        /// поля описывающие переменные 
        /// </summary>
        float a, b;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Exp() { }
        /// <summary>
        /// конструктор с парметрами 
        /// </summary>
        /// <param name="a">перменная 1</param>
        /// <param name="b">перменная 2</param>
        public Exp(float a, float b) 
        {
         this.A = a; this.B = b;
        }
        /// <summary>
        /// свойство для поля описывающего первую переменную 
        /// </summary>
        public float A { get { return a; } set { this.a = value; } }
        /// <summary>
        /// свойство для поля описывающего вторую переменную 
        /// </summary>
        public float B { get { return b;} set { this.b = value; } }
        /// <summary>
        /// метод для арифметических действий над переменными 
        /// </summary>
        public void Func ()
        {
            Console.WriteLine("Выбери действие 1: /= или 2: +");
            int x=int.Parse(Console.ReadLine());
            switch (x) 
            {
                case 1:Console.WriteLine(a/=b); break;
                case 2:Console.WriteLine(a+b);break;
                
                default: Console.WriteLine("Такого действия не существует"); break;
            }
        }
        /// <summary>
        /// метод для ввода значений переменных
        /// </summary>
        public void Init()
        { 

            this.a=float.Parse(Console.ReadLine());
         this.b=float.Parse(Console.ReadLine());
        }
    }
}
