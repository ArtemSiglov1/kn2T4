using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т23кп1
{
    internal class Program
    {
        //enum Months
        //{
        //    январь,
        //    февраль,
        //    март,
        //    апрель,
        //    май,
        //    июнь,
        //    июль,
        //    август,
        //    сентябрь,
        //    октябрь,
        //    ноябрь,
        //    декабрь
        //}
        //enum Days
        //{
        //    Sat,Sun,Mon,Tue,Wed,Thu,Fri
        //}
        static void Main(string[] args)
        {
            //foreach(var month in Enum.GetValues(typeof(Months)))
            //{
            //    Console.WriteLine($"{(int)month}\t{month}");
            //}
            //Console.WriteLine();
            //foreach (var day in Enum.GetValues(typeof(Days)))
            //{
            //    Console.WriteLine($"{day} имеет значение {(int)day}");
            //}
            //Console.WriteLine();
            //Calc calc = new Calc();

            //foreach(var deist in Enum.GetValues(typeof(Calc.Deist))){
            //    Console.WriteLine($"{(int)deist} {deist}");
            //}
            //Console.WriteLine("Выбирите дейстие ");
            //int choise=int.Parse(Console.ReadLine());
            //Console.WriteLine("Ввведите х");
            //double x=double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите у");
            //double y = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Результат = {calc.Calc1(choise, x, y)}");
            //Roles roles = new Roles();
            //while (true)
            //{
            //    foreach (var role in Enum.GetValues(typeof(Roles.UserRole)))
            //    {
            //        Console.WriteLine($"{role}");
            //    }
            //    Console.Write("\nВведите роль: ");
            //    string choise = Console.ReadLine();
            //    roles.Autorizations(choise);

            //    Console.ReadLine();
            //    Console.Clear();
            //}
            Accauntant accauntant = new Accauntant();
            while (true)
            {
                foreach (var i in Enum.GetValues(typeof(Accauntant.Staffs)))
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Введите должность сотрудника:");
                string choise = Console.ReadLine();
                Console.WriteLine("Введите количество отработанных часов:");
                int hours = int.Parse(Console.ReadLine());
                if (accauntant.AskForBonus(accauntant.Choise(choise), hours) == true)
                {
                    Console.WriteLine("Сотруднику положена премия");
                }
                else
                {
                    Console.WriteLine("Сотруднику не положена премия");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}
