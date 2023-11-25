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

            Watch(list);

            Console.WriteLine($"Кол-во элементов:{list.Count()}");

            Console.WriteLine($"Индекс 25-{list.IndexOf(25)}");

            list.Remove(10);

            Watch(list);

            list.RemoveAt(2);

            Watch(list);

            Find25(list);

            list.Insert(0, 500);

            Watch(list);




        }
        public static void Watch(List<int> ints)

        {

            Console.WriteLine($"\n");

            foreach (int i in ints)

            {

                Console.WriteLine($"{i}");

            }

        }

        public static void Find25(List<int> ints)

        {

            Console.WriteLine($"\n");

            var contains25 = ints.Contains(25);

            Console.WriteLine($"{contains25}");
        }
    }
}
