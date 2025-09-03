using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Restaurant_Automation;

namespace Restaurant_Automation
{
    internal class Menü
    {

        internal string food;
        internal double foodPrice;

        internal static List<Menü> Products = new List<Menü>()
        {

            new Menü{food = "Margaritta Pizza",foodPrice = 200 },
            new Menü{food = "Karışık Pizza",foodPrice = 300 },
            new Menü{food = "Ton Balıklıklı ve Karidesli Pizza",foodPrice = 390 },
           new Menü{food= "Çoban Salata",foodPrice = 150 },
           new Menü{food= "Sezar Salata",foodPrice = 290 },
           new Menü{food= "Hellim Peynir Salata",foodPrice = 250 },
           new Menü{food = "Çikolata Krokanlı Pasta",foodPrice = 130 },
           new Menü{food = "Çikolatalı Çilekli Pasta",foodPrice = 150 },
           new Menü{food = "Orman Meyveli Pasta",foodPrice = 120 },
           new Menü{food = "DoubleBurger",foodPrice = 430 },
           new Menü{food = "SmashBurger",foodPrice = 500 },
           new Menü{food = "TripleBurger",foodPrice = 480 },
           new Menü{food= "Çilekli Limonata",foodPrice = 130 },
           new Menü{food= "İce Tea",foodPrice = 100 },
           new Menü{food= "Kola",foodPrice = 100 },
           new Menü{food= "Latte",foodPrice = 120 },
           new Menü{food= "Çay",foodPrice = 50 },
           new Menü{food= "Türk Kahvesi",foodPrice = 120 },
        };
        internal static void Menu()
        {
            Console.WriteLine("--- MENÜ ---\n");
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + Products[i].food + " = " + Products[i].foodPrice);
            }
            Console.WriteLine("\nLÜTFEN SİPARİŞ EDECEĞİNİZ ÜRÜN NUMARASINI GİRİNİZ");
            string product = Console.ReadLine()!;
            if (int.TryParse(product, out int productNumber)&& productNumber >0 && productNumber<=Products.Count) 
            {
                Menü selectedProduct = Products[productNumber - 1];

            }
            else 
            {
                string message = "Menü Paneli";
                Program.ErrorMainMenuTransfer(message);
                Console.Clear();
                Menu();
            }

        }
    }
}