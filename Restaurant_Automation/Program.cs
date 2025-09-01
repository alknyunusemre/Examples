using Restaurant_Automation;

namespace _Restaurant_Automation
{
    internal class Program
    {
        internal static void ErrorMainMenuTransfer(string message)
        {
            Console.WriteLine("HATALI DEĞER GİRİLDİ");
            Console.WriteLine(message+"'ne Aktarılıyorsunuz...");
            Thread.Sleep(1500);
        }
        
        static void Main(string[] args)
        {
            //Table_Panel.Table();
            //Login_Panel.Login();
            Menü.Menu();
        }       

    }
}