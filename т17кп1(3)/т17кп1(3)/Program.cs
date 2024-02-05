using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine(),material=Console.ReadLine();
                int k=int.Parse(Console.ReadLine());
           
            Notebook notebook = new Notebook(name,k);
            notebook.Print();
            Console.WriteLine(notebook.Price());
            AllNotebook allNotebook=new AllNotebook(name,k,material);
            allNotebook.Print();
            Console.WriteLine(allNotebook.Price());
            Notebook notebook1=new AllNotebook(name,k,material);
            allNotebook.Print();
            Console.WriteLine(notebook1.Price());
            Console.Read();
        }
        
    }
}
