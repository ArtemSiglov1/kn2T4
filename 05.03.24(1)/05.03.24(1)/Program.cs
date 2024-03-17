using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FreeSoftWare free = new FreeSoftWare("Notepad++ Team", "Notepad++");
            TrialSoftWare trial = new TrialSoftWare("Adobe", "Adobe Photoshop", new DateTime(2024,02,14),new DateTime(2024,03,14));
            CommercialSoftWare commercial = new CommercialSoftWare("Microsoft", "Microsoft Office", new DateTime(2024,02,28), 200, new DateTime(2025,02,28));
            List<SoftWare> softWares = new List<SoftWare>() {free,trial,commercial};
            foreach(var item in softWares)
            {
             Console.WriteLine(item.ToString());
            }
            foreach(var item in softWares)
            {
                Console.WriteLine(item.IsUsableOnDate());
            }
            Console.ReadLine();
        }
    }
}
