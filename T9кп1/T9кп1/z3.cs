using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9кп1
{
    internal class z3
    {
         public static void main()
        {
            List<int> list = new List<int>();
            Random rnd=new Random();
            for (int i = 0;i<20;i++)
            {
                list.Add(rnd.Next(1,14));
            }
            z2.Show(list);
            Del(list);
            z2.Show(list);
        }
        
        public static void Del(List<int> list)
        {
            Console.WriteLine("Введите n=");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<list.Count;i++)
            {
                if (list[i]==n)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
