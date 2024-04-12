using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    class Person:IPersonSay,IPersonThink
    {
        public string SayHigh()
        {
            return "Я люблю программирование!";
        }
        public string Think()
        {
            return "А С# больше всего";
        }
        public string SayLow()
        {
            return "Меньше люблю компьютерные игры";
        }
    }
}
