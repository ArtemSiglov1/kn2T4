using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace кп4т19_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patch = @"C:\Users\Home\Documents\Register.txt";
            List<Omissions> register = new List<Omissions>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(patch, FileMode.Open))
            {
                register= (List<Omissions>)formatter.Deserialize(fs);
            }
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Меню:\n1.Вывести информацию, содержащуюся в коллекции register.\n2.Вывести информацию о тех пропусках, которые должны быть аннулированы.\n" +
                    "3. Вывести информацию о тех пропусках, которые должны быть обновлены.\n" +
                    "4.Add Omission Student" +
                    "5.Add Omission Builder" +
                    "6.Add Omission Teacher" +
                    "0.Exit");
                int deist = int.Parse(Console.ReadLine());
                switch (deist)
                {
                    case 1: OutPut(register); break;
                    case 2: OutPutDel(register); break;
                    case 3: OutPutUpdate(register); break;
                    case 4: register.Add(OmissionsStudent.Init()); break;
                    case 5: register.Add(OmissionsBuilder.Init()); break;
                    case 6: register.Add(OmissionsTeacher.Init()); break;
                    case 0: flag = false; break;
                    default:
                        Console.WriteLine("Error");break;
                }
            }
            SaveOmissions(patch,register);
            Console.ReadLine();
        }
        /// <summary>
        /// метод для сохранения информации о пропусках в файл
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="list"></param>
        public static void SaveOmissions(string fileName,List<Omissions> list)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(fs, list);
            }
        }
        
       /// <summary>
       /// метод для вывода информации из листа
       /// </summary>
       /// <param name="list">лист пропусков</param>
        public static void OutPut(List<Omissions>list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        /// <summary>
        /// метод для вывода информации о тех пропусках, которые должны быть аннулированы
        /// </summary>
        /// <param name="list">лист пропусков</param>
        public static void OutPutDel(List<Omissions>list)
        {

            foreach ( var item in list)
            {

                if (item is OmissionsBuilder|| item is OmissionsStudent )
                {
                    item.CompleteUpdateOrDeleteOmissions();
                }
            }
        }
        /// <summary>
        /// метод для вывода информации о тех пропусках, которые должны быть обновлены
        /// </summary>
        /// <param name="list">лист пропусков</param>
        public static void OutPutUpdate(List<Omissions> list)
        {
            foreach(var item in list)
            {
                if(item is OmissionsTeacher)
                {
                    item.CompleteUpdateOrDeleteOmissions();
                }
            }
        }
       
    }
}
