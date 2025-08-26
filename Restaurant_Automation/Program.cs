using Restaurant_Automation;

namespace _Restaurant_Automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedd;
            Console.WriteLine("1. Yönetici\n2. Garson");
            string select = Console.ReadLine()!;
            
            InputInt(select, selectedd);
        }
        static void InputInt(string select, int selected) 
        {
            if (int.TryParse(select, out selected)) 
            {
                
            }
            else 
            {
                Console.WriteLine("HATALI GİRİŞ YATPINIZ!!");
            }

        }

    }
}