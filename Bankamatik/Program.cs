using System.ComponentModel.Design;

namespace Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "$$$ BANKAMATİK PROJESİNE HOŞGELDİNİZ $$$";

            // Konsol genişliğini ve metnin uzunluğunu alma
            int consoleWidth = Console.WindowWidth; // Konsol genişliği
            int consoleLength = text.Length; // Metin uzunluğu
            // Başlangıç pozisyonu: ortalama konum
            int positionaverage = (consoleWidth - consoleLength) / 2; // Metni ortalamak için gerekli pozisyon
            int positionaveragecursor = Console.CursorTop; // İmlecin başlangıç konumu
            // İmleci ortalanmış konuma taşı ve yazdır
            Console.SetCursorPosition(positionaverage, positionaveragecursor);
            // ortalanmış metini yazdırma
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
            KartliKartsizIslem();

        }
        static double bakiye = 250;
        static void KartliKartsizIslem() //Kullanıcı Kartlı ve Kartsız İşlemi seçmek için buraya yönlendirilecek. 
        {

            Console.WriteLine("Kartlı İşlem için 1 Kartsız işlem için lütfen 2 ye basınız. ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Sifre();
                Console.WriteLine("");

            }
            else if (secim == 2)
            {
                Console.WriteLine("Kartsız işlem menüsüne aktarılıyorsunuz...");
                Console.WriteLine("");
                KartsizIslem();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz.");
                Console.ResetColor();
                KartliKartsizIslem();
            }
        }
        static void KartliIslem()// Kartlı işlemi seçtiği takdirde buraya atanacak
        {

            Console.WriteLine("KARTLI İŞLEM MENÜSÜNE HOŞGELDİNİZ!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Burada Şu işlemleri yapabilirsiniz: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Para Çekmek için lütfen 1'i Tuşlayınız.");
            Console.WriteLine("Para Yatırmak için lütfen 2'yi Tuşlayınız.");
            Console.WriteLine("Para Transferi için lütfen 3'ü Tuşlayınız.");
            Console.WriteLine("Eğitim Ödemeleri İçin Lütfen 4'ü Tuşlayınız.");
            Console.WriteLine("Ödemeler İçin Lütfen 5'i Tuşlayınız.");
            Console.WriteLine("Bilgi Güncellemeleri İçin Lütfen 6'yı Tuşlayınız.");
            Console.WriteLine("Geri Dönmek İçin 9'u Tuşlayınız.");
            Console.WriteLine("Çıkış Yapmak İçin 0'ı Tuşlayınız.");
            int girilenIslem = Convert.ToInt32(Console.ReadLine());
            if (girilenIslem == 1)
            {
                Console.Clear();
                Console.WriteLine("PARA ÇEKME İŞLEMİ SEÇİLDİ!");
                Console.WriteLine("");
                Console.WriteLine("Kullanılabilir Bakiyeniz: " + bakiye + "TL");
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                double cekilecekTutar = Convert.ToDouble(Console.ReadLine());
                if (cekilecekTutar <= bakiye && cekilecekTutar >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("İşleminiz Başarılı Bir Şekilde Gerçekleştirildi.");
                    Console.ResetColor();
                    double cekim = bakiye - cekilecekTutar;
                    bakiye -= cekilecekTutar;
                    Console.WriteLine("Kalan Bakiyeniz: " + cekim);
                    Console.WriteLine("");
                    MenuExit();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı Giriş Yaptınız!.");
                    Console.ResetColor();
                    Console.WriteLine("Menüye Dönmek İçin 9'u Tuşlayınız.");
                    Console.WriteLine("Çıkmak İçin 0'ı Tuşlayınız.");

                    int dön = Convert.ToInt32(Console.ReadLine());
                    if (dön == 9)
                    {
                        Console.Clear();
                        KartliIslem();
                    }
                    else if (dön == 0)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçerli Bir İşlem Seçmediğiniz İçin Menüye Aktarılıyorsunuz.");
                        Console.ResetColor();
                        KartliIslem();
                    }

                }

            }
            else if (girilenIslem == 2)
            {
                Console.Clear();
                Console.WriteLine("PARA YATIRMA İŞLEMİ SEÇİLDİ!");
                Console.WriteLine("");
                Console.WriteLine("Kredi Kartına Para Yatırmak İçin Lütfen 1'i Tuşlayınız");
                Console.WriteLine("Kendi Hesabınıza Yatırmak İçin Lütfen 2'yi Tuşlayınız.");
                Console.WriteLine("Kartlı İşlem Menüsüne Dönmek İçin Lütfen 9'u Tuşlayınız.");
                Console.WriteLine("Çıkmak İçin Lütfen 0'ı Tuşlayınız");
                int giris = Convert.ToInt32(Console.ReadLine());
                if (giris == 1)
                {
                    Console.Write("Lütfen 12 Haneli Kart Numaranızı Giriniz: ");
                    string? kartno = Console.ReadLine();
                    if (kartno?.Length == 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Kart Numaranız Kabul Edildi Aktarılıyorsunuz...");
                        Console.ResetColor();
                        KrediKartınaParaAktarım();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı Giriş Yaptınız Tekrar Deneyiniz.");
                        Console.ResetColor();
                        KartliIslem();
                    }
                }
                else if (giris == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Hesabınıza Gönderilecek Tutarı Giriniz:");
                    double tutar = Convert.ToDouble(Console.ReadLine());
                    double gelen = tutar + bakiye;
                    bakiye += tutar;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("İşleminiz Gerçekleşti!");
                    Console.WriteLine("Güncel Bakiye: " + bakiye);
                    Console.ResetColor();
                    MenuExit();
                }

                else if (giris == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Kartlı İşlem Menüsüne Aktarılıyorsunuz...");
                    KartliIslem();

                }
                else if (giris == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hatalı Tuşlama! Menüye Yönlendiriliyorsunuz.");
                    Console.ResetColor();
                    KartliIslem();

                }
            }
            else if (girilenIslem == 3)
            {
                Console.Clear();
                Console.WriteLine("PARA TRANSFERİ İŞLEMİ SEÇİLDİ!");
                Console.WriteLine("");
                Console.WriteLine("Başka Hesaba EFT Yapmak İçin Lütfen 1'i Tuşlayınız");
                Console.WriteLine("Başka Hesaba Havale Yapmak İçin Lütfen 2'yi Tuşlayınız");
                Console.WriteLine("Kartlı İşlem Menüsüne Dönmek İçin Lütfen 9'u Tuşlayınız.");
                Console.WriteLine("Çıkmak İçin Lütfen 0'ı Tuşlayınız");
                int girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen == 1)
                {
                    Console.Write("Lütfen 12 Haneli EFT Numaranısını giriniz: TR");
                    string? eft = Console.ReadLine();
                    Console.WriteLine("");
                    if (eft?.Length == 12)
                    {
                        Console.WriteLine("Bakiye: " + bakiye + " TL");
                        Console.WriteLine("TR" + eft + " Adresine Yatıralacak tutarı giriniz:");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        if (tutar <= bakiye)
                        {
                            bakiye -= tutar;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("İşleminiz Gerçekleşmiştir!");
                            Console.WriteLine("Kalan Bakiyeniz: " + bakiye);
                            Console.ResetColor();
                            MenuExit();

                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!");
                            Console.ResetColor();
                            MenuExit();
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ YAPTINIZ!");
                        Console.ResetColor();
                        KartliIslem();
                    }
                }
                else if (girilen == 2)
                {
                    Console.Write("Lütfen 11 Haneli Havale Numaranısını giriniz: ");
                    string? havale = Console.ReadLine();
                    Console.WriteLine("");
                    if (havale?.Length == 11)
                    {
                        Console.WriteLine("Bakiye: " + bakiye + " TL");
                        Console.WriteLine(havale + " Adresine Yatıralacak tutarı giriniz:");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        if (tutar <= bakiye)
                        {
                            bakiye -= tutar;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("İşleminiz Gerçekleşmiştir!");
                            Console.WriteLine("Kalan Bakiyeniz: " + bakiye);
                            Console.ResetColor();
                            MenuExit();

                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!");
                            Console.ResetColor();
                            MenuExit();
                        }
                    }
                    else if (girilen == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("Kartlı İşlem Menüsüne Aktarılıyorsunuz...");
                        KartliIslem();

                    }
                    else if (girilen == 0)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI TUŞLAMA! Kartlı İşlem Menüsüne Yönlendiriliyorsunuz.");
                        Console.ResetColor();
                        KartliIslem();

                    }
                }
            }
            else if (girilenIslem == 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EĞİTİM ÖDEMELERİ SAYFASI BAKIMDADIR... YAŞADIĞINIZ AKSAKLIKTAN ÖTÜRÜ ÖZÜR DİLERİZ :( ");
                Console.WriteLine("");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------");
                MenuExit();
            }
            else if (girilenIslem == 5)
            {
                Console.Clear();
                Console.WriteLine("Elekrik Faturası İçin 1'i Tuşlayınız");
                Console.WriteLine("Telefon Faturası İçin 2'yi Tuşlayınız");
                Console.WriteLine("İnternet Faturası İçin 3'ü Tuşlayınız");
                Console.WriteLine("Su Faturası İçin 4'ü Tuşlayınız");
                Console.WriteLine("OGS Ödemeleri İçin 5'i Tuşlayınız");
                Console.WriteLine("Kartlı İşlem Menüsüne Dönmek İçin 9'u Tuşlayınız.");
                Console.WriteLine("Çıkış Yapmak İçin 0'ı Tuşlayınız.");
                int girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen == 0)
                {
                    Environment.Exit(0);
                }
                else if (girilen == 1 || girilen == 2 || girilen == 3 || girilen == 4 || girilen == 5)
                {
                    Console.Clear();
                    Fatura();
                    MenuExit();
                }
                else if (girilen == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Kartlı İşlem Menüsüne Aktarılıyorsunuz!");
                    KartliIslem();
                }

            }
            else if (girilenIslem == 6)
            {
                Console.WriteLine("Şifre Değiştirmek İçin 1'i Tuşlayınız.");
                Console.WriteLine("Ana Menü İçin 9'u Tuşlayınız.");
                Console.WriteLine("Çıkış Yapmak İçin 0'ı Tuşlayınız.");
                int girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen == 1)
                {
                    Console.WriteLine("Mevcut Şifrenizi Giriniz:");
                    string? sifre2 = Console.ReadLine();
                    if (sifre2 == sifre)
                    {
                        Console.WriteLine("Yeni Şifreniz: ");
                        string? ysifre = Console.ReadLine();
                        Console.WriteLine("Yeni Şifreniz Tekrar: ");

                        string? ysifre2 = Console.ReadLine();
                        if (ysifre == ysifre2)
                        {
                            Console.WriteLine("GELİŞTİRME AŞAMASINDADIR... ANLAYIŞINIZ İÇİN TEŞEKKÜRLER :)");
                            MenuExit();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Girmiş Olduğunuz Şifreler Birbiriyle Eşleşmiyor.");
                            Console.ResetColor();
                            MenuExit();
                        }
                    }
                }
                else if (girilen == 0)
                {
                    Environment.Exit(0);
                }
                else if (girilen == 9)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ana Menüye Aktarılıyorsunuz...");
                    Console.ResetColor();
                    KartliKartsizIslem();
                }
                else
                {
                    Console.WriteLine("HATALI TUŞLAMA YAPTINIZ! Ana Menüye Aktarılıyorsunuz.");
                    MenuExit();
                }

            }
            else if (girilenIslem == 9)
            {
                KartliKartsizIslem();
            }
            else if (girilenIslem == 0)
            {
                Environment.Exit(0);
            }
        }


        static void KrediKartınaParaAktarım()
        {
            Console.Clear();
            Console.WriteLine("Bakiyeniz:" + bakiye + "TL");
            Console.Write("Kredi Kartınıza göndermek istediğiniz tutarı giriniz:");
            double tutar = Convert.ToDouble(Console.ReadLine());
            if (tutar <= bakiye && tutar >= 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kredi Kartına " + tutar + " TL Gönderilmiştir.");
                Console.ResetColor();
                bakiye -= tutar;
                Console.WriteLine("Güncel Bakiyeniz: " + tutar);
                Console.WriteLine("Ana Menüye Aktarılıyorsunuz.");
                KartliKartsizIslem();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı Giriş Yaptınız! Kartlı İşlem Menüsüne Aktarılıyorsunuz...");
                Console.ResetColor();
                KartliIslem();
            }
        }
        static void KartsizIslem()
        {

            Console.WriteLine("KARTSIZ İŞLEM MENÜSÜNE HOŞGELDİNİZ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Burada Şu işlemleri yapabilirsiniz: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("CepBank Para Çekmek İçin 1'i Tuşlayınız");
            Console.WriteLine("Para Yatırmak için 2'yi Tuşlayınız");
            Console.WriteLine("Kredi Kartı Ödeme için 3'ü Tuşlayınız");
            Console.WriteLine("Eğitim ödemeleri için 4'ü Tuşlayınız");
            Console.WriteLine("Ödemeler için 5'i Tuşlayınız");
            Console.WriteLine("Geri Dönmek için 9'u Tuşlayınız.");
            Console.WriteLine("Çıkış Yapmak İçin 0'ı Tuşlayınız.");
            int girilenislem = Convert.ToInt32(Console.ReadLine());
            if (girilenislem == 0)
            {
                Environment.Exit(0);
            }
            else if (girilenislem == 1)
            {
                string tc = "12345678911";
                string tel = "1234567899";
                Console.WriteLine("TC Kimlik numranızı veya Cep Telefon Numaranızı Giriniz (+90):.");
                string? info = Console.ReadLine();
                if (info == tc || info == tel)
                {
                    Console.Clear();
                    bakiye += 1000;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Güncellenmiş Bakiyeniz: " + bakiye);
                    Console.WriteLine("---------------------------------");
                    Console.ResetColor();
                    MenuExit();
                }
                else
                {
                    hak--;
                    if (hak > 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ YAPTINIZ KALAN DENEME HAKKINIZ: " + hak);
                        Console.ResetColor();
                        KartsizIslem();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hesabınız Askıya Alındı " + DateTime.Now.AddHours(1) + " Tarihine kadar Girişiniz Bloke Edildi");
                        Console.ResetColor();

                    }
                }


            }
            else if (girilenislem == 2)
            {
                Console.Clear();
                Console.WriteLine("Nakit Ödeme İçin 1'i Tuşlayınız");
                Console.WriteLine("Hesaptan Ödeme İçin 2'yi Tuşlayınız");
                Console.WriteLine("Ana Menüye Dönmek İçin 9'u Tuşlayınız");
                Console.WriteLine("Çıkış Yapmak İçin 0'ı Tuşlayınız");
                int girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen == 1)
                {
                    Console.Write("12 Haneli Kart Numranızı Giriniz:");
                    string? kart = Console.ReadLine();
                    if (kart?.Length >= 12)
                    {
                        Console.Clear();
                        Console.Write("Yüklenecek Tutarı Giriniz: ");
                        double tutar = Convert.ToDouble(Console.ReadLine());
                        if (bakiye >= tutar)
                        {
                            bakiye += tutar;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("İşleminiz Başarıyla Gerçekleşmiştir!");
                            Console.WriteLine("Güncel Bakiyeniz: " + bakiye);
                            Console.ResetColor();
                            MenuExit();
                        }
                        else
                        {
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("Bakiye Yetersiz! Yükleme Yapıp Tekrar Deneyiniz.");
                            Console.ResetColor();
                            MenuExit();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı Giriş Yaptınız!");
                        Console.ResetColor();
                        MenuExit();
                    }
                }
                else if (girilen == 2)
                {
                    Console.Write("12 Haneli Kart Numranızı Giriniz:");
                    string? kart = Console.ReadLine();
                    if (kart?.Length >= 12)
                    {
                        Console.Clear();
                        Console.Write("Çekilecek Tutarı Giriniz: ");
                        double tutar = Convert.ToDouble(Console.ReadLine());
                        if (bakiye >= tutar)
                        {
                            bakiye -= tutar;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("İşleminiz Başarıyla Gerçekleşmiştir!");
                            Console.WriteLine("Güncel Bakiyeniz: " + bakiye);
                            Console.ResetColor();
                            MenuExit();
                        }
                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bakiye Yetersiz! Yükleme Yapıp Tekrar Deneyiniz.");
                            Console.ResetColor();
                            MenuExit();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı Giriş Yaptınız!");
                        Console.ResetColor();
                        MenuExit();
                    }
                }
                else if (girilen == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Ana Menüye Aktarılıyorsunuz...");
                    KartliKartsizIslem();
                }
                else if (girilen == 0)
                {
                    Environment.Exit(0);
                }
            }
            else if (girilenislem == 3)
            {
                Console.WriteLine("Başka Hesaba EFT Yapmak İçin Lütfen 1'i Tuşlayınız");
                Console.WriteLine("Başka Hesaba Havale Yapmak İçin Lütfen 2'yi Tuşlayınız");
                int girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen == 1)
                {
                    Console.Write("Lütfen 12 Haneli EFT Numaranısını giriniz: TR");
                    string? eft = Console.ReadLine();
                    Console.WriteLine("");
                    if (eft?.Length == 12)
                    {
                        Console.WriteLine("Bakiye: " + bakiye + " TL");
                        Console.WriteLine("TR" + eft + " Adresine Yatıralacak tutarı giriniz:");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        if (tutar <= bakiye)
                        {
                            bakiye -= tutar;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("İşleminiz Gerçekleşmiştir!");
                            Console.WriteLine("Kalan Bakiyeniz: " + bakiye);
                            Console.ResetColor();
                            MenuExit();

                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!");
                            Console.ResetColor();
                            MenuExit();
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ YAPTINIZ!");
                        Console.ResetColor();
                        KartsizIslem();
                    }
                }
                else if (girilen == 2)
                {
                    Console.Write("Lütfen 11 Haneli Havale Numaranısını giriniz: ");
                    string? havale = Console.ReadLine();
                    Console.WriteLine("");
                    if (havale?.Length == 11)
                    {
                        Console.WriteLine("Bakiye: " + bakiye + " TL");
                        Console.WriteLine(havale + " Adresine Yatıralacak tutarı giriniz:");
                        int tutar = Convert.ToInt32(Console.ReadLine());
                        if (tutar <= bakiye)
                        {
                            bakiye -= tutar;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("İşleminiz Gerçekleşmiştir!");
                            Console.WriteLine("Kalan Bakiyeniz: " + bakiye);
                            Console.ResetColor();
                            MenuExit();

                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("HATALI GİRİŞ YAPTINIZ!");
                            Console.ResetColor();
                            MenuExit();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ YAPTINIZ!");
                        Console.ResetColor();
                        KartsizIslem();
                    }
                }
            }
            else if (girilenislem == 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("EĞİTİM ÖDEMELERİ SAYFASI BAKIMDADIR... YAŞADIĞINIZ AKSAKLIKTAN ÖTÜRÜ ÖZÜR DİLERİZ :( ");
                Console.WriteLine("");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------------------------------------");
                MenuExit();
            }
            else if (girilenislem == 5)
            {
                Console.Clear();
                Console.WriteLine("Elekrik Faturası İçin 1'i Tuşlayınız");
                Console.WriteLine("Telefon Faturası İçin 2'yi Tuşlayınız");
                Console.WriteLine("İnternet Faturası İçin 3'ü Tuşlayınız");
                Console.WriteLine("Su Faturası İçin 4'ü Tuşlayınız");
                Console.WriteLine("OGS Ödemeleri İçin 5'i Tuşlayınız");
                Console.WriteLine("Kartsız İşlem Menüsüne Dönmek İçin 9'u Tuşlayınız.");
                Console.WriteLine("Çıkış Yapmak İçin 0'ı Tuşlayınız.");
                int girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen == 0)
                {
                    Environment.Exit(0);
                }
                else if (girilen == 1 || girilen == 2 || girilen == 3 || girilen == 4 || girilen == 5)
                {
                    Console.Clear();
                    Fatura();
                    MenuExit();
                }
                else if (girilen == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Kartsız İşlem Menüsüne Aktarılıyorsunuz!");
                    KartsizIslem();
                }

            }
            else if (girilenislem == 9)
            {
                KartliKartsizIslem();
            }
        }
        static string sifre = "ab18";
        static int hak = 3;
        static void Sifre()
        {

            Console.Write("Lütfen Şifrenizi Giriniz: ");

            string? girilensifre = Console.ReadLine();
            if (girilensifre == sifre)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("Şifreniz Doğru. Kartlı İşlem Menüsüne Yönlendiriliyorsunuz...");
                Console.WriteLine("");
                Console.ResetColor();
                KartliIslem();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                hak--;
                if (hak > 0)
                {

                    Console.WriteLine("Girmiş OLduğunuz Şifre Hatalıdır! Kalan Deneme Hakkınız:" + hak);
                    Sifre();
                }
                else
                {
                    Console.WriteLine("HESABINIZA GİRİŞ YAPILAMADI");
                    Console.ResetColor();
                    Environment.Exit(0);

                }

            }
        }
        static void MenuExit()
        {
            Console.WriteLine("Ana Menüye Dönmek İçin Lütfen 9'u Tuşlayınız.");
            Console.WriteLine("Çıkmak İçin Lütfen 0'ı Tuşlayınız");
            int giris = Convert.ToInt32(Console.ReadLine());
            if (giris == 9)
            {
                Console.Clear();
                Console.WriteLine("ANA MENÜYE AKTARILIYORSUNUZ...");
                KartliKartsizIslem();

            }
            else if (giris == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı Tuşlama! Menüye Yönlendiriliyorsunuz.");
                Console.ResetColor();
                KartliKartsizIslem();

            }
        }
        static void Fatura()
        {

            Console.WriteLine("Bakiyeniz: " + bakiye + "TL");

            Console.WriteLine("Fatura Tutarını Giriniz: ");
            double fatura = Convert.ToDouble(Console.ReadLine());
            if (bakiye > fatura)
            {
                bakiye -= fatura;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Faturanız Ödenmiştir!");
                Console.WriteLine("Güncel Bakiyeniz: " + bakiye);
                Console.ResetColor();
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("İŞLEMİNİZ BAŞARIZ OLDU!");
                Console.ResetColor();
                Console.WriteLine("Bakiyeniz: " + bakiye + "TL");
                MenuExit();
            }
        }

    }
}


