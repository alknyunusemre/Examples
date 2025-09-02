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

        internal string pizza;
        internal string salad;
        internal string cake;
        internal string hamburger;
        internal string icedrink;
        internal string hotdrink;

        internal double pizzaPrice;
        internal double saladPrice;
        internal double cakePrice;
        internal double hamburgerPrice;
        internal double icedrinkPrice;
        internal double hotdrinkPrice;

        internal static List<Menü> Products = new List<Menü>()
        {
            //Pizza
            new Menü{pizza = "Margaritta Pizza",pizzaPrice = 200 },
            new Menü{pizza = "Karışık Pizza",pizzaPrice = 300 },
            new Menü{pizza = "Ton Balıklıklı ve Karidesli Pizza",pizzaPrice = 390 },
           //Salad
           new Menü{salad = "Çoban Salata",saladPrice = 150 },
           new Menü{salad = "Sezar Salata",saladPrice = 290 },
           new Menü{salad = "Hellim Peynir Salata",saladPrice = 250 },
           //Cake
           new Menü{cake = "Çikolata Krokanlı Pasta",cakePrice = 130 },
           new Menü{cake = "Çikolatalı Çilekli Pasta",cakePrice = 150 },
           new Menü{cake = "Orman Meyveli Pasta",cakePrice = 120 },
           //Hamburger
           new Menü{hamburger = "DoubleBurger",hamburgerPrice = 430 },
           new Menü{hamburger = "SmashBurger",hamburgerPrice = 500 },
           new Menü{hamburger = "TripleBurger",hamburgerPrice = 480 },
           //Ice Drink
           new Menü{icedrink = "Çilekli Limonata",icedrinkPrice = 130 },
           new Menü{icedrink = "İce Tea",icedrinkPrice = 100 },
           new Menü{icedrink = "Kola",icedrinkPrice = 100 },
           //Hot Drink
           new Menü{hotdrink = "Latte",hotdrinkPrice = 120 },
           new Menü{hotdrink = "Çay",hotdrinkPrice = 50 },
           new Menü{hotdrink = "Türk",hotdrinkPrice = 120 },
        };


        internal static List<Show_Orders> order = new List<Show_Orders>();

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
                                Console.WriteLine("Lütfen Sipariş Vereceğiniz Ürünün Başındaki Yazan Numarayı Yazınız");
                                int order = Convert.ToInt32(Console.ReadLine());
                                ShowOrders(pizza,pizzaprice,order);
                            }
                            else if (foods == 2) 
                            {
                                Console.WriteLine("--- SALATALAR ---");
                                for (int i = 0; i < salad.Count; i++)
                                {
                                    Console.WriteLine((i + 1) + "." + salad[i] + " = " + saladprice[i]);
                                }
                                Console.WriteLine("Lütfen Sipariş Vereceğiniz Ürünün Başındaki Yazan Numarayı Yazınız");
                                int order2 = Convert.ToInt32(Console.ReadLine());
                                ShowOrders(salad, saladprice, order2);
                            }
                            else
                            {
                                Console.WriteLine("--- HAMBURGERLER ---");
                                for (int i = 0; i < hamburger.Count; i++)
                                {
                                    Console.WriteLine((i + 1) + "." + hamburger[i] + " = " + hamburgerprice[i]);
                                }
                                Console.WriteLine("Lütfen Sipariş Vereceğiniz Ürünün Başındaki Yazan Numarayı Yazınız");
                                int order3 = Convert.ToInt32(Console.ReadLine());
                                ShowOrders(hamburger, hamburgerprice, order3);
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
                                    Console.WriteLine("Lütfen Sipariş Vereceğiniz Ürünün Başındaki Yazan Numarayı Yazınız");
                                    int order4 = Convert.ToInt32(Console.ReadLine());
                                    ShowOrders(icedrinks, icedrinksprice, order4);
                                    break;
                                case 2:
                                    Console.WriteLine("--- SICAK İÇECEKLER ---");
                                    for (int i = 0; i < hotdrinks.Count; i++)
                                    {
                                        Console.WriteLine((i + 1) + "." + hotdrinks[i] + " = " + hotdrinksprice[i]);
                                    }
                                    Console.WriteLine("Lütfen Sipariş Vereceğiniz Ürünün Başındaki Yazan Numarayı Yazınız");
                                    int order5 = Convert.ToInt32(Console.ReadLine());
                                    ShowOrders(hotdrinks, hotdrinksprice, order5);
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
                        Console.WriteLine("Lütfen Sipariş Vereceğiniz Ürünün Başındaki Yazan Numarayı Yazınız");
                        int order6 = Convert.ToInt32(Console.ReadLine());
                        ShowOrders(cake, cakeprice, order6);
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
        internal static void ShowOrders(List<string>item,List<int>prices,int index) 
        {
            if (index > 0 && index <= item.Count) 
            {
                Console.WriteLine(item[index-1]+" Başarıyla Sipariş Verildi...");
                Show_Orders ord = new Show_Orders();
                ord.name = item[index - 1];
                ord.price = prices[index - 1];
                order.Add(ord);
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
    class Show_Orders 
    {
        internal  string name;
        internal  int price;
    }

}
