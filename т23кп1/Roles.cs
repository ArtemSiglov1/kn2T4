using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace т23кп1
{
    internal class Roles
    {
       public enum UserRole
        {
            Администратор, Модератор, Пользователь, Гость
        }
        public void Autorizations(string choise)
        {
            try {
                switch (choise.ToLower()) {
                    case "admin": case "администратор":
                        Console.WriteLine($"Вы зарегистрированы как {UserRole.Администратор}");
                        break;
                    case "moder": case "модератор":
                        Console.WriteLine($"Вы зарегистрированы как {UserRole.Модератор}");
                        break;
                    case "user": case "пользователь":
                        Console.WriteLine($"Вы зарегистрированы как {UserRole.Пользователь}");
                        break;
                    case "guest": case "гость":
                        Console.WriteLine($"Вы зарегистрированы как {UserRole.Гость}");
                        break;
                    default: throw new Exception("Такой учетной записи не существует");
                }
                
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }

    }
}
