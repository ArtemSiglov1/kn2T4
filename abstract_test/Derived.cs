using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_test
{
    internal class Derived:Aclass
    {
        /// <summary>
        /// Вирутальный метод2 из наследуемого класса
        /// </summary>
        public override void Method2()
        {
           base.Method2();
            Console.WriteLine("Вирутальный метод2 из наследуемого класса" );
        }
        /// <summary>
        /// Метод3 класса наслед
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("Метод3 класса наслед");
        }
        /// <summary>
        /// Метод4 класса акласс реализ в наслднике
        /// </summary>
        public override void Method4()
        {
           Console.WriteLine("Метод4 класса акласс реализ в наслднике");
        }
    }
}
