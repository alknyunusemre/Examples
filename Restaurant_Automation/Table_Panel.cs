using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Automation
{
    internal class Table_Panel
    {
        internal static List<string> tableStatus = new List<string>() { "BOŞ", "DOLU", "REZERVE", "KALKMAK ÜZERE" };
        internal static void Table()
        {
            int tableQuantity = 10;
            for (int i = 1; i <= tableQuantity; i++)
            {
                Console.WriteLine("MASA " + i);
            }
            Console.WriteLine("İŞLEM YAPMAK İSTEDİĞİNİZ MASA NUMARASINIZ SEÇİNİZ: ");
            string select = Console.ReadLine()!;
            int selected;
            if (int.TryParse(select, out selected))
            {
                for (int i = 1; i <= selected; i++)
                {
                    if (i == selected) 
                    {
                        Console.WriteLine("MASA "+i);
                        Console.WriteLine("1. MENÜ\n2. ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Karakter Biçimi");
            }

        }
    }
}
