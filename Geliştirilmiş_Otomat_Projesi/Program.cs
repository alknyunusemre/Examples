
namespace Geliştirilmiş_Otomat_Projesi
{
    internal class Program
    {
        //Kullanıcı İşlemleri
        static string[] drinkNameandPrice = {"1. Coca-Cola Orijinal Tat Kutu 330 Ml = 40 Tl\n", "2. Uludağ Efsane Gazoz 250 Ml = 25 Tl\n ", "3. Red Bull Enerji İçeceği 355 Ml = 65 Tl\n" , "4. Pepsi Kola Kutu 330 Ml = 40 Tl\n",
            "5. Schweppes Mandalina Cam Şişe 250 Ml= 45 Tl\n","6. Çay = 25 Tl\n", "7. Su = 10 \n", "8. Nescafe= 35 Tl \n"};
        static int[] price = { 40, 25, 65, 40, 45, 25, 10, 35 };
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                //Admin ve Kullanıcı Girişi
                Console.WriteLine("1. Admin Giriş\n2.Kullanıcı Girişi\nLütfen Giriş Yapma Yöntemini Seçiniz(1/2):");
                int login = Convert.ToInt32(Console.ReadLine());
                if (login == 1)
                {
                    AdminPanel();
                }
                else if (login == 2)
                {
                    DrinkMenü();
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                }
            }
           
        }
        #region ***Kullanıcı İşlemleri***
        #region --- İçecek Menüsü ---
        static void DrinkMenü()
        {

            //Döngü İle İşlemi Tekrarlama
            while (true)
            {

                //Kullanıcıya Menü Gösterim
                foreach (string drink in drinkNameandPrice)
                {
                    Console.WriteLine(drink);
                }

                //Kullanıcan Seçim Alma
                Console.WriteLine("------------------------------------------");
                Console.Write("\nLütfen İstediğiniz Ürün Numarasını Giriniz: ");
                int selectedNumber = Convert.ToInt32(Console.ReadLine());

                //Kullanıcı Seçimini Kontrol Etme
                if (selectedNumber >= 1 && selectedNumber <= drinkNameandPrice.Length)
                {
                    Console.WriteLine("Seçilen Ürünün Fiyatı: " + price[selectedNumber - 1] + " Tl");

                    //Ödeme Alma
                    Console.Write("Lütfen Ödeme Yapınız: ");
                    int payment = Convert.ToInt32(Console.ReadLine());

                    //Ödemeyi Kontrol Etme
                    if (payment >= price[selectedNumber - 1])
                    {
                        Console.WriteLine("Ödeme Başarıyla Gerçekleşti");
                    }
                    else
                    {
                        int waitingTime = 3000;
                        Console.WriteLine("Bakiye Yetersiz!\nİşleminiz 3 Sny İçinde iptal Edilecek.\n");
                        Thread.Sleep(waitingTime);
                        Console.Clear();
                        Console.WriteLine("Farklı Bir İşlem Yapmak İstiyor Musunuz (Evet/Hayır)");
                        string select = Console.ReadLine()!.ToUpper();
                        if (select == "HAYIR")
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız... \nLütfen İçecek Menüsüne Dönmek İçin Bir Tuşa Basınız!");
                    Console.ReadKey();
                    Console.Clear();

                }
            }

        }
        #endregion
        #region --- Admin Paneli --
        static void AdminPanel()
        {
            while (true)
            {
                Console.WriteLine("*** İŞLEM SEÇİNİZ ***\n1.Ürün Ekleme\n2.Ürün Silme\n3.Ürün Güncelleme\n4.Admin Panelden Çık\nLütfen Seçiminizi Yapınız:");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        //Ürün Ekleme
                        Console.WriteLine("*** ÜRÜN EKLEME ***\n");
                        foreach (string list in drinkNameandPrice)
                        {
                            Console.WriteLine(list);
                        }
                        Console.Write("Başında Sıra Numarası Olcak Şekilde Eklenecek Ürün İsmini Ve Fiyatını Giriniz: ");
                        string nameAndPrice = Console.ReadLine()!;
                        Array.Resize(ref drinkNameandPrice, drinkNameandPrice.Length + 1);
                        drinkNameandPrice[drinkNameandPrice.Length - 1] = nameAndPrice;
                        Console.WriteLine("Ürünün Fiyatını Tekrar Giriniz : ");
                        int priceAdd = Convert.ToInt32(Console.ReadLine());
                        Array.Resize(ref price, price.Length + 1);
                        price[price.Length - 1] = priceAdd;
                        Console.WriteLine("---ÜRÜN BAŞARIYLA EKLENDİ---");
                        foreach (string list in drinkNameandPrice)
                        {
                            Console.WriteLine(list);
                        }
                        break;
                    case 2:
                        //Ürün Silme
                        foreach (string list in drinkNameandPrice)
                        {
                            Console.WriteLine(list);
                        }
                        Console.Write("Silinecek Ürün Numarasanı Seçiniz: ");
                        int clearselect = Convert.ToInt32(Console.ReadLine());
                        string[] newDrinkandPrice = new string[drinkNameandPrice.Length - 1];
                        int[] newprice = new int[price.Length - 1];
                        int drinkPrice = 0;
                        int priceclear = 0;
                        for (int i = 0; i < drinkNameandPrice.Length; i++)
                        {
                            if (i != clearselect - 1)
                            {
                                newDrinkandPrice[drinkPrice] = drinkNameandPrice[i];
                                drinkPrice++;
                            }
                        }
                        for (int j = 0; j < price.Length; j++)
                        {
                            if (j != clearselect - 1)
                            {
                                newprice[priceclear] = price[j];
                                priceclear++;
                            }
                        }

                        drinkNameandPrice = newDrinkandPrice;
                        price = newprice;
                        Console.WriteLine("\n");
                        foreach (string list in drinkNameandPrice)
                        {
                            Console.WriteLine(list);
                        }
                        break;
                    case 3:
                        //Ürün Güncelleme
                        foreach (string list in drinkNameandPrice)
                        {
                            Console.WriteLine(list);
                        }
                        Console.Write("Güncellenecek Ürünün Numarasını Giriniz:");
                        int updateNumber = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < drinkNameandPrice.Length; i++)
                        {
                            if (i == updateNumber - 1)
                            {
                                Console.WriteLine("Güncel Bilgileri Ürünün Başında Sıra Numarası Olacak Şekilde Ürün İsmi ve Fiyatı Yazınız: ");
                                string updatedrinkNameandPrice = Console.ReadLine()!;
                                drinkNameandPrice[i] = updatedrinkNameandPrice;
                            }
                        }
                        for (int j = 0; j < price.Length; j++)
                        {
                            if (j == updateNumber)
                            {
                                Console.Write("Güncel Fiyatı Tekrar Giriniz: ");
                                int updateprice = Convert.ToInt32(Console.ReadLine());
                                price[j] = updateprice;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("***İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞTİRİLDİ***");
                        foreach (string list in drinkNameandPrice)
                        {
                            Console.WriteLine(list);
                        }
                        break;
                    case 4:
                        //Admin Programı Sonlandır veya Ana Menüye Dön
                        Console.WriteLine("1.Başlangıç Arayüzüne Geri Dönmek\n2.Programı Sonlandırmak\nLütfen Seçiniz");
                        int selectadmin = Convert.ToInt32(Console.ReadLine());
                        switch (selectadmin) 
                        {
                            case 1:
                                return;
                            case 2:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                        
                }
            }
      
        }
        #endregion
        #endregion
    }
}
