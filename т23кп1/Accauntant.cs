using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т23кп1
{
    internal class Accauntant
    {
        public enum Staffs
        {
            Manager = 200,
            Teacher = 250,
            Builder = 150,
            Programmer = 100
        }
        public bool AskForBonus(Staffs worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public Staffs Choise(string choise)
        {
            try
            {
                switch (choise.ToLower())
                {
                    case "manager": return Staffs.Manager;
                    case "teacher": return Staffs.Teacher;
                    case "builder": return Staffs.Builder;
                    case "programmer": return Staffs.Programmer;
                    default: throw new Exception("Такой должности не существует");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 0; }

        }
    }
}
