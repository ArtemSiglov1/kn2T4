using System;
//подключаю библиотеку для создания листа
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кп4т19
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаю лист
            List<TurFirma> turFirmas = new List<TurFirma>() {
                //заполняю лист
                new TurFirma("Android",1999,"h142k45",1500000),
                new TurFirma("Fly",2001,"r5456l34",2000000),
                new TurFirma("train",2006,"if23423k45",1000000)
            };
            //3. Для заданной фирмы найти ИНН и прибыль за текущий год.
            while (true)
            {
                Console.WriteLine("1. Для заданной фирмы найти ИНН и прибыль за текущий год.\n2.Найти суммарную прибыль всех фирм.\n3.Выяснить, какая из фирм получила наибольшую прибыль и каков размер этой прибыли.\n4.Удалить из коллекции информацию об обанкротившейся фирме.\n5.Добавить в коллекцию информацию о новой фирме.\n6.Отсортировать коллекцию, содержащую информацию о туристических фирмах города, по размеру прибыли за текущий год.");
                int deist = int.Parse(Console.ReadLine());
                switch (deist)
                {
                    case 1:
                        Console.WriteLine("Введите название тур фирмы");
                        string name = Console.ReadLine();
                        bool notfind = false;
                        foreach (var firm in turFirmas)
                        {
                            if (firm.Name == name)
                            {
                                Console.WriteLine($"{firm.INN} {firm.SalaryOfTheYear}");
                                notfind = true;
                            }
                            
                        }
                        if (notfind == false)
                        {
                           
                                Console.WriteLine("Firma not foind");
                            
                        }
                        break;
                    //4. Найти суммарную прибыль всех фирм.
                    case 2:
                        foreach (var firm in turFirmas)
                        {
                            int allSalary = 0;
                            allSalary += firm.SalaryOfTheYear;
                            Console.WriteLine(allSalary);
                        }
                        break;
                    //5. Выяснить, какая из фирм получила наибольшую прибыль и каков размер этой прибыли
                    case 3:
                        turFirmas.Sort();
                        Console.WriteLine($"{turFirmas[turFirmas.Count - 1].Name} {turFirmas[turFirmas.Count - 1].SalaryOfTheYear}");
                        break;
                    //6.Удалить из коллекции информацию об обанкротившейся фирме.
                    case 4:
                        TurFirma tur = null;
                        foreach (var item in turFirmas)
                        {
                            if (item.SalaryOfTheYear == 0)
                            {
                                tur = item;
                            }
                        }
                        turFirmas.Remove(tur);
                        break;
                    case 5:
                        turFirmas.Add(TurFirma.Init());
                        break;
                    case 6:
                        turFirmas.Sort();
                        break;
                    case 7:return;
                    default:Console.WriteLine("Retry");break;
                }
            }
        }
    }
}
