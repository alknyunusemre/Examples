
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Automation
{
    internal class Login_Panel
    {
        internal  string adminName = "admin";
        internal  string adminSurname = "";
        internal  string adminPassword = "admin123";
        internal string adminTitle = "ADMİN";
        internal static void Login()
        {
            
            Login_Panel admin = new Login_Panel();
            Console.WriteLine("--- GİRİŞ PANELİ ---");
            Console.WriteLine("İsim: ");
            string isim = Console.ReadLine()!;
            Console.WriteLine("Şifre: ");
            string password = Console.ReadLine()!;
            if (isim == admin.adminName && password == admin.adminPassword) 
            {
                Admin_Panel.Menü();
            }
            else if (isim == Admin_Panel.personns.personnelName && password == Admin_Panel.personns.personnelPassword) 
            {
                if (Admin_Panel.personns.personnelTitle =="GARSON") 
                {
                    Waiter_Panel.Menü();
                }
                if (Admin_Panel.personns.personnelTitle == "BARİSTA")
                {
                    Barista_Panel.Menü();
                }
                if (Admin_Panel.personns.personnelTitle == "ŞEF")
                {
                    Kitchen_Panel.Menü();
                }
                if (Admin_Panel.personns.personnelTitle == "KASİYER")
                {
                    Cashier_Panel.Menü();
                }
            }
        }
    }
   
}
