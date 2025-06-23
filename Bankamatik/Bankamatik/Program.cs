namespace Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "-- BANKAMATİK PROJESİNE HOŞGELDİNİZ--";
            //// Konsol genişliğini ve metnin uzunluğunu alma
            int consoleWidth = Console.WindowWidth; // Konsol genişliği
            int consoleLength = text.Length; // Metin uzunluğu
            // Başlangıç pozisyonu: ortalama konum
            int positionaverage = (consoleWidth - consoleLength) / 2; // Metni ortalamak için gerekli pozisyon
            int positionaveragecursor = Console.CursorTop; // İmlecin başlangıç konumu
            // İmleci ortalanmış konuma taşı ve yazdır
            Console.SetCursorPosition(positionaverage, positionaveragecursor);
            // ortalanmış metini yazdırma
            Console.WriteLine(text);
            KartlıKartsızIslem();

        }
        static void Bakiye() 
        {
            double bakiye = 250;
            Console.WriteLine("Bakiyeniz: " + bakiye + " TL");
        }
        static void KartlıKartsızIslem()
        {
            Console.WriteLine("Kartlı İşlem için 1 Kartsız işlem için lütfen 2 ye basınız. ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Kartlı işlem menüsüne aktarılıyorsunuz...");
                Console.WriteLine("");
                KartliIslem();
            }
            else if (secim == 2)
            {
                Console.WriteLine("Kartsız işlem menüsüne aktarılıyorsunuz...");
                Console.WriteLine("");
                KartsizIslem();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir işlem seçiniz.");
                KartlıKartsızIslem();
            }
        }
        static void KartliIslem()
        {
            Console.WriteLine("Kartlı İşlem Menüsüne Hoşgeldiniz.");
            Console.WriteLine("");
            Console.WriteLine("Burada Şu işlemleri yapabilirsiniz: ");
            Console.WriteLine(" ");
            Console.WriteLine("Para Çekmek için lütfen 1'i Tuşlayınız.");
            
            Console.WriteLine("Para Yatırmak için lütfen 2'yi Tuşlayınız.");
            Console.WriteLine("Para Transferi için lütfen 3'ü Tuşlayınız.");
            Console.WriteLine("Eğitim Ödemeleri İçin Lütfen 4'ü Tuşlayınız.");
            Console.WriteLine("Ödemeler İçin Lütfen 5'i Tuşlayınız.");
            Console.WriteLine("Bilgi Güncellemeleri İçin Lütfen 6'yı Tuşlayınız.");
            int girilenIslem = Convert.ToInt32(Console.ReadLine());
            if (girilenIslem == 1) 
            {
                Console.WriteLine("Para Çekme İşlemi Seçildi.");
                Console.WriteLine("");
                Bakiye();
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                double cekilecekTutar = Convert.ToDouble(Console.ReadLine());
                if (cekilecekTutar<=250) 
                {
                    Console.WriteLine("İşleminiz Başarılı Bir Şekilde Gerçekleştirildi.");
                }
                else
                {
                    Console.WriteLine("Yetersiz Bakiye. Lütfen Daha Az Bir Tutar Giriniz.");
                    
                    Console.WriteLine("Menüye Tekrar Dönmek İçin 9'u Tuşlayınız.");

                    int dön = Convert.ToInt32(Console.ReadLine());
                    if (dön == 9)
                    {
                        KartliIslem();
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz.");
                    }
                    
                }
            }
        }
        static void KartsizIslem()
        {
            Console.WriteLine("Kartsız İşlem Menüsüne Hoşgeldiniz.");
            Console.WriteLine("Burada Şu işlemleri yapabilirsiniz: ");
        }
    }
}
