using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaExam
{
    internal struct Price
    {
        string nameProduct;
        string nameMagazine;
        int priceBYN;
        public Price(string nameProduct, string nameMagazine,int priceBYN)
        {
            NameProduct = nameProduct;
            NameMagazine=nameMagazine;
            PriceBYN =priceBYN;
        }

        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string NameMagazine { get => nameMagazine; set => nameMagazine = value; }
        public int PriceBYN { get => priceBYN; set => priceBYN = value; }

        public static Price Init()
        {
            Console.WriteLine("Введите название продукта");
            string nameProduct = Console.ReadLine();
            Console.WriteLine("Введите название магазина");
            string nameMagazine = Console.ReadLine();
            Console.WriteLine("Введите цену в бани");
            int priceBYN = int.Parse(Console.ReadLine());
            return new Price(nameProduct, nameMagazine, priceBYN);
        }
        public override string ToString()
        {
            return $"{nameProduct} {nameMagazine} {priceBYN}";
        }
       
    }
}
