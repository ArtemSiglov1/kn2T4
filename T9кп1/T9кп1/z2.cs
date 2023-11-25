using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9кп1
{
    internal class z2
    {
        public static void main()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                list.Add(rnd.Next(1, 100));
            }
            Show(list);
            Del(list);
            Show(list);
        }
        public static void Show(List<int> list)
        {
            Console.WriteLine($"\n");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
         static void Del(List<int> list )
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]%2!=0)
                {
                    list.RemoveAt(i);
                    //i--;
                }
            }
        }
    }
}
