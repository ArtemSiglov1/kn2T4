using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т11кп2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books("Капитанская дочь","Пушкин",1836,160);
            Console.WriteLine(books.ToString());
            Bug bug = new Bug("Стрекоза","Насекомые","Тропики,субтропики",60);
            Console.WriteLine(bug.ToString());
            Journal journal = new Journal("США в опасности",139,2001);
            Console.WriteLine(journal.ToString());

            Console.ReadLine();
            
        }
    }
}
