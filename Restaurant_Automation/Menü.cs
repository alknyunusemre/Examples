using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Automation
{
    internal class Menü
    {

        internal static List<string> foods = new List<string>() { "Hamburger", "Pizza", "Döner" };

        internal static List<string> drinks = new List<string>() { "Kola", "Soda", "Ayran" };

        internal static List<string> sweets = new List<string>() { "Waffle", "Cheesecake", "Çikolatalı Pasta" };

        internal static List<int> foodsPrice = new List<int>(300 + 250 + 150);

        internal static List<int> drinksPrice = new List<int>() { 70 + 30 + 30 };

        internal static List<int> sweetsPrice = new List<int>() { 300 + 150 + 150 };        
    
        
        internal static List<int> tableNumbers = new List<int>();
        internal static int masaSayisi = 20;            
       
    }

}
