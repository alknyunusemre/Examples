using System.Collections;
using System.Reflection.Metadata;//Bunun ne işe yaradığı öğrenilecek!!

namespace Manav_Otomasyonu
{
    internal class Program
    {
        static ArrayList Wholesalerusernames = new ArrayList();
        static ArrayList Wholesalerpasswords = new ArrayList();
        static ArrayList Sellerusernames = new ArrayList();
        static ArrayList Sellerpasswords = new ArrayList();
        static ArrayList Wholesalerfruit = new ArrayList() { "Ejder Meyvesi", "Papaya", "Avokado", "Ayva", "Muz", "Pasiflora Çarkıfelek Meyvesi", "Yaban Mersini", "Yıldız Meyvesi", "Ananas", "Kudret Narı", "Mango", "Hindistan Cevizi" };
        static ArrayList Wholesalervegetables = new ArrayList() { "Domates 1Kg", "Salatalık 1Kg", "Kuşkonmaz 300g", "Trüf Mantarı 100g", "Sarımsak 1Kg", "Marul (Mini) 4 Adet", "Kırmızı Pancar 1Kg", "Kereviz 1Kg", "Yer Elması 1Kg", "Semiz Otu 1 Bağ", "Kırmızı Soğan 1Kg", "Biberiye Otu 40g" };
        static ArrayList Wholesalerfruitprice = new ArrayList() { 100, 50, 370, 374, 220, 200, 820, 100, 170, 800, 200, 100 };
        static ArrayList WholesalervegetablesPrice = new ArrayList() { 70, 20, 380, 800, 220, 50, 210, 210, 230, 110, 20, 20 };
        static ArrayList WholesalerProductCodeFruit = new ArrayList();
        static ArrayList WholesalerProductCodevegetables = new ArrayList();
        static ArrayList Sellerfruit = new ArrayList();
        static ArrayList sellervegetables = new ArrayList();
        static ArrayList Sellerfruitprice = new ArrayList();
        static ArrayList SellervegetablesPrice = new ArrayList();
        static ArrayList SellerProductCodeFruit = new ArrayList();
        static ArrayList SellerProductCodevegetables = new ArrayList();
        static void Main(string[] args)
        {
            string welcome = "Manav Otomasyonuna Hoşgeldiniz aktarılıyorsunuz...".ToUpper();
            Console.WriteLine(welcome);
            Thread.Sleep(2000);
            Console.Clear();
            while (true)
            {
                Console.Write("1. Toptancı Panel Girişi\t" + "2. Satıcı Panel Girişi\t" + "\t3. Müşteri Paneline Giriş\n");
                Console.Write("------------------------\t" + "----------------------\t" + "\t-------------------------");
                Console.WriteLine("\n\n Lütfen Giriş Yönteminizi Seçiniz(1/2/3):");
                string select = Console.ReadLine()!;
                short numberSelect;
                if (short.TryParse(select, out numberSelect))
                {
                    switch (numberSelect)
                    {
                        case 1:
                            LoadingPanel();
                            WholesalerLoginPanel();
                            break;
                        case 2:
                            LoadingPanel();
                            SellerLoginPanel();
                            break;
                        case 3:
                            LoadingPanel();
                            Customer();
                            break;

                        default:

                            Console.WriteLine("***HATALI SAYI GİRİŞİ YAPTINIZ,GERİ DÖNMEK İÇİN HERHANGİ BİR TUŞA BASINIZ***");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    ErrorType();
                }

            }

        }
        static void ErrorType()
        {
            Console.WriteLine("***HATALI KARAKTER GİRİŞİ YAPTINIZ,GERİ DÖNMEK İÇİN HERHANGİ BİR TUŞA BASINIZ***");
            Console.ReadKey();
            Console.Clear();
        }
        static void LoadingPanel()
        {
            Console.Clear();
            for (int i = 0; i <= 100; i += 2)
            {
                Console.Clear();
                Console.WriteLine("\rYÜKLENİYOR...%" + i);
                Thread.Sleep(10);
            }
            Console.Clear();
        }
        static void Wholesaler()
        {
            while (true)
            {
                Random rnd = new Random();
                Console.WriteLine("*** TOPTANCI PANELİ ***\n***********************");
                Console.WriteLine("Sebze veya Meyve Seçiniz\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("****SEBZE****\n");
                Console.ResetColor();
                for (int i = 0; i < Wholesalervegetables.Count; i++)
                {
                    int randomvegetables = rnd.Next(1000, 4000);
                    Console.WriteLine((i + 1) + ". " + Wholesalervegetables[i] + " = " + WholesalervegetablesPrice[i] + " TL");
                    Console.WriteLine("(Ürün Kodu: " + randomvegetables + ")\n");
                    WholesalerProductCodevegetables.Add(randomvegetables);
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("****MEYVE****\n");
                Console.ResetColor();

                for (int j = 0; j < Wholesalerfruit.Count; j++)
                {
                    int randomfruit = rnd.Next(4000, 8001);
                    Console.WriteLine((j + 1) + ". " + Wholesalerfruit[j] + " = " + Wholesalerfruitprice[j] + " TL");
                    Console.WriteLine("(Ürün Kodu: " + randomfruit + ")\n");
                    WholesalerProductCodeFruit.Add(randomfruit);
                }
                Console.Write("\nİşlem yapacağınız ürünün kodunu giriniz:");
                string code = Console.ReadLine()!;
                int productCode;
                if (int.TryParse(code, out productCode))
                {
                    int searchvegetables = WholesalerProductCodevegetables.IndexOf(productCode);
                    int searchfruit = WholesalerProductCodeFruit.IndexOf(productCode);
                    if (searchvegetables != -1)
                    {
                        Console.WriteLine(productCode + " No'lu Üründe gerçekleştirmek istediğiniz işlem nedir(1/2/3):\n1.Ürün İsmini Değiştir:\n2.Ürünün Fiyatını Değiştir:\n3.Ürün Ekle:\n4.Ürün Sil:\n5.Panelden Çıkış:\n");
                        Console.Write("İşlem Seçiniz:");
                        string select = Console.ReadLine()!;
                        int processSelectVegetables;
                        if (int.TryParse(select, out processSelectVegetables))
                        {
                            switch (processSelectVegetables)
                            {
                                case 1:

                                    if (productCode >= 1000 && productCode < 4000 && searchvegetables != -1)
                                    {
                                        Console.WriteLine("Mevcut Ürün Adı: " + Wholesalervegetables[searchvegetables]);
                                        Console.WriteLine("Yeni İsmi Giriniz: ");
                                        string newVegetablesName = Console.ReadLine()!;
                                        Wholesalervegetables[searchvegetables] = newVegetablesName;
                                        Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                                        Console.WriteLine("\nYeni Ürün Adı: " + Wholesalervegetables[searchvegetables] + "\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sebze Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                        Console.ReadKey();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Mevcut Ürün Fiyatı: " + WholesalervegetablesPrice[searchvegetables] + " TL");
                                    Console.WriteLine("Yeni Ürün Fiyatını Giriniz: ");
                                    double newVegetablesPrice = Convert.ToDouble(Console.ReadLine()!);
                                    WholesalervegetablesPrice[searchvegetables] = newVegetablesPrice;
                                    Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                                    Console.WriteLine(Wholesalervegetables[searchvegetables] + " = " + WholesalervegetablesPrice[searchvegetables] + " TL\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    string add;
                                    do
                                    {
                                        Console.WriteLine("Eklemek İstediğiniz Ürünün İsmi: ");
                                        string newVegetablesName = Console.ReadLine()!;
                                        Wholesalervegetables.Add(newVegetablesName);
                                        Console.WriteLine("***İşleminiz Başarıyla Gerçekleşti***");
                                        Console.WriteLine("Ürün Eklemeye Devam Etmek İstiyormusunuz?(E/H)");
                                        add = Console.ReadLine()!.ToUpper();
                                    }
                                    while (add == "E");
                                    break;
                                case 4:
                                    Console.WriteLine("Silinecek Ürün Kodunu Giriniz: ");
                                    string deletecode = Console.ReadLine()!;
                                    int deleteProductCode;

                                    if (int.TryParse(deletecode, out deleteProductCode))
                                    {
                                        int deleteVegetables = WholesalerProductCodevegetables.IndexOf(deleteProductCode);
                                        if (deleteProductCode >= 1000 && deleteProductCode < 4000 && deleteVegetables != -1)
                                        {
                                            Console.WriteLine("Silme işlemini onaylıyor musunuz?(E/H)");
                                            string selected = Console.ReadLine()!;
                                            if (selected != "H")
                                            {
                                                WholesalerProductCodevegetables.RemoveAt(deleteVegetables);
                                                Wholesalervegetables.RemoveAt(deleteVegetables);
                                                WholesalervegetablesPrice.RemoveAt(deleteVegetables);

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Sebze Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        ErrorType();
                                    }
                                    break;
                                case 5:
                                    return;
                                    
                            }
                        }
                        else
                        {
                            ErrorType();
                        }

                    }
                    else if (searchfruit != -1)
                    {
                        Console.WriteLine(productCode + " No'lu Üründe gerçekleştirmek istediğiniz işlem nedir(1/2/3):\n1.Ürün İsmini Değiştir:\n2.Ürünün Fiyatını Değiştir:\n3.Ürün Ekle:\n4.Ürün Sil:\n5.Panelden Çıkış:\n");
                        Console.Write("İşlem Seçiniz:");
                        string select = Console.ReadLine()!;
                        int processSelectFruit;
                        if (int.TryParse(select, out processSelectFruit))
                        {
                            switch (processSelectFruit)
                            {
                                case 1:
                                    if (productCode >= 4000 && productCode < 8001&&productCode!=-1)
                                    {
                                        Console.WriteLine("Mevcut Ürün Adı: " + Wholesalerfruit[searchfruit]);
                                        Console.WriteLine("Yeni İsmi Giriniz: ");
                                        string newfruitName = Console.ReadLine()!;
                                        Wholesalerfruit[searchfruit] = newfruitName;
                                        Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                                        Console.WriteLine("\nYeni Ürün Adı: " + Wholesalerfruit[searchfruit] + "\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Meyve Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                        Console.ReadKey();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Mevcut Ürün Fiyatı: " + Wholesalerfruitprice[searchfruit] + " TL");
                                    Console.WriteLine("Yeni Ürün Fiyatını Giriniz: ");
                                    double newFruitPrice = Convert.ToDouble(Console.ReadLine()!);
                                    Wholesalerfruitprice[searchfruit] = newFruitPrice;
                                    Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                                    Console.WriteLine(Wholesalerfruit[searchfruit] + " = " + Wholesalerfruitprice[searchfruit] + " TL\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı ürün kodu!\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    ErrorType();
                }
            }
        }
        static void Seller()
        {
            Console.WriteLine("*** SATICI PANELİ ***");
        }
        static void Customer()
        {
            Console.WriteLine("*** ABC HAL'E HOŞGELDİNİZ ***");
        }
        static void WholesalerLoginPanel()
        {
            Wholesalerusernames.Add("Admin");
            Wholesalerpasswords.Add("123");
            int hak = 3;
            Console.Clear();
            Console.WriteLine("***GİRİŞ PANELİ***");
            Console.WriteLine("1.Kayıt Ol\t 2.Üye Girişi\nLütfen Yapmak İstediğiniz İşlemi Seçiniz(1/2):");
            string select = Console.ReadLine()!;
            short selectNumber;
            if (short.TryParse(select, out selectNumber))
            {
                switch (selectNumber)
                {
                    case 1:
                        WholesalerSignUp();
                        break;

                    case 2:

                        while (hak > 0)
                        {

                            Console.WriteLine("Kullanıcı Adınız: ");
                            string userName = Console.ReadLine()!;
                            Console.WriteLine("Şifre: ");
                            string password = Console.ReadLine()!;
                            bool login = false;
                            for (int i = 0; Wholesalerusernames.Count > i; i++)
                            {
                                if (userName == (string)Wholesalerusernames[i]! && password == (string)Wholesalerpasswords[i]!)
                                {
                                    login = true;
                                }

                            }
                            if (login)
                            {
                                Console.WriteLine($"GİRİŞ BAŞARILI HOŞGELDİNİZ '{userName}' YÖNLENDİRİLİYORSUNUZ...\n");
                                Wholesaler();
                                break;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı!!!");
                                hak--;
                                Console.WriteLine($"Kalan Hakkınız: {hak}");

                            }
                            if (hak == 0)
                            {
                                Console.WriteLine("Hakkınız Tükendi Ana Menüye Aktarılıyorsunuz...");
                                for (int j = 3; j >= 0; j--)
                                {
                                    Console.WriteLine($"\r{j} Saniye Sonra Ana Menüye Aktarılacaksınız!!!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("HATALI SAYI GİRİŞİ YAPTINIZ.GERİ DÖNMEK İÇİN HERGANGİ BİR TUŞA BASINIZ");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                ErrorType();
            }

        }
        static void WholesalerSignUp()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kullanıcı Adı: ");
                string username = Console.ReadLine()!;
                Console.WriteLine("Şifre: ");
                string password = Console.ReadLine()!;
                Console.WriteLine("Şifre Tekrar");
                string repeatPassword = Console.ReadLine()!;
                if (password != repeatPassword)
                {
                    Console.WriteLine("Şifreler Birbiriyle Eşleşmiyor!!! Lütfen Tekrar Denemek İçin Bir Tuşa Basınız...");
                    Console.ReadKey();
                }
                else
                {
                    Wholesalerusernames.Add(username);
                    Wholesalerpasswords.Add(password);
                    Console.WriteLine("KAYIT OLUNDU. GİRİŞ PANELİNE YÖNLENDİRİLİYORSUNUZ\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    return;
                }
            }

        }
        static void SellerLoginPanel()
        {
            Sellerusernames.Add("Admin");
            Sellerpasswords.Add("123");
            int hak = 3;
            Console.Clear();
            Console.WriteLine("***GİRİŞ PANELİ***");
            Console.WriteLine("1.Kayıt Ol\t 2.Üye Girişi\nLütfen Yapmak İstediğiniz İşlemi Seçiniz(1/2):");
            string select = Console.ReadLine()!;
            short selectNumber;
            if (short.TryParse(select, out selectNumber))
            {
                switch (selectNumber)
                {
                    case 1:
                        SellerSignUp();
                        break;

                    case 2:

                        while (hak > 0)
                        {

                            Console.WriteLine("Kullanıcı Adınız: ");
                            string userName = Console.ReadLine()!;
                            Console.WriteLine("Şifre: ");
                            string password = Console.ReadLine()!;
                            bool login = false;
                            for (int i = 0; Sellerusernames.Count > i; i++)
                            {
                                if (userName == (string)Sellerusernames[i]! && password == (string)Sellerpasswords[i]!)
                                {
                                    login = true;
                                }

                            }
                            if (login)
                            {
                                Console.WriteLine($"GİRİŞ BAŞARILI HOŞGELDİNİZ '{userName}' YÖNLENDİRİLİYORSUNUZ...");
                                Seller();

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı!!!");
                                hak--;
                                Console.WriteLine($"Kalan Hakkınız: {hak}");

                            }
                            if (hak == 0)
                            {
                                Console.WriteLine("Hakkınız Tükendi Ana Menüye Aktarılıyorsunuz...");
                                for (int j = 3; j >= 0; j--)
                                {
                                    Console.WriteLine($"\r{j} Saniye Sonra Ana Menüye Aktarılacaksınız!!!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("HATALI SAYI GİRİŞİ YAPTINIZ.GERİ DÖNMEK İÇİN HERGANGİ BİR TUŞA BASINIZ");
                        Console.ReadKey();
                        break;

                }
            }
            else
            {
                ErrorType();
            }

        }
        static void SellerSignUp()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kullanıcı Adı: ");
                string username = Console.ReadLine()!;
                Console.WriteLine("Şifre: ");
                string password = Console.ReadLine()!;
                Console.WriteLine("Şifre Tekrar");
                string repeatPassword = Console.ReadLine()!;
                if (password != repeatPassword)
                {
                    Console.WriteLine("Şifreler Birbiriyle Eşleşmiyor!!! Lütfen Tekrar Denemek İçin Bir Tuşa Basınız...");
                    Console.ReadKey();
                }
                else
                {
                    Sellerusernames.Add(username);
                    Sellerpasswords.Add(password);
                    Console.WriteLine("KAYIT OLUNDU. GİRİŞ PANELİNE YÖNLENDİRİLİYORSUNUZ\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    return;
                }
            }

        }

    }
}
