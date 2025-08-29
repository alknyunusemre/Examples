using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Restaurant_Automation;

namespace Restaurant_Automation
{
    internal class Admin_Panel
    {
        internal  string personnelName="";
        internal  string personnelSurname = "";
        internal  string personnelTitle = "";
        internal  string personnelPassword = "";
        internal static void Menü()
        {
            Console.WriteLine("**** ADMİN PANEL ****\n");
            Console.WriteLine("1. Stok Durumu\n2. Personel Kayıt\n3. Personel Silme\n4. Ürün Ekleme / Silme / Güncelleme \n5. Ciro Bilgisi\n6. Panelden Çık");
            Console.Write("Seçiminizi Yapınız: ");
            string select = Console.ReadLine()!;
            int selected;
            if (int.TryParse(select, out selected))
            {
                switch (selected)
                {
                    case 1:

                        break;
                    case 2:
                        personelAdd();
                        break;
                    case 3:

                        break;
                    case 4:
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        Console.Clear();
                        Login_Panel.Login();
                        break;
                }
            }
        }
        internal static Admin_Panel Stock() 
        {
            Admin_Panel Amount = new Admin_Panel();
            return Amount;
        }
        internal static List<Admin_Panel> personelListesi = new List<Admin_Panel>();
        internal static Admin_Panel personns = new Admin_Panel();
        internal static Admin_Panel personelAdd() 
        {                 
            Console.WriteLine("--- PERSONEL EKLEME PANELİ ---\n");
            Console.WriteLine("Yeni Personel İsmi: ");
            personns.personnelName = Console.ReadLine()!;
            Console.WriteLine("Yeni Personel Soyisim: ");
            personns.personnelSurname = Console.ReadLine()!;
            Console.WriteLine("Yeni Personel Şifre:");
            personns.personnelPassword = Console.ReadLine()!;
            Console.WriteLine("Yeni Personel Ünvanı:\n1. Barista\n2. Garson\n3. Mutfak Personeli\n4. Kasiyer\nSeçiminizi Yapınız(1/2/3):");
            string select = Console.ReadLine()!;
            int selected;
            if (int.TryParse(select, out selected )) 
            {
                switch (select)
                {
                    case "1":
                        personns.personnelTitle = "BARİSTA";                       
                        break;
                    case "2":
                        personns.personnelTitle = "GARSON";
                        break;
                    case "3":
                        personns.personnelTitle = "ŞEF";
                        break;
                    case "4":
                        personns.personnelTitle = "KASİYER";
                        break;
                }                           
                personelListesi.Add(personns);
                Console.WriteLine($"\n'{personns.personnelName} {personns.personnelSurname}' isimli personel '{personns.personnelTitle}' olarak başarıyla eklendi.");
                Console.WriteLine("ADMİN MENÜSÜNE AKTARILIYORSUNUZ...");
                Thread.Sleep(2000);
                Console.Clear();
                Menü();
            }
            else 
            {
                Console.WriteLine("Lütfen Girdiğiniz Karakteri Kontrol Edip Tekrar Deneyiniz");
                Thread.Sleep(1500);
                Console.Clear();
                personelAdd();
            }
            
            return personns;
        }

      
    }
}
