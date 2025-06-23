namespace _18_06_2025_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru1(); //Kullanıcının adını, yaşını ve boyunu (metre cinsinden) alıp ekrana yazdıran bir program yazın.
            //Soru2(); //değişkenleri tanımlayın ve uygun değerler atayın
            //Soru3(); //Kullanıcıdan bir sayı alın ve bu sayıyı hem int hem de double veri tipine dönüştürerek ekrana yazdırın.
            //Soru4(); //double türünde bir değişken oluşturun ve bu değişkenin değerini string olarak ekrana yazdırın.
            //Soru5(); //İki tam sayı alın ve bu sayılar üzerinden toplama çıkarma çarpma ve bölme işlemlerini yaparak sonuçları ekrana yazdır.
            //Soru6(); //Kullanıcıdan İki Sayı Alın ve Bu Sayıların Birbirine eşit olup olmadığını Kontrol Edin.Sonucu Ekrana Yazdır.
            //Soru7(); // Kullanıcıdan alınan sayının tek mi çift mi olduğunu bul.
            //Soru8(); //Kullanıcadan alınan sıcaklık değerinin sıfır derecenin altındamı üstündemi olduğunu bul "Dondurucu Soğuk!" mesajını yazdır.
        }
        static void Soru1() 
        {
            #region Soru 1:
            //Kullanıcının adını, yaşını ve boyunu (metre cinsinden) alıp ekrana yazdıran bir program yazın.
            Console.Write("Adınızı girin: ");
            string? ad = Console.ReadLine();
            Console.Write("Yaşınızı girin: ");
            string? yas = Console.ReadLine();
            Console.Write("Boyunuzu (metre cinsinden) girin: ");
            string? boy = Console.ReadLine();
            Console.WriteLine($"Adınız: {ad}, Yaşınız: {yas}, Boyunuz:{boy}");
            #endregion
        }
        static void Soru2()
        {
            #region Soru 2:
            //değişkenleri tanımlayın ve uygun değerler atayın
            bool isStudent = false;
            char grade = '1';
            float temperature = 18.4f;
            Console.WriteLine($"Öğrenci mi: {isStudent}, Seviye: {grade}, Sıcaklık: {temperature}°C");
            #endregion
        }
        static void Soru3()
        {
            #region Soru 3:
            //Kullanıcıdan bir sayı alın ve bu sayıyı hem int hem de double veri tipine dönüştürerek ekrana yazdırın.
            Console.Write("Bir sayı girin: ");
            int sayiint = Convert.ToInt32(Console.ReadLine());
            double sayidouble = Convert.ToDouble(sayiint);
            Console.WriteLine($"Sayı (int): {sayiint}, Sayı (double): {sayidouble}");
            #endregion
        }
        static void Soru4()
        {
            #region Soru 4:
            //double türünde bir değişken oluşturun ve bu değişkenin değerini string olarak ekrana yazdırın.
            double sayi = 10.3;
            string sayist = Convert.ToString(sayi);
            Console.WriteLine($"Sayı: {sayist}");
            #endregion
        }
        static void Soru5()
        {
            #region Soru 5:
            //İki tam sayı alın ve bu sayılar üzerinden toplama çıkarma çarpma ve bölme işlemlerini yaparak sonuçları ekrana yazdır.
            Console.Write("1. Sayıyı Giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            double toplama = sayi1 + sayi2;
            double cikarma = sayi1 - sayi2;
            double carpma = sayi1 * sayi2;
            double bölme = sayi1 / sayi2;
            Console.WriteLine($"Toplam: {toplama}, Kalan: {cikarma}, Çarpım: {carpma}, Bölüm:{bölme} ");
            #endregion
        }
        static void Soru6()
        {
            #region Soru 6:
            //Kullanıcıdan İki Sayı Alın ve Bu Sayıların Birbirine eşit olup olmadığını Kontrol Edin.Sonucu Ekrana Yazdır.
            Console.Write("Birinci Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            bool esit = sayi1 == sayi2;
            Console.WriteLine(esit);
            #endregion
        }
        static void Soru7()
        {
            #region Soru 7:
           // Kullanıcıdan alınan sayının tek mi çift mi olduğunu bul.
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool tekcift = sayi % 2 == 0;
            Console.WriteLine(tekcift);
            #endregion
        }
        static void Soru8()
        {
            #region Soru 8:
            //Kullanıcadan alınan sıcaklık değerinin sıfır derecenin altındamı üstündemi olduğunu bul "Dondurucu Soğuk!" mesajını yazdır.
            Console.Write("Sıcaklık Değerini Giriniz: ");
            float sicaklik = Convert.ToSingle(Console.ReadLine());
            if (sicaklik < 0)
            {
                Console.WriteLine("Dondurucu Soğuk!");
            }
            else
            {
                Console.WriteLine("Sıcaklık Sıfır Derecenin Üzerinde!");
            }
            #endregion
        }
    }

}
