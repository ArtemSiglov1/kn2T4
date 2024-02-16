using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract2
{
    /// <summary>
    /// 
    /// </summary>
    abstract class BClass:AClass
    {
        /// <summary>
        /// метод для сложения двух целых чисел
        /// </summary>
        /// <param name="h">аргумент 1</param>
        /// <param name="g">аргумент 2</param>
        /// <returns>Сумма двух аргументов</returns>
       public  abstract int Method2(int h, int g);
       
    }
}
