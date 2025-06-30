namespace _25_06_2025_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Soru1: Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız.
            //Console.Write("Birinci Ürünün Fiyatını Griniz: ");
            //double urun1Fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.Write("İkinci Ürünün Fiyatını Griniz: ");
            //double urun2Fiyat = Convert.ToDouble(Console.ReadLine());
            //double toplamurunfiyat = urun1Fiyat + urun2Fiyat;
            //if (toplamurunfiyat<=2500)
            //{
            //    Console.Write("Ürünlerin Toplam Fiyatı: "+toplamurunfiyat);
            //}
            //else 
            //{
            //    double ucuzurunFiyat = Math.Min(urun1Fiyat, urun2Fiyat);
            //    double indirimliFiyat = ucuzurunFiyat * 0.75;
            //    Console.WriteLine("Ürünlerin toplam fiyatı 2500 TL'yi geçtiği için düşük fiyatlı ürüne uygulanan %25'lik indirimli fiyat: " + indirimliFiyat);
            //}
            #endregion
            #region Soru2: Öğrenciden vize ve final notlarını alınız ve vize %40 final %60 alınarak ortalamasını hesaplayınız.
            //don:

            //Console.Write("Vize Notunu Giriniz: ");
            //double vizeNotu = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Final Notunu Giriniz: ");
            //double finalNotu = Convert.ToDouble(Console.ReadLine());
            //double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
            //if (ortalama<0) 
            //{
            //    Console.Clear();
            //    Console.WriteLine("Notlar negatif olamaz!");
            //    goto don;
            //}
            //else if (ortalama==0 || ortalama<=24) 
            //{
            //    Console.WriteLine("Ortalama Puanınız: " + ortalama + " Notunuz: FF");
            //}
            //else if (ortalama==25 || ortalama<=44) 
            //{
            //    Console.WriteLine("Ortalama Puanınız: " + ortalama + " Notunuz: DD");
            //}
            //else if (ortalama == 45 || ortalama <= 54)
            //{
            //    Console.WriteLine("Ortalama Puanınız: " + ortalama + " Notunuz: CC");
            //}
            //else if (ortalama == 55 || ortalama <= 69)
            //{
            //    Console.WriteLine("Ortalama Puanınız: " + ortalama + " Notunuz: CB");
            //}
            //else if (ortalama == 70 || ortalama <= 84)
            //{
            //    Console.WriteLine("Ortalama Puanınız: " + ortalama + " Notunuz: BB");
            //}
            //else if (ortalama == 85 || ortalama <= 100)
            //{
            //    Console.WriteLine("Ortalama Puanınız: " + ortalama + " Notunuz: AA");
            //}
            #endregion
            #region Soru3: 1-50 arasındaki sayıların içinde 7'e tam bölünenleri ekrana teker teker yazdırınız.
            //for (int sayi=1;sayi<=50;sayi++) 
            //{ 
            //    Console.WriteLine(sayi);
            //    if (sayi%7==0)
            //    {
            //        Console.WriteLine("\n"+sayi+" Bu Sayı 7'ye Tam Bölünür.\n");
            //    }  
            //}

            #endregion
            #region Soru4: Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.
            /*
                Eğer kulanıcının yaşı 45'in altındaysa;
                    Çocuk sayısına bakılacak.Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                          3 ve 3'ten çok ise çocuk başına 2000₺ 
                                                                maaşa ekleme yapılacak.
                45 ve 45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
                Son olarak ekrana: "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak.
             */
            //Console.Write("İsminizi Giriniz: ");
            //string isim = Console.ReadLine()!;
            //Console.Write("Yaşınızı Giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Maaşınızı Giriniz: ");
            //double maas = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Çocuk Sayınızı Giriniz: ");
            //int cocuksayisi = Convert.ToInt32(Console.ReadLine());
            //if (yas >= 45)
            //{
            //    Console.WriteLine("45 Yaşından Büyük Olduğunuz İçin Çocuk Başına Para Alamıyorsunuz Ancak Maaşınıza '5000 TL' Ekleme Yapılacaktır.");
            //    maas += 5000;
            //}
            //else 
            //{
            //    if (cocuksayisi < 3)
            //    {
            //        maas += cocuksayisi * 2500;
            //    }
            //    else if (cocuksayisi >= 3)
            //    {
            //        maas += cocuksayisi * 2000;
            //    }
            //}
            //Console.WriteLine($"{isim}, Maaşınız: {maas}TL");
            #endregion
        }
    }
}
