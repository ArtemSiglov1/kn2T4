using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Goods> list = new List<Goods>
            {
                new Product("Молоко", 100, new DateTime(2024, 03, 31), new DateTime(2024, 04, 02)),
                new Party("Яблоко", 200, 10, new DateTime(2024, 03, 31), new DateTime(2024, 06, 20)),
                new Kit("Подарочный набор", 500, new List<string> { $"Продукты:\n- Шоколад\n- Печенье" })
            };
           
            foreach (var item in list)
            {
                
                Console.WriteLine(item.ToString());
            }
            foreach(var elem in list)
            {
                Console.WriteLine(elem.DeadlineExpirationDate());
            }
           
            Console.ReadLine();
            
        }
    }
}
