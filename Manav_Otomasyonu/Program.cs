using System;
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
                    InitializeProductCodes();
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
        static void InitializeProductCodes()
        {
            Random rnd = new Random();


            for (int i = 0; i < Wholesalervegetables.Count; i++)
            {
                WholesalerProductCodevegetables.Add(rnd.Next(1000, 4000));
            }


            for (int i = 0; i < Wholesalerfruit.Count; i++)
            {
                WholesalerProductCodeFruit.Add(rnd.Next(4000, 8000));
            }

        }
        static void Wholesaler()
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("*** TOPTANCI PANELİ ***\n***********************");
                Console.WriteLine("Sebze veya Meyve Seçiniz\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n--- Sebzeler ---");
                Console.ResetColor();
                for (int i = 0; i < Wholesalervegetables.Count; i++)
                {
                    Console.WriteLine($"{Wholesalervegetables[i]} - {WholesalervegetablesPrice[i]} TL -\nKod: ({WholesalerProductCodevegetables[i]})");
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n--- Meyveler ---");
                Console.ResetColor();
                for (int i = 0; i < Wholesalerfruit.Count; i++)
                {
                    Console.WriteLine($"{Wholesalerfruit[i]} - {Wholesalerfruitprice[i]} TL - \nKod: ({WholesalerProductCodeFruit[i]})");
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
                        void UpdateVegetablesPrice()
                        {
                            Console.WriteLine("Mevcut Ürün Fiyatı: " + WholesalervegetablesPrice[searchvegetables] + " TL");
                            Console.WriteLine("Yeni Ürün Fiyatını Giriniz: ");
                            double newVegetablesPrice = Convert.ToDouble(Console.ReadLine()!);
                            WholesalervegetablesPrice[searchvegetables] = newVegetablesPrice;
                            Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                        }
                        void DeleteVegetables()
                        {
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
                                        Console.WriteLine("***İşleminiz Başarıyla Gerçekleşti***\nBİR TUŞA BASINIZ...");
                                        Console.ReadKey();
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
                        }
                        void AddVegetables()
                        {
                            Console.WriteLine("Eklemek İstediğiniz Ürünün İsmi: ");
                            string newVegetablesName = Console.ReadLine()!;
                            Wholesalervegetables.Add(newVegetablesName);
                            Console.WriteLine("Ürün Fiyatı: ");
                            string price = Console.ReadLine()!;
                            int addPrice;
                            if (int.TryParse(price, out addPrice))
                            {
                                Console.WriteLine("Ürünün Fiyatını Onaylıyor musunuz?(E/H): ");
                                string character = Console.ReadLine()!.ToUpper();
                                if (character != "H")
                                {
                                    WholesalervegetablesPrice.Add(addPrice);
                                    Console.WriteLine("***İşleminiz Başarıyla Gerçekleşti***\nBİR TUŞA BASINIZ...");
                                    Console.ReadKey();
                                }
                                else if (character != "E")
                                {
                                    LoadingPanel();
                                    AddVegetables();
                                }
                            }
                        }
                        void UpdateVegetablesName()
                        {
                            Console.WriteLine("Mevcut Ürün Adı: " + Wholesalervegetables[searchvegetables]);
                            Console.WriteLine("Yeni İsmi Giriniz: ");
                            string newVegetablesName = Console.ReadLine()!;
                            Wholesalervegetables[searchvegetables] = newVegetablesName;
                            Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***\nBİR TUŞA BASINIZ...");
                            Console.ReadKey();
                        }
                        Console.WriteLine(productCode + " No'lu Üründe gerçekleştirmek istediğiniz işlem nedir(1/2/3...):\n1.Ürün İsmini Değiştir:\n2.Ürünün Fiyatını Değiştir:\n3.Ürün Ekle:\n4.Ürün Sil:\n5.Panelden Çıkış:\n");
                        Console.Write("İşlem Seçiniz:");
                        string select = Console.ReadLine()!;
                        int processSelectVegetables;
                        if (int.TryParse(select, out processSelectVegetables))
                        {
                            if (productCode >= 1000 && productCode < 4000 && searchvegetables != -1)
                            {
                                switch (processSelectVegetables)
                                {
                                    case 1:
                                        UpdateVegetablesName();
                                        Console.WriteLine("\nYeni Ürün Adı: " + Wholesalervegetables[searchvegetables] + "\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        UpdateVegetablesPrice();
                                        Console.WriteLine(Wholesalervegetables[searchvegetables] + " = " + WholesalervegetablesPrice[searchvegetables] + " TL\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        string add;
                                        do
                                        {
                                            AddVegetables();
                                            Console.WriteLine("Ürün Eklemeye Devam Etmek İstiyormusunuz?(E/H)");
                                            add = Console.ReadLine()!.ToUpper();
                                        }
                                        while (add == "E");
                                        break;
                                    case 4:
                                        DeleteVegetables();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.Clear();
                                        return;
                                    default:
                                        ErrorType();
                                        break;

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

                    }
                    else if (searchfruit != -1)
                    {
                        void UpdateFruitName()
                        {
                            Console.WriteLine("Mevcut Ürün Adı: " + Wholesalerfruit[searchfruit]);
                            Console.WriteLine("Yeni İsmi Giriniz: ");
                            string newfruitName = Console.ReadLine()!;
                            Wholesalerfruit[searchfruit] = newfruitName;
                            Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                        }
                        void UpdateFruitPrice()
                        {
                            if (searchfruit != -1 && searchfruit < Wholesalerfruitprice.Count)
                            {
                                Console.WriteLine("Mevcut Ürün Fiyatı: " + Wholesalerfruitprice[searchfruit] + " TL");
                                Console.WriteLine("Yeni Ürün Fiyatını Giriniz: ");
                                double newFruitPrice = Convert.ToDouble(Console.ReadLine()!);
                                Wholesalerfruitprice[searchfruit] = newFruitPrice;
                                Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                            }
                            else
                            {
                                Console.WriteLine("Hatalı veya bulunamayan ürün kodu. İşlem iptal edildi.");
                                Console.ReadKey();
                            }
                        }                       
                        void AddFruit()
                        {
                            Console.WriteLine("Eklemek İstediğiniz Ürünün İsmi: ");
                            string newFruitName = Console.ReadLine()!;
                            Wholesalerfruit.Add(newFruitName);
                            Console.WriteLine("Ürün Fiyatı: ");
                            string price = Console.ReadLine()!;
                            int addPrice;
                            if (int.TryParse(price, out addPrice))
                            {
                                Console.WriteLine("Ürünün Fiyatını Onaylıyor musunuz?(E/H): ");
                                string character = Console.ReadLine()!.ToUpper();
                                if (character != "H")
                                {
                                    Wholesalerfruitprice.Add(addPrice);
                                    Console.WriteLine("***İşleminiz Başarıyla Gerçekleşti***\nBİR TUŞA BASINIZ...");
                                    Console.ReadKey();
                                }
                                else if (character != "E")
                                {
                                    LoadingPanel();
                                    AddFruit();
                                }
                            }
                        }
                        void DeleteFruit()
                        {
                            Console.WriteLine("Silinecek Ürün Kodunu Giriniz: ");
                            string deletecode = Console.ReadLine()!;
                            int deleteProductCode;

                            if (int.TryParse(deletecode, out deleteProductCode))
                            {
                                int deleteFruit = WholesalerProductCodevegetables.IndexOf(deleteProductCode);
                                if (deleteProductCode >= 1000 && deleteProductCode < 4000 && deleteFruit != -1)
                                {
                                    Console.WriteLine("Silme işlemini onaylıyor musunuz?(E/H)");
                                    string selected = Console.ReadLine()!;
                                    if (selected != "H")
                                    {
                                        WholesalerProductCodevegetables.RemoveAt(deleteFruit);
                                        Wholesalerfruit.RemoveAt(deleteFruit);
                                        Wholesalerfruitprice.RemoveAt(deleteFruit);
                                        Console.WriteLine("***İşleminiz Başarıyla Gerçekleşti***\nBİR TUŞA BASINIZ...");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Meyve Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                ErrorType();
                            }
                        }
                        
                        Console.WriteLine(productCode + " No'lu Üründe gerçekleştirmek istediğiniz işlem nedir(1/2/3...):\n1.Ürün İsmini Değiştir:\n2.Ürünün Fiyatını Değiştir:\n3.Ürün Ekle:\n4.Ürün Sil:\n5.Panelden Çıkış:\n");
                        Console.Write("İşlem Seçiniz:");
                        string select = Console.ReadLine()!;
                        int processSelectFruit;
                        
                        if (int.TryParse(select, out processSelectFruit))
                        {
                            if (productCode >= 4000 && productCode < 8001 && productCode != -1)
                            {
                                switch (processSelectFruit)
                                {
                                    case 1:

                                        UpdateFruitName();
                                        Console.WriteLine("\nYeni Ürün Adı: " + Wholesalerfruit[searchfruit] + "\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;
                                    case 2:
                                        UpdateFruitPrice();
                                        Console.WriteLine(Wholesalerfruit[searchfruit] + " = " + Wholesalerfruitprice[searchfruit] + " TL\nToptancı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        string add;
                                        do
                                        {
                                            AddFruit();
                                            Console.WriteLine("Ürün Eklemeye Devam Etmek İstiyormusunuz?(E/H)");
                                            add = Console.ReadLine()!.ToUpper();

                                        } while (add == "E");
                                        break;
                                    case 4:
                                        DeleteFruit();
                                        Console.Clear();
                                        break;
                                    case 5:
                                        Console.Clear();
                                        return;
                                    default:
                                        ErrorType();

                                        break;


                                }
                            }
                            else
                            {
                                Console.WriteLine("Meyve Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                Console.ReadKey();
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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** SATICI PANELİ ***\n");
                Console.WriteLine("1.Toptancı Panelini Listele(ÜRÜN AL)");
                Console.WriteLine("2. Satıcı Panelini Listele(Ürünleri Görüntüle)");
                Console.WriteLine("\nYapmak İstediğiniz İşlemi Seçiniz");
                int selected = Convert.ToInt32(Console.ReadLine());
                if (selected == 1)
                {
                    Console.WriteLine("\n--TOPTANCIDA BULUNAN ÜRÜNLER--\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n--- Sebzeler ---");
                    Console.ResetColor();
                    for (int i = 0; i < Wholesalervegetables.Count; i++)
                    {
                        Console.WriteLine($"{Wholesalervegetables[i]} - {WholesalervegetablesPrice[i]} TL\nKod: ({WholesalerProductCodevegetables[i]})");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n--- Meyveler ---");
                    Console.ResetColor();
                    for (int i = 0; i < Wholesalerfruit.Count; i++)
                    {
                        Console.WriteLine($"{Wholesalerfruit[i]} - {Wholesalerfruitprice[i]} TL\nKod: ({WholesalerProductCodeFruit[i]})");
                    }
                    Console.WriteLine("Almak İstediğiniz Ürünün Kodunu Giriniz:");
                    string code = Console.ReadLine()!;
                    int productCode;
                    if (int.TryParse(code, out productCode))
                    {
                        int searchvegetables = WholesalerProductCodevegetables.IndexOf(productCode);
                        int searchfruit = WholesalerProductCodeFruit.IndexOf(productCode);
                        if (searchvegetables != -1)
                        {
                            Console.WriteLine("\n--- Seçilen Ürün ---");
                            Console.WriteLine($"İsim: {Wholesalervegetables[searchvegetables]}");
                            Console.WriteLine($"Fiyat: {WholesalervegetablesPrice[searchvegetables]} TL");
                            Console.WriteLine($"Kod: {WholesalerProductCodevegetables[searchvegetables]}");
                            Console.WriteLine("Bu Ürünü Almak İstediğinizi Onaylıyor musunuz?(E/H)");
                            string select = Console.ReadLine()!.ToUpper();
                            if (select == "E")
                            {
                                sellervegetables.Add(Wholesalervegetables[searchvegetables]);
                                SellervegetablesPrice.Add(WholesalervegetablesPrice[searchvegetables]);
                                SellerProductCodevegetables.Add(WholesalerProductCodevegetables[searchvegetables]);
                                Console.WriteLine("**Ürün Başarıyla Eklendi**");
                                Console.WriteLine("Satıcı Paneline Dönmek İçin Bir Tuşa Basınız");
                                Console.ReadKey();

                            }
                            else if (select == "H")
                            {
                                Console.WriteLine("Satıcı Paneline Dönmek İçin Bir Tuşa Basınız");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("HATALI TUŞLAMA SATICI PANELİNE AKTARILIYORSUNUZ");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                        else if (searchfruit != -1)
                        {
                            Console.WriteLine("\n--- Seçilen Ürün ---");
                            Console.WriteLine($"İsim: {Wholesalerfruit[searchfruit]}");
                            Console.WriteLine($"Fiyat: {Wholesalerfruitprice[searchfruit]} TL");
                            Console.WriteLine($"Kod: {WholesalerProductCodeFruit[searchfruit]}");
                            Console.WriteLine("Bu Ürünü Almak İstediğinizi Onaylıyor musunuz?(E/H)");
                            string select = Console.ReadLine()!.ToUpper();
                            if (select == "E")
                            {
                                Sellerfruit.Add(Wholesalerfruit[searchfruit]);
                                Sellerfruitprice.Add(Wholesalerfruitprice[searchfruit]);
                                SellerProductCodeFruit.Add(WholesalerProductCodeFruit[searchfruit]);
                                Console.WriteLine("**Ürün Başarıyla Eklendi**");
                                Console.WriteLine("Satıcı Paneline Dönmek İçin Bir Tuşa Basınız");
                                Console.ReadKey();

                            }
                            else if (select == "H")
                            {
                                Console.WriteLine("Satıcı Paneline Dönmek İçin Bir Tuşa Basınız");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("HATALI TUŞLAMA SATICI PANELİNE AKTARILIYORSUNUZ");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }

                        }
                        else
                        {
                            Console.WriteLine("Bu koda sahip bir ürün bulunamadı.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı ürün kodu!\nSatıcı Paneline Dönmek İçin Bir Tuşa Basınız...");
                        Console.ReadKey();
                    }

                }
                else if (selected == 2)
                {
                    if (sellervegetables.Count == 0 && Sellerfruit.Count == 0)
                    {
                        Console.WriteLine("Henüz Listenizde Ürün Bulunmamaktadır");
                        Console.WriteLine("Satıcı Paneline Dönmek İçin Bir Tuşa Basınız");

                        Console.ReadKey();
                    }
                    else
                    {
                        int minCountfruit = Math.Min(Sellerfruit.Count, Math.Min(Sellerfruitprice.Count, SellerProductCodeFruit.Count));
                        int minCountvegetables = Math.Min(sellervegetables.Count, Math.Min(SellervegetablesPrice.Count, SellerProductCodevegetables.Count));
                        for (int i = 0; i < minCountvegetables; i++)
                        {
                            Console.WriteLine($"{sellervegetables[i]} - {SellervegetablesPrice[i]} TL\n{SellerProductCodevegetables[i]}");
                        }
                        for (int i = 0; i < minCountfruit; i++)
                        {
                            Console.WriteLine($"{Sellerfruit[i]} - {Sellerfruitprice[i]} TL\n{SellerProductCodeFruit[i]}");
                        }
                        Console.Write("\nİşlem yapacağınız ürünün kodunu giriniz:");
                        string code = Console.ReadLine()!;
                        int productCode;
                        if (int.TryParse(code, out productCode))
                        {
                            int searchvegetables = SellerProductCodevegetables.IndexOf(productCode);
                            int searchfruit = SellerProductCodeFruit.IndexOf(productCode);
                            if (searchvegetables != -1)
                            {
                                void UpdateVegetablesPrice()
                                {
                                    Console.WriteLine("Mevcut Ürün Fiyatı: " + SellervegetablesPrice[searchvegetables] + " TL");
                                    Console.WriteLine("Yeni Ürün Fiyatını Giriniz: ");
                                    double newVegetablesPrice = Convert.ToDouble(Console.ReadLine()!);
                                    SellervegetablesPrice[searchvegetables] = newVegetablesPrice;
                                    Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                                }
                                void DeleteVegetables()
                                {
                                    Console.WriteLine("Silinecek Ürün Kodunu Giriniz: ");
                                    string deletecode = Console.ReadLine()!;
                                    int deleteProductCode;

                                    if (int.TryParse(deletecode, out deleteProductCode))
                                    {
                                        int deleteVegetables = SellerProductCodevegetables.IndexOf(deleteProductCode);
                                        if (deleteProductCode >= 1000 && deleteProductCode < 4000 && deleteVegetables != -1)
                                        {
                                            Console.WriteLine("Silme işlemini onaylıyor musunuz?(E/H)");
                                            string selected = Console.ReadLine()!;
                                            if (selected != "H")
                                            {
                                                SellerProductCodevegetables.RemoveAt(deleteVegetables);
                                                sellervegetables.RemoveAt(deleteVegetables);
                                                SellervegetablesPrice.RemoveAt(deleteVegetables);
                                                Console.WriteLine("***İşleminiz Başarıyla Gerçekleşti***\nBİR TUŞA BASINIZ...");
                                                Console.ReadKey();
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
                                }
                                void UpdateVegetablesName()
                                {
                                    Console.WriteLine("Mevcut Ürün Adı: " + sellervegetables[searchvegetables]);
                                    Console.WriteLine("Yeni İsmi Giriniz: ");
                                    string newVegetablesName = Console.ReadLine()!;
                                    sellervegetables[searchvegetables] = newVegetablesName;
                                    Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***\nBİR TUŞA BASINIZ...");
                                    Console.ReadKey();
                                }
                                Console.WriteLine(productCode + " No'lu Üründe gerçekleştirmek istediğiniz işlem nedir(1/2/3...):\n1.Ürün İsmini Değiştir:\n2.Ürünün Fiyatını Değiştir:\n3.Ürün Sil:\n4.Panelden Çıkış:\n");
                                Console.Write("İşlem Seçiniz:");
                                string select = Console.ReadLine()!;
                                int processSelectVegetables;
                                if (int.TryParse(select, out processSelectVegetables))
                                {
                                    if (productCode >= 1000 && productCode < 4000 && searchvegetables != -1)
                                    {
                                        switch (processSelectVegetables)
                                        {
                                            case 1:
                                                UpdateVegetablesName();
                                                Console.WriteLine("\nYeni Ürün Adı: " + sellervegetables[searchvegetables] + "\nSatıcı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case 2:
                                                UpdateVegetablesPrice();
                                                Console.WriteLine(sellervegetables[searchvegetables] + " = " + SellervegetablesPrice[searchvegetables] + " TL\nSatıcı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                DeleteVegetables();
                                                Console.Clear();
                                                break;
                                            case 4:
                                                Console.Clear();
                                                break;
                                            default:
                                                ErrorType();
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sebze Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            else if (searchfruit != -1)
                            {
                                void UpdateFruitName()
                                {
                                    Console.WriteLine("Mevcut Ürün Adı: " + Sellerfruit[searchfruit]);
                                    Console.WriteLine("Yeni İsmi Giriniz: ");
                                    string newfruitName = Console.ReadLine()!;
                                    Sellerfruit[searchfruit] = newfruitName;
                                    Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                                }
                                void UpdateFruitPrice()
                                {
                                    if (searchfruit != -1 && searchfruit < Sellerfruitprice.Count)
                                    {
                                        Console.WriteLine("Mevcut Ürün Fiyatı: " + Sellerfruitprice[searchfruit] + " TL");
                                        Console.WriteLine("Yeni Ürün Fiyatını Giriniz: ");
                                        double newFruitPrice = Convert.ToDouble(Console.ReadLine()!);
                                        Sellerfruitprice[searchfruit] = newFruitPrice;
                                        Console.WriteLine("\n***İŞLEM BAŞARIYLA GERÇEKLEŞTİ***");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı veya bulunamayan ürün kodu. İşlem iptal edildi.");
                                        Console.ReadKey();
                                    }
                                }
                                void DeleteFruit()
                                {
                                    Console.WriteLine("Silinecek Ürün Kodunu Giriniz: ");
                                    string deletecode = Console.ReadLine()!;
                                    int deleteProductCode;

                                    if (int.TryParse(deletecode, out deleteProductCode))
                                    {
                                        int deleteFruit = SellerProductCodevegetables.IndexOf(deleteProductCode);
                                        if (deleteProductCode >= 1000 && deleteProductCode < 4000 && deleteFruit != -1)
                                        {
                                            Console.WriteLine("Silme işlemini onaylıyor musunuz?(E/H)");
                                            string selected = Console.ReadLine()!;
                                            if (selected != "H")
                                            {
                                                SellerProductCodevegetables.RemoveAt(deleteFruit);
                                                Sellerfruit.RemoveAt(deleteFruit);
                                                Sellerfruitprice.RemoveAt(deleteFruit);
                                                Console.WriteLine("***İşleminiz Başarıyla Gerçekleşti***\nBİR TUŞA BASINIZ...");
                                                Console.ReadKey();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Meyve Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        ErrorType();
                                    }
                                }
                                Console.WriteLine(productCode + " No'lu Üründe gerçekleştirmek istediğiniz işlem nedir(1/2/3...):\n1.Ürün İsmini Değiştir:\n2.Ürünün Fiyatını Değiştir:\n3.Ürün Sil: \n4.Panelden Çıkış:\n");
                                Console.Write("İşlem Seçiniz:");
                                string select = Console.ReadLine()!;
                                int processSelectFruit;
                                if (int.TryParse(select, out processSelectFruit))
                                {
                                    if (productCode >= 4000 && productCode < 8001 && productCode != -1)
                                    {
                                        switch (processSelectFruit)
                                        {
                                            case 1:

                                                UpdateFruitName();
                                                Console.WriteLine("\nYeni Ürün Adı: " + Sellerfruit[searchfruit] + "\nSatıcı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;
                                            case 2:
                                                UpdateFruitPrice();
                                                Console.WriteLine(Sellerfruit[searchfruit] + " = " + Sellerfruitprice[searchfruit] + " TL\nSatıcı Paneline Dönmek İçin Bir Tuşa Basınız...");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                DeleteFruit();
                                                Console.Clear();
                                                break;
                                            case 4:
                                                Console.Clear();                                               
                                                break;
                                            default:
                                                ErrorType();
                                                break;


                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Meyve Kategorisinde Hatalı Ürün Kodu!!!\nGeri Dönmek İçin Bir Tuşa Basınız");
                                        Console.ReadKey();
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
                }
            }

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
