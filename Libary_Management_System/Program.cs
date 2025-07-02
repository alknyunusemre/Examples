namespace Libary_Management_System
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Title();
            while (true)
            {
                AnaMenuyuGoster();
            }

        }
        static string[] kitaplar = new string[10];
        static int limit = 0;
        static bool[] kitapdurumu = new bool[10];

        static void AnaMenuyuGoster()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************");
            Console.WriteLine("--ANA MENÜ--");
            Console.WriteLine("************");
            Console.ResetColor();
            Console.Write("\n1. Kitap Ekle");
            Console.Write("\n2. Kitapları Listele");
            Console.Write("\n3. Kitap Ödünç Al/İade Et");
            Console.Write("\n4. Çıkış");
            Console.Write("\n\nLütfen Bir Sayı Giriniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    KitapEkle();
                    break;
                case 2:
                    KitaplarıListele();
                    break;
                case 3:
                    KitapOduncAlIadeEt();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nKütüphane sistemini kullandığınız için teşekkürler. Güle güle!");
                    Console.ResetColor();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("** Hatalı Giriş Yaptınız! Lütfen Tekrar Deneyiniz.**");
                    Console.WriteLine("______________________________________________________\n");
                    Console.ResetColor();
                    //AnaMenuyuGoster();
                    break;
            }

        }
        static void Title()
        {
            #region Title Add.
            string title = "=== KÜTÜPHANE YÖNETİM SİSTEMİNE HOŞGELDİNİZ! ===";
            string title2 = "-------------------------------------------------";
            ///Konsol Genişliğini ve Metin Uzunluğunuz Alma
            int consolewidth = Console.WindowWidth;
            int titlelenght = title.Length;
            int title2lenght = title2.Length;
            ///Metin ve İmleci Ortalama
            int positionavarage = (consolewidth - titlelenght) / 2;
            int positionavaragecursor = Console.CursorTop;
            int positionavarage2 = (consolewidth - title2lenght) / 2;
            int positionavaragecursor2 = Console.CursorTop;
            ///İmleci Ortalanmış Konuma Yerleştir,Yazdır ve Renklendir   
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(positionavarage, positionavaragecursor);
            Console.WriteLine(title);
            Console.SetCursorPosition(positionavarage2, positionavaragecursor2 + 1);
            Console.WriteLine(title2);
            Console.ResetColor();
            #endregion
        }
        static void KitapEkle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nKitap Ekleme İşlemi Başladı...");
            Console.ResetColor();
            // Kitap ekleme işlemleri burada yapılacak.
            
           
            if (limit >= kitaplar.Length) 
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("**Kütüphane Dolu Daha Fazla Kitap Eklenemez!**");
                Console.WriteLine("______________________________________________\n");
                Console.ResetColor();
                return;
                
            }
            Console.WriteLine("Eklemek İstediğiniz "+ (limit+1)+". Kitap İsmi: ");
            string kitapekleme = Console.ReadLine()!.ToUpper();
            kitaplar[limit] = kitapekleme!;
            kitapdurumu[limit] = false;
            limit++;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(kitapekleme+" İsimli Kitabınız Başarıyla eklenmiştir.");
            Console.ResetColor();
            //AnaMenuyuGoster();
        }
        static void KitaplarıListele()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nKitapları Listeleme İşlemi Başladı...");
            Console.ResetColor();
            
            if (limit == 0) 
            {
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("KÜTÜPHANEDE HENÜZ KİTAP YOK!!!");
                Console.WriteLine("_______________________________\n");
                Console.ResetColor();
                
            }
            else
            {
            Console.Clear();
            for (int i=0; i<limit;i++) 
            {
                Console.WriteLine("---" + (i + 1) + ". KİTAP--- ");
                Console.WriteLine("Kitap İsmi: " + kitaplar[i].ToUpper());
                if (kitapdurumu[i] == true) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ÖDÜNÇ ALINDI!!");
                    Console.WriteLine("______________\n");
                    Console.ResetColor();
                    
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("RAFTA!!");
                    Console.WriteLine("_______\n");
                    Console.ResetColor();
                }
            }
            }
            

        }
        static void KitapOduncAlIadeEt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nKitap Ödünç Alma/İade Etme İşlemi Başladı...");
            Console.ResetColor();
            if (limit == 0) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("HENÜZ ÖDÜNÇ ALINACAK/İADE EDİLECEK KİTAP YOK!!");
                Console.WriteLine("______________________________________________\n");
                Console.ResetColor();
            }
            else
            {


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--KİTAP ÖDÜNÇ AL / İADE ET--");
                Console.WriteLine("____________________________\n");
                Console.ResetColor();
                Console.WriteLine("1. Ödünç Alınacak Ürün");
                Console.WriteLine("2. İade Edilecek Ürün");
                Console.Write("\n Lütfen Yapıcağınız işlemin Numarasını Seçiniz(1/2):");
                short secim = Convert.ToInt16(Console.ReadLine());
                Console.Write("Lütfen 1 ve " + limit + " Arasında İşlem Yapmak İstediğiniz Kitabın Numarasını Giriniz: ");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem < 1 || islem > limit)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GEÇERSİZ KİTAP NUMARASI!!!");
                    Console.WriteLine("__________________________");
                    Console.ResetColor();
                    //AnaMenuyuGoster();
                }
                if (secim == 1)
                {
                    for (int i = 0; i < limit; i++)
                    {
                        if (kitapdurumu[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Bu Kitap Ödünç Alınmış.");
                            Console.ResetColor();
                            // AnaMenuyuGoster();

                        }
                        else
                        {
                            kitapdurumu[i] = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Kitap Başarıyla Ödünç Alındı!");
                            Console.ResetColor();
                            //AnaMenuyuGoster();
                        }
                    }
                }

                else if (secim == 2)
                {
                    for (int i = 0; i < limit; i++)
                    {
                        if (kitapdurumu[i])
                        {
                            kitapdurumu[i] = false;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Kitap Başarıyla İade Edildi!");
                            Console.ResetColor();
                            // AnaMenuyuGoster();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Bu Kitap Zaten Rafta(Ödünç Alınmamış)");
                            Console.ResetColor();
                            //AnaMenuyuGoster();
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GEÇERSİZ İŞLEM SEÇİMİ");
                    Console.ResetColor();
                    // AnaMenuyuGoster();
                }
            }
        }
    }
}
