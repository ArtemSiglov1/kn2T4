using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_test
{
    abstract class Aclass
    {
        /// <summary>
        /// обычный метод с именем метод1 абстрактного класса акласс
        /// </summary>
        public void Method1()
        {
            Console.WriteLine("обычный метод с именем метод1 абстрактного класса акласс");
        }
        /// <summary>
        /// Виртуальный метод метод2 из абстрактоного класса акласс
        /// </summary>
        public virtual void Method2()
        {
            Console.WriteLine("Виртуальный метод метод2 из абстрактоного класса акласс");
        }
        /// <summary>
        /// абстрактный метод3 из класса акласс
        /// </summary>
        public abstract void Method3();
        /// <summary>
        /// абстрактный метод4 из класса акласс
        /// </summary>
        public abstract void Method4();
        //public abstract string Name { get; set; }
    }
}
