using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Т9кп3
{
    internal class z2
    {
        public static void main() 
        {
            List<double> list = new List<double>();
            Random rnd = new Random();
            for(int i=0; i<10; i++)
            {
                list.Add(rnd.NextDouble()*5+5);
            }
            Show(list);
            Sev(list);
        }
       public static void Show(List<double> list)
        {
            Console.WriteLine("\t");
            foreach(var item in list) 
            {
             Console.WriteLine(item);
            }
        }
        static void Sev(List<double>list) 
        {
         int i=0; 
            for(int  j=0; j<list.Count; j++)
            {
                if (list[j]>7)
                {
                    i++;
                }
            }
            Console.WriteLine($"Кол-во элементов больше 7-{i}");
        }
    }
}
