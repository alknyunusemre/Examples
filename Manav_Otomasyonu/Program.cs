using System.Collections;
using System.Reflection.Metadata;

namespace Manav_Otomasyonu
{
    internal class Program
    {
        static ArrayList usernames = new ArrayList();
        static ArrayList passwords = new ArrayList();
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
                            LoginPanel();
                            break;
                        case 2:
                            LoadingPanel();
                            break;
                        case 3:
                            LoadingPanel();
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
        static void Toptancı()
        {
        }
        static void Manav()
        {
        }
        static void Müşteri()
        {
        }

        static void LoginPanel()
        {
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
                        SignUp();
                        break;

                    case 2:

                        while (hak > 0)
                        {

                            Console.WriteLine("Kullanıcı Adınız: ");
                            string userName = Console.ReadLine()!;
                            Console.WriteLine("Şifre: ");
                            string password = Console.ReadLine()!;
                            bool login = false;
                            for (int i = 0; usernames.Count > i; i++)
                            {
                                if (userName == (string)usernames[i]! && password == (string)passwords[i]!)
                                {
                                    login = true;
                                }
                            }
                            if (login)
                            {
                                Console.WriteLine($"GİRİŞ BAŞARILI HOŞGELDİNİZ {userName} YÖNLENDİRİLİYORSUNUZ...");
                                return;

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

        
        static void SignUp()
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
                    usernames.Add(username);
                    passwords.Add(password);
                    Console.WriteLine("KAYIT OLUNDU. GİRİŞ PANELİNE YÖNLENDİRİLİYORSUNUZ");
                    Thread.Sleep(2000);
                    LoginPanel();
                }

            }
        }

    }
}
