using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9кп1
{
    internal class z5
    {
        public static void main()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(-100, 100));
            }
            z2.Show(list);
            Parce(list);
            z2.Show(list);

        }
        static void Parce(List<int>list)
        {
            for (int i = 0;i<list.Count;i++)
            {
                if (list[i] < 0)
                {
                    list.Insert(i+1, 10);
                }
            }
        }
    }
}
