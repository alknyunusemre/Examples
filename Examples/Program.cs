using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1(); 
            //Example2();
            //Example3();
            //Example4();
            //Example5();
            //Example6();
            //Example7();
            //Example8();
            //Example9();
            //Example10();
        }
        #region Example 1
        static void Example1()
        {
            //Birbirinden farklı olarak verilen iki adet sayıdan, büyük olanı bulup gösteren algoritma ve akış diyagramını tasarlayınız.
            /*
            1.Başla
            2. Birinci değeri ekle
            3. İkinci değeri ekle
            4. İf-Else ve else-if blokları ile büyük olan sayıyı bul
            5.Bitir.
             */
            int number1 = 5;
            int number2 = 5;
            Console.WriteLine($"Birinci Sayı: {number1}");
            Console.WriteLine($"ikinci Sayı: {number2}");
            if (number1 < number2)
            {
                Console.WriteLine(number1 + " Sayısı " + number2 + " Sayısından Küçüktür");
            }
            else if (number1 == number2)
            {
                Console.WriteLine("İki sayı birbirine eşittir.");
            }
            else
            {
                Console.WriteLine(number1 + " Sayısı " + number2 + " Sayısından Büyüktür");
            }
        }
        #endregion 

        #region Example 2
        static void Example2()
        {
            //Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan algoritma ve akış diyagramını tasarlayınız.
            /*
             1.Başla
             2. İlk değeri ekle
            3. if-Else ve else if şart blokları ile sıfır, pozitif ya da negatif olup olmadığını bul.
            4.Bitir.
             */
            int number1 = 0;
            Console.WriteLine("Sayınız: " + number1);
            if (number1 == 0)
            {
                Console.WriteLine($"Sayınız '{number1}' (Nötr)");
            }
            else if (number1 < 0)
            {
                Console.WriteLine("Sayınız '" + number1 + "' Negatif");
            }
            else
            {
                Console.WriteLine("Sayınız '" + number1 + "' Pozitif");
            }

        }
        #endregion

        #region Example 3
        static void Example3()
        {
            //Ekrana 10 defa programcının adını yazan algoritmayı yapınız.
            /*
            1.Başla
            2."Console.WriteLine("Yunus Emre Alkan");" yaz.
            3. Kopyala yapıştır yap ve 10 kere yapınca dur.
            4.Bitti
             */
        }
        #endregion  

        #region Example 4
        static void Example4()
        {
            //Klavyeden girilen fiyatı, KDV(%18) ekleyerek ekrana yazdırın.
            /*
             * Başla.
             * Kullanıcıdan fiyat verisini girmesini iste.
             * verilen verinin işlemini gerçekleştir.(Convert)
             * Fiyatın KDV'sini(%18) al.
             * Kullanıcıyı Fiyatın KDV'sini(%18) göster.
             * Kullanıcının girdiği fiyata KDV(%18) ekle.
             * Kullanıcıya KDV eklenmiş fiyatı göster.
             * Bitti.
             */
            Console.Write("Ürün Fiyatını Giriniz: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double yuzdesi = yuzdeal(number1);
            Console.WriteLine("Girmiş Olduğunuz Fiyatın KDV'si(%18) " + yuzdesi);
            double sonuc = number1 + yuzdesi;
            Console.WriteLine("KDV eklenmiş tutarı: " + sonuc);

            static double yuzdeal(double number1, double number2 = 0.18)
            {

                double yuzdeal = number1 * number2;

                return yuzdeal;
            }

        }
        #endregion

        #region Example 5 
        static void Example5()
        {
            //Beş sayının toplamını ve ortalamasını veren programa ait algoritmayı oluşturunuz.
            /*
             * Başla
             * Kullanıcıdan 5 adet sayı girmesini iste.
             * Girilen verileri 'Convert' et
             * 5 sayıyı topla
             * Toplam sonucu consoleda göster
             * 5 sayının ort.sını al
             * Ort. sonucu consoleda göster
             * bitti
           */
            Console.Write("1. Sayıyı Giriniz: ");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz: ");
            int sayı3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("4. Sayıyı Giriniz: ");
            int sayı4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("5. Sayıyı Giriniz: ");
            int sayı5 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayı1 + sayı2 + sayı3 + sayı4 + sayı5;
            Console.WriteLine("Toplam: " + toplam);
            int ort = (sayı1 + sayı2 + sayı3 + sayı4 + sayı5) / 5;
            Console.WriteLine("Ortalama: " + ort);

        }
        #endregion

        #region Example 6
        static void Example6()
        {
            //Bir ürünü alış fiyatı üzerinden klavyeden vergi oranı ve kar oranı eklenerek satış fiyatına hesaplayan programın algoritması nedir?
            /*
             * Başla
             * Kullanıcıdan alış fiyatını öğren
             * Vergi oranını öğren
             * Vergi oranını hesapla
             * kar oranını öğren
             * kar oranını hesapla
             * Alış,kar ve vergi fiyatlarını topla
             * satış fiyatını göster
             * Bitir.
             */
            Console.Write("Alış Fiyatını Girini: ");

            decimal alıs = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Vergi Oranı (%): ");
            decimal vergi = Convert.ToDecimal(Console.ReadLine());
            decimal vergiyuzde = vergi / 100;
            decimal vergioranı = alıs * vergiyuzde;
            Console.Write("Kar Oranı (%): ");
            decimal kar = Convert.ToDecimal(Console.ReadLine());
            decimal karyuzde = kar / 100;
            decimal karoranı = alıs * karyuzde;
            decimal satisfiyati = alıs + karoranı + vergioranı;
            Console.WriteLine("Satış Fiyatı: " + satisfiyati);

        }
        #endregion

        #region Example 7
        static void Example7()
        {
            /*Öğrencinin bir dersten aldığı not klavyeden girilerek başarı durumu ekrana geçti veya kaldı şeklinde yazan uygulamanın algoritmasını oluşturunuz .*/
            /*
             * Başla
             * Ders Notunu Öğren
             * İf-else blokları kullanarak Girilen nota göre kaldı ve geçti bilgisi göster
             * Bitti
             */
            Console.Write("Ders Notunuzu Giriniz: ");
            int not = Convert.ToInt16(Console.ReadLine());
            if (not == 50 || not > 50)
            {
                Console.WriteLine("Dersten Geçtiniz!");
            }
            else
            {
                Console.WriteLine("Dersten Kaldınız!");
            }
        }
        #endregion

        #region Example 8
        static void Example8()
        {
            //Bir öğrencinin derslerinden 2 not ve 1 sözlü klavyeden girilerek başarı durumu ekrana “geçti” ve “kald”ı şeklinde yazan algoritmayı oluşturun.
            /*
             * Başla
             * 1. Ders Notunu öğren
             * 2.Ders Notunu Öğren
             * Sözlü Notunu Öğren
             * Notların Ortalamasını al
             * ortalamaya göre geçti veya kaldı bilgisini göster
             * Bitti
             */
            Console.Write("1.Sınav Puanı: ");
            int puan1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sınav Puanı: ");
            int puan2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sözlü Puanı: ");
            int soz = Convert.ToInt16(Console.ReadLine());
            int toport = (puan1 + puan2 + soz) / 3;
            if (toport ==50 || toport > 50) 
            {
                Console.WriteLine("Geçtiniz!");
            }
            else
            {
                Console.WriteLine("Kaldınız!");
            }
        }
        #endregion

        #region Example 9
        static void Example9()
        {
            //Kullanıcıdan alınan sayının tek ya da çift olduğunu  kontrol edip ekranda yazdıran algoritmayı oluşturun.
            /*
             * Başla
             * Kullanıcıdan bir sayı iste
             * Sayının ikiye bölünüp bölünmediğine
             * Bölünüyorsa çift bölünmüyorsa tek olduğunu kullanıcıya bildir.
             * Bitir
             */
            Console.Write("Bir Sayı Giriniz: ");
            int sayı = Convert.ToInt16(Console.ReadLine());

            if (sayı % 2 == 0 ) 
            {
                Console.WriteLine("Sayınız Çift");
            }
            else 
            {
                Console.WriteLine("Sayınız Tek");
            }
        }
        #endregion

        #region Example 10
        static void Example10() 
        {
            //Klavyeden girilen 10 sayıyı toplayan ve sonucu ekranda gösteren programın algoritmasını yazınız.
            /*
             * Başla.
             * Kullanıcıdan 10 adet sayı girmesini iste.
             * Bu sayıları toplayıp ekranda göster.
             * Bitir.
             */
            Console.Write("1. Sayıyı Giriniz: ");
            int sayi1= Convert.ToInt16(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("3. Sayıyı Giriniz: ");
            int sayi3 = Convert.ToInt16(Console.ReadLine());

            Console.Write("4. Sayıyı Giriniz: ");
            int sayi4 = Convert.ToInt16(Console.ReadLine());

            Console.Write("5. Sayıyı Giriniz: ");
            int sayi5 = Convert.ToInt16(Console.ReadLine());

            Console.Write("6. Sayıyı Giriniz: ");
            int sayi6 = Convert.ToInt16(Console.ReadLine());

            Console.Write("7. Sayıyı Giriniz: ");
            int sayi7 = Convert.ToInt16(Console.ReadLine());

            Console.Write("8. Sayıyı Giriniz: ");
            int sayi8 = Convert.ToInt16(Console.ReadLine());

            Console.Write("9. Sayıyı Giriniz: ");
            int sayi9 = Convert.ToInt16(Console.ReadLine());

            Console.Write("10. Sayıyı Giriniz: ");
            int sayi10 = Convert.ToInt16(Console.ReadLine());
            int toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7+ sayi8 +sayi9 + sayi10;
            Console.WriteLine("Girilen 10 sayının Toplamı: "+toplam);
        }
        #endregion
    }
}