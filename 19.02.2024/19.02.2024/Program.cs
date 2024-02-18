using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string p = "";
            bool flag = true;
            while (flag) 
            {
                Console.WriteLine("Введите национальность:");
                string nation=Console.ReadLine();
                switch(nation)
                {
                    case "R": case "r": {Russian russian=new Russian(); list.Add(Russian.Vvod()); }break;
                    case "M": case "m": { Moldovan moldovan = new Moldovan();list.Add(Moldovan.Vvod()); break; }
                    case "E": case "e": { EnglishMen englishMen = new EnglishMen();list.Add(EnglishMen.Vvod()); }break;
                    default:Console.Clear();flag=false; break;
                }
            }
            foreach (var item in  list) 
            {
                Console.WriteLine(item.Privetstvie(p));
            }
            Console.ReadLine();
        }
    }
}
