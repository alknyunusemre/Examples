using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Restaurant_Automation;
using Restaurant_Automation;

namespace Restaurant_Automation
{
    internal class Menü
    {
        #region --- TANIMLANAN ÜRÜNLER ---
        internal string pizza;
        internal string salad;
        internal string cake;
        internal string hamburger;
        internal string icedrink;
        internal string hotdrink;
        #endregion

        #region --- TANIMLANAN ÜRÜN FİYATLARI---
        internal double pizzaPrice;
        internal double saladPrice;
        internal double cakePrice;
        internal double hamburgerPrice;
        internal double icedrinkPrice;
        internal double hotdrinkPrice;
        #endregion

        #region --- MENÜDEKİ ÜRÜN LİSTELERİ ---
        internal static List<Menü> Pizza = new List<Menü>()
        {
            new Menü{pizza = "Margaritta Pizza",pizzaPrice = 200 },
            new Menü{pizza = "Karışık Pizza",pizzaPrice = 300 },
            new Menü{pizza = "Ton Balıklıklı ve Karidesli Pizza",pizzaPrice = 390 },
        };
        internal static List<Menü> Salad = new List<Menü>()
        {
           new Menü{salad= "Çoban Salata",saladPrice = 150 },
           new Menü{salad= "Sezar Salata",saladPrice = 290 },
           new Menü { salad = "Hellim Peynir Salata", saladPrice = 250 },
        };

        internal static List<Menü> Cake = new List<Menü>()
        {
           new Menü { cake = "Çikolata Krokanlı Pasta", cakePrice = 130 },
           new Menü { cake = "Çikolatalı Çilekli Pasta", cakePrice = 150 },
           new Menü { cake = "Orman Meyveli Pasta", cakePrice = 120 },
        };
        internal static List<Menü> Hamburger = new List<Menü>()
        {
           new Menü { hamburger = "DoubleBurger", hamburgerPrice = 430 },
           new Menü { hamburger = "SmashBurger", hamburgerPrice = 500 },
           new Menü { hamburger = "TripleBurger", hamburgerPrice = 480 },
        };
        internal static List<Menü> Icedrink = new List<Menü>()
        {
            new Menü { icedrink = "Çilekli Limonata", icedrinkPrice = 130 },
           new Menü { icedrink = "İce Tea", icedrinkPrice = 100 },
           new Menü { icedrink = "Kola", icedrinkPrice = 100 },
        };
        internal static List<Menü> Hotdrink = new List<Menü>()
        {
            new Menü { hotdrink = "Latte", hotdrinkPrice = 120 },
           new Menü { hotdrink = "Çay", hotdrinkPrice = 50 },
           new Menü { hotdrink = "Türk Kahvesi", hotdrinkPrice = 120 },
        };
        #endregion

        #region --- MENÜ PANELİ ---
        internal static void Menu()
        {
            // --- ANA MENÜ ---

            Console.WriteLine("--- MENÜ ---\n");
            Console.WriteLine("1. YİYECEKLER");
            Console.WriteLine("2. İÇECEKLER");
            Console.WriteLine("3. TATLILAR");
            Console.WriteLine("LÜTFEN SEÇİMİNİZİ YAPINIZ(Çıkış için '0'a basınız)".ToUpper());
            string select = Console.ReadLine()!;
            if (int.TryParse(select, out int selected))
            {

                // KATEGORİK MENÜ

                switch (selected) 
                {
                    case 1:
                        Console.WriteLine("\n - YİYECEK MENÜSÜ -\n");
                        Console.WriteLine("1 - PİZZALAR\n2- SALATALAR\n3- HAMBURGERLER");
                        Console.WriteLine("SEÇİM YAPINIZ(ANA MENÜYE DÖNMEK İÇİN '0'A BASINIZ)");
                        string foodselect = Console.ReadLine()!;
                        if(int.TryParse(foodselect, out int foodselected)) 
                        {
                            int no = 1;
                            switch (foodselected) 
                            {

                                //PİZZA MENÜSÜ

                                case 1:                                             
                                    foreach (Menü pizzas in Pizza) 
                                    {
                                        
                                        Console.WriteLine("\n"+no+". "+pizzas.pizza+"   =====>  FİYAT: "+pizzas.pizzaPrice);
                                        no++;
                                    }
                                    Console.WriteLine("");  
                                    break;

                                    //SALATA MENÜSÜ

                                case 2:
                                    foreach (Menü salads in Salad)
                                    {

                                        Console.WriteLine("\n" + no + ". " + salads.salad + "   =====>  FİYAT: " + salads.saladPrice);
                                        no++;
                                    }
                                    break;

                                    //HAMBURGER MENÜSÜ

                                case 3:
                                    foreach (Menü hamburgers in Hamburger)
                                    {

                                        Console.WriteLine("\n" + no + ". " + hamburgers.hamburger + "   =====>  FİYAT: " + hamburgers.hamburgerPrice);
                                        no++;
                                    }
                                    break;
                                    // ÇIKIŞ
                                case 0:
                                    Console.Clear();
                                    Menu();
                                    break;
                            }
                        }
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 0:
                        Environment.Exit(0);
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
        #endregion
    }
}