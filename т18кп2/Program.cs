using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т18кп2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler> abstractHandlers=new List<AbstractHandler>();
            bool flag = true;
            while (flag) 
            {
                Console.WriteLine("Format:");
                string format= Console.ReadLine();
                switch(format) 
                {
                    case"T": case "t": {  abstractHandlers.Add(new TXTHandler()); break; }
                    case"X": case "x": { abstractHandlers.Add(new XMLHandler());break; }
                        case"D": case "d": {  abstractHandlers.Add(new DOCHandler());}break;
                    default:Console.Clear();flag=false ; break;
                }
                
                foreach (var handler in abstractHandlers) 
                {
                    Console.WriteLine("Что вы хотите сделать?");
                    string deist= Console.ReadLine();
                    
                    switch(deist)
                    {
                        case"Open": case "open": { handler.Open(); }break;
                        case "creat": case "Creat": { handler.Create(); }break;
                        case "Change": case "change": { handler.Change(); }break;
                        case "Save": case "save": { handler.Save(); }break;
                            default : Console.Clear();Console.WriteLine("Действия не существует ");break;
                    }
                    
                }
                Console.ReadLine();

               
                
            }
        }
    }
}
