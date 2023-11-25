using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9кп1
{
    internal class z1
    {
        public static void main()
        {
            List<int> list = new List<int>();

            list.Add(1);

            list.Add(10);

            list.Add(25);

            list.Add(17);

            list.Add(10);

            z2.Show(list);

            Console.WriteLine($"Кол-во элементов:{list.Count()}");

            Console.WriteLine($"Индекс 25-{list.IndexOf(25)}");

            list.Remove(10);

            z2.Show(list);         

            list.RemoveAt(2);

            z2.Show(list);

            Find25(list);

            list.Insert(0, 500);

            z2.Show(list);




        }
        

        

        public static void Find25(List<int> list)

        {

            Console.WriteLine($"\n");

            var contains25 = list.Contains(25);

            Console.WriteLine($"{contains25}");
        }
    }
}
