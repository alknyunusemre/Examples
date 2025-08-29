using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Automation
{
    internal class Menü
    {
        internal static List<string> pizza = new List<string> {"Margaritta","Karışık"};
        internal static List<string> salata = new List<string> { "Çoban Salata", "Sezar Salata","Ton Balıklı Salata" };

        internal static void Menu()
        {
            Console.WriteLine("--- MENÜ ---\n");
            Console.WriteLine("1- YİYECEKLER");
            Console.WriteLine("2- İÇECEKLER");
            Console.WriteLine("3- TATLILAR\n");
            Console.WriteLine("SEÇİMİNİZİ YAPINIZ");
            string select = Console.ReadLine()!;
            int selected;
            if(int.TryParse(select, out selected)) 
            {
                switch (selected) 
                {
                    case 1:
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }

        }
    }

}
