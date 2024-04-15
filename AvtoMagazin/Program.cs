using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoMagazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Katalog> katalogs=new List<Katalog>() {new Katalog(20,"BMW",330,100000,10),new Katalog(21,"Mersedes",320,80000,5),new Katalog(23,"Alpina",350,200000,3) };
            foreach(Katalog katalog in katalogs)
            {
                Console.WriteLine(katalog.ToString());
            }
            katalogs.Sort();
            Console.WriteLine("\nSort is Complete\n");
            foreach (Katalog katalog in katalogs)
            {
                Console.WriteLine(katalog.ToString());
            }
            Console.ReadLine();
        }
    }
}
