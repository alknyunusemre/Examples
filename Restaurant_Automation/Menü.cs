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
        #region Menü Name
        internal static List<string> pizza = new List<string> { "Margaritta", "Karışık Pizza", "Ton Balıklı ve Karidesli Pizza" };
        internal static List<string> salad = new List<string> { "Çoban Salata", "Sezar Salata", "Ton Balıklı Salata" };
        internal static List<string> cake = new List<string> { "Frambuazlı Pasta", "Limonlu Cheesecake", "Çikolatalı Pasta" };
        internal static List<string> hamburger = new List<string> { "Cheeseburger", "Veganburger", "Şef'in Special'i" };
        internal static List<string> icedrinks = new List<string> { "Kola", "Gazoz", "Ayran" };
        internal static List<string> hotdrinks = new List<string> { "Çay", "Espresso", "Latte" };
        #endregion
        #region Menü Price
        internal static List<int> pizzaprice = new List<int> { 250, 300, 350 };
        internal static List<int> saladprice = new List<int> { 150, 250, 250 };
        internal static List<int> cakeprice = new List<int> { 100, 100,100 };
        internal static List<int> hamburgerprice = new List<int> { 300,300,350 };
        internal static List<int> icedrinksprice = new List<int> { 70, 70,30 };
        internal static List<int> hotdrinksprice = new List<int> { 45, 70,150 };
        #endregion
        internal static void Menu()
        {
            Console.WriteLine("--- MENÜ ---\n");
            Console.WriteLine("1- YİYECEKLER");
            Console.WriteLine("2- İÇECEKLER");
            Console.WriteLine("3- TATLILAR\n");
            Console.WriteLine("SEÇİMİNİZİ YAPINIZ(1/2/3)");
            string select = Console.ReadLine()!;
            int selected;
            if (int.TryParse(select, out selected))
            {
                switch (selected)
                {
                    case 1:
                        Console.WriteLine("--- YİYECEKLER ---\n");
                        Console.WriteLine("1. PİZZA");
                        Console.WriteLine("2. SALATA");
                        Console.WriteLine("3. HAMBURGER");
                        Console.WriteLine("Lütfen Seçiminizi Yapınız(1/2/3)");
                        string food = Console.ReadLine()!;
                        int foods;
                        if (int.TryParse(food, out foods))
                        {
                            if (foods == 1)
                            {
                                Console.WriteLine("--- PİZZA ---");
                                for (int i = 0; i < pizza.Count; i++)
                                {
                                    Console.WriteLine((i + 1) + "." + pizza[i]+" = " + pizzaprice[i]);
                                }
                            }
                            else if (foods == 2) 
                            {
                                Console.WriteLine("--- SALATALAR ---");
                                for (int i = 0; i < salad.Count; i++)
                               {
                                    Console.WriteLine((i + 1) + "." + salad[i] + " = " + saladprice[i]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("--- HAMBURGERLER ---");
                                for (int i = 0; i < hamburger.Count; i++)
                                {
                                    Console.WriteLine((i + 1) + "." + hamburger[i] + " = " + hamburgerprice[i]);
                                }
                            }
                            //*********************************************BURADA KALDINNNNNN**************************************************************************
                            Console.WriteLine("SİPARİŞ VERMEK İÇİN ÜRÜN BAŞINDA BULUNAN NUMARAYI GİRİNİZ...");
                            string order = Console.ReadLine()!;
                            int orders;
                            if (int.TryParse(order, out orders)) 
                            {

                            }
                            else 
                            {
                                string message = "Menü Paneli";
                                Program.ErrorMainMenuTransfer(message);
                                Console.Clear();
                                Menu();
                            }
                        }
                        else
                        {
                            string message = "Menü Paneli";
                            Program.ErrorMainMenuTransfer(message);
                            Console.Clear();
                            Menu();
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("--- İÇECEKLER ---");
                        Console.WriteLine("1. Soğuk İçecekler");
                        Console.WriteLine("2. Sıcak İçecekler");
                        Console.WriteLine("Lütfen Seçiniz");
                        string drink = Console.ReadLine()!;
                        int drinks;
                        if(int.TryParse(drink, out drinks))
                        {
                            switch (drinks) 
                            {
                                case 1:
                                    Console.WriteLine("--- SOĞUK İÇECEKLER ---");
                                    for (int i = 0; i < icedrinks.Count; i++)
                                    {
                                        Console.WriteLine((i + 1) + "." + icedrinks[i] + " = " + icedrinksprice[i]);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("--- SICAK İÇECEKLER ---");
                                    for (int i = 0; i < hotdrinks.Count; i++)
                                    {
                                        Console.WriteLine((i + 1) + "." + hotdrinks[i] + " = " + hotdrinksprice[i]);
                                    }
                                    break;
                            }
                        }
                        else 
                        {                          
                            string message = "Menü Paneli";
                            Program.ErrorMainMenuTransfer(message);
                            Menu();
                        }

                            break;
                    case 3:
                        Console.WriteLine("--- TATLILAR ---");
                        for (int i = 0; i < cake.Count; i++)
                        {
                            Console.WriteLine((i + 1) + "." + cake[i] + " = " + cakeprice[i]);
                        }
                        break;
                }
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
