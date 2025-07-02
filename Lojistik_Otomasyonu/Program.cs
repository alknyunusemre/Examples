namespace Lojistik_Otomasyonu
{
    internal class Program
    {
        #region Ana Menü
        static void Main(string[] args)
        {
            #region Ortalanmış Başlık    
            string baslik2 = "***********************";
            string baslik = "* LOJİSTİK OTOMASYONU *";
            string baslik3 = "***********************";
            int genislik = Console.WindowWidth;
            int metinuzunluk = baslik.Length;
            int metinuzunluk2 = baslik2.Length;
            int metinuzunluk3 = baslik3.Length;
            int ortalama = (genislik - metinuzunluk) / 2;
            int imlecort = Console.CursorTop;
            int ortalama2 = (genislik - metinuzunluk2) / 2;
            int imlecort2 = Console.CursorTop;
            int ortalama3 = (genislik - metinuzunluk3) / 2;
            int imlecort3 = Console.CursorTop;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(ortalama2, imlecort2);
            Console.WriteLine(baslik2);
            Console.SetCursorPosition(ortalama, imlecort + 1);
            Console.WriteLine(baslik);
            Console.SetCursorPosition(ortalama3, imlecort2 + 2);
            Console.WriteLine(baslik3);
            Console.ResetColor();
            #endregion
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("          ANA MENÜ         ");
                Console.WriteLine("***************************\n");
                Console.ResetColor();
                Console.WriteLine("1. Yeni Kargo Ekle");
                Console.WriteLine("2. Kargoları Listele");
                Console.WriteLine("3. Kargo Durumunu Güncelle");
                Console.WriteLine("4. Çıkış");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n***************************");
                Console.Write("Lütfen yapmak istediğiniz işlemin numarasını giriniz: ");
                string secim = Console.ReadLine()!;
                Console.ResetColor();
                Console.WriteLine("\n");
                int secimparse;
                if (int.TryParse(secim, out secimparse))
                {
                    switch (secimparse)
                    {
                        case 1:
                            YeniKargoEkle();
                            break;
                        case 2:
                            KargoListeleme();
                            break;
                        case 3:
                            KargoDurumunuGüncelle();
                            break;
                        case 4:
                            Cikis();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("HATALI İŞLEM NUMARASI TUŞLADINIZ!!!");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("****************************************\n");
                            Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            break;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nHATALI TUŞLAMA YAPTINIZ!! LÜTFEN GEÇERLİ BİR TUŞLAMA YAPINIZ...");
                    Console.WriteLine("----------------------------------------------------------------\n");
                    Console.ResetColor();
                }
            }

        }
        #endregion 
        #region Diziler
        static string[] takipnumaraları = new string[10];
        static string[] hedefadresler = new string[10];
        static string[] kargodurumları = new string[10];
        static int kargosayisi = 0;
        #endregion
        #region Yeni Kargo Ekleme
        static void YeniKargoEkle()
        {
            Console.Clear();
            if (kargosayisi == takipnumaraları.Length)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nKargo kapasitesi dolu daha fazla kargo eklenemez!!!");
                Console.Write("-----------------------------------------------------\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n****************************************\n");
                Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                Console.ReadKey();
                Console.ResetColor();
                return;
            }
            else
            {
                Console.Write("Lütfen Kargonuzun Takip Numarasını Giriniz: ");
                string takipnumarası = Console.ReadLine()!;
                takipnumaraları[kargosayisi] = takipnumarası;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("*******************************************\n");
                Console.ResetColor();
                Console.Write("Hedef Adresi Giriniz:");
                string adres = Console.ReadLine()!;
                hedefadresler[kargosayisi] = adres;
                kargodurumları[kargosayisi] = "Hazırlanıyor";
                kargosayisi++;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n***********************");
                Console.WriteLine("KARGO BAŞARIYLA EKLENDİ");
                Console.WriteLine("***********************\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n****************************************\n");
                Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
                return;
            }
        }
        #endregion
        #region Kargo Listeleme
        static void KargoListeleme()
        {
            if (kargosayisi == 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n*******************************");
                Console.WriteLine("HENÜZ SİSTEME KAYITLI KARGO YOK");
                Console.WriteLine("*******************************\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n****************************************\n");
                Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n****************************************\n");
                Console.ResetColor();
                for (int i = 0; i < kargosayisi; i++)
                {
                    Console.WriteLine("---" + (i + 1) + " No'lu Kargo---");
                    string takipno = takipnumaraları[i];
                    string adres = hedefadresler[i];
                    string kargodurum = kargodurumları[i];
                    Console.Write("Kargo Takip Numaranız: " + takipno);
                    Console.Write("\nAdres: " + adres);
                    Console.Write("\nKargo Durumu: ");
                    if (kargodurum == "Hazırlanıyor")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(kargodurum);
                        Console.ResetColor();
                    }
                    else if (kargodurum == "Yolda")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(kargodurum);
                        Console.ResetColor();
                    }
                    else if (kargodurum == "Teslim Edildi")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(kargodurum);
                        Console.ResetColor();
                    }
                    else if (kargodurum == "İptal Edildi")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(kargodurum);
                        Console.ResetColor();
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n****************************************\n");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
                return;
            }
        }
        #endregion
        #region Kargo Durumu
        static void KargoDurumunuGüncelle()
        {
            if (kargosayisi == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("HENÜZ DURUMU GÜNCELLENCEK KARGO YOK");
                Console.WriteLine("-----------------------------------");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("****************************************\n");
                Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n****************************************\n");
                Console.ResetColor();
                for (int i = 0; i < kargosayisi; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("      ---" + (i + 1) + " No'lu Kargo---          ");
                    Console.ResetColor();
                    Console.WriteLine("Takip No: " + takipnumaraları[i]);
                    Console.WriteLine("Adres: " + hedefadresler[i]);
                    Console.WriteLine("Durum: " + kargodurumları[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n****************************************\n");
                    Console.ResetColor();

                }
                int dönüşenkargono = 0;
                bool gecerligiris = false;
                int kargoindex = -1;
                while (!gecerligiris)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Güncellemek İstediğiniz Kargonun Numarasını Giriniz:");
                    string kargono = Console.ReadLine()!;
                    Console.ResetColor();

                    if (int.TryParse(kargono, out dönüşenkargono))
                    {
                        if (dönüşenkargono >= 1 && dönüşenkargono <= kargosayisi)
                        {
                            gecerligiris = true;
                            kargoindex = dönüşenkargono - 1;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("GEÇERSİZ KARGO NUMARASI");
                            Console.WriteLine("------------------------\n");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("****************************************\n");
                            Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.Clear();
                            return;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(" HATALI GİRİŞ FORMATI!!");
                        Console.WriteLine("------------------------\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("****************************************\n");
                        Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        return;
                    }

                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n--- {dönüşenkargono} No'lu Güncelleme Ekranı ---\n");
                Console.ResetColor();
                Console.WriteLine($"Mevcut Takip No: {takipnumaraları[kargoindex]}");
                Console.WriteLine($"Mevcut Adres: {hedefadresler[kargoindex]}");
                Console.WriteLine($"Mevcut Durum: {kargodurumları[kargoindex]}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("****************************************************");
                Console.ResetColor();
                Console.WriteLine("\nYeni Durumu Seçiniz:");
                Console.WriteLine("1. Hazırlanıyor");
                Console.WriteLine("2. Yolda");
                Console.WriteLine("3. Teslim Edildi");
                Console.WriteLine("4. İptal Edildi");
                string değişim = Console.ReadLine()!;
                int günceldegisim;
                if (int.TryParse(değişim, out günceldegisim))
                {
                    if (günceldegisim == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        kargodurumları[kargoindex] = "Hazırlanıyor";
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("İşleminiz Başarıyla Gerçekleştirildi...");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("****************************************\n");
                        Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        return;

                    }
                    else if (günceldegisim == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        kargodurumları[kargoindex] = "Yolda";
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("İşleminiz Başarıyla Gerçekleştirildi...");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("****************************************\n");
                        Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        return;

                    }
                    else if (günceldegisim == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        kargodurumları[kargoindex] = "Teslim Edildi";
                        Console.WriteLine("İşleminiz Başarıyla Gerçekleştirildi...");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("****************************************\n");
                        Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        return;
                    }
                    else if (günceldegisim == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        kargodurumları[kargoindex] = "İptal Edildi";
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("İşleminiz Başarıyla Gerçekleştirildi...");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("****************************************\n");
                        Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(" GEÇERSİZ SEÇİM YAPTINIZ  ");
                        Console.WriteLine("------------------------\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("****************************************\n");
                        Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();
                        return;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("    GEÇERSİZ SEÇENEK     ");
                    Console.WriteLine("------------------------\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("****************************************\n");
                    Console.Write("\n---Devam Etmek İçin Bir Tuşa Basınız---");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                    return;
                }       
            }
            #endregion
        }
        #region Çıkış
        static void Cikis()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string büyük = "Lojistik otomasyon sistemini kullandığınız için teşekkürler.Güle güle!!!".ToUpper();
            string yildiz= "**************************************************************************";
            int genislik = Console.WindowWidth;
            int metinuzunluk = büyük.Length;
            int metinuzunluk2 = yildiz.Length;
            int ort = (genislik - metinuzunluk) / 2;
            int ort2 = (genislik - metinuzunluk2) / 2;
            int imlec = Console.CursorTop;
            Console.SetCursorPosition(ort,imlec);
            
            Console.WriteLine(büyük);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(ort, imlec + 1);
            Console.WriteLine(yildiz);
            Console.ResetColor();
            Environment.Exit(0);
        }
        #endregion
    }
}
