using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т9кп3
{
    internal class z1
    {
        public static void main()
        {
            List<int>list= new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(4,40));
            }
            Show(list);
            double z=SrAr(list);
            Console.WriteLine(z);

        }
        public static void Show(List<int> list) 
        {
            Console.WriteLine("\t");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        static double SrAr(List<int>list) 
        {
            Console.WriteLine("\t");
            int s = 0;
            int d = 0;
            for(int i=0;i<list.Count;i++)
            {
                if (list[i] % 4 == 0)
                {
                    s += list[i];
                    d++;
                }
            }
            return s /d;
        }
    }
}
