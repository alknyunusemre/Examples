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
            Console.WriteLine("");
            Console.WriteLine("Burada Şu işlemleri yapabilirsiniz: ");
            Console.WriteLine(" ");
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
                Console.WriteLine("Para Çekme İşlemi Seçildi!");
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
                    Console.WriteLine("Ana Menüye Aktarılıyorsunuz...");
                    KartliKartsizIslem();
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
                Console.WriteLine("Para Yatırma İşlemi Seçildi!");
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
                    Console.WriteLine("Ana Menüye Aktarılıyorsunuz...");
                    KartliKartsizIslem();
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

            Console.WriteLine("Kartsız İşlem Menüsüne Hoşgeldiniz.");
            Console.WriteLine("Burada Şu işlemleri yapabilirsiniz: ");
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
    }
}

