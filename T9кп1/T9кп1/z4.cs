using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9кп1
{
    internal class z4
    {
        public static void main()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                list.Add(rnd.Next(1, 100));
            }
            z2.Show(list);
            Avr(list);
        }
        public static void Avr(List<int> list)
        {
            int s = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 5 == 0)
                {
                    s += list[i];
                    
                }
            }
            Console.WriteLine(s);
        }
    }
    
}
