using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2] { Price.Init(),Price.Init() };
            Print(prices);
            Console.ReadLine();
        }
        public static void Print(Price[] prices)
        {
            try
            {
                Console.WriteLine("Input NameMagazine:");
                string nameMagazine = Console.ReadLine();
                foreach (var price in prices)
                {
                    if (price.NameMagazine == nameMagazine)
                    {
                        Console.WriteLine(price.ToString());
                        
                    }
                    else { throw new Exception("Такого магазина нет"); }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    
}
