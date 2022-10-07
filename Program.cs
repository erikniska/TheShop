using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace TheShop;

class Program
{
   
    
    static void Main(string[] strings)
    {
        List<Tshirt> tshirtList = new List<Tshirt>();
        List<Cup> cupList = new List<Cup>();

        while (true)
        {
            Console.WriteLine("Välkommen till TheShop!");
            Console.WriteLine("BESÖKSADRESS FAKTURERINGSADRESS"); //Kom ihåg att ändra
            Console.WriteLine("Var god välj: ");
            Console.WriteLine("Tryck [A] för att - Se vårat utbud på T-shirts!");
            Console.WriteLine("Tryck [B] för att - Se vårat utbud på Muggar!");
            Console.WriteLine("Tryck [C] för att - Se våra mest omtyckta produkter just nu.");
            Console.WriteLine("Tryck [Q] för att - Avsluta programmet.  ");

            ConsoleKeyInfo inputFromUser = Console.ReadKey(true); //Använder ConsoleKeyInfo för att lättare hantera data
            switch (inputFromUser.Key)
            {
                case ConsoleKey.A:
                    {
                        
                        
                        break;
                    }
                case ConsoleKey.B:
                    {
                        break;
                    }
                case ConsoleKey.C:
                    {
                        
                        
    
                        break;
                    }
                case ConsoleKey.Q:
                    {
                        Environment.Exit(0);
                        return;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("!*!*!*!FEL INMATNING!!*!*!*!\nVänligen välj något av alternativen i menyn .\nTryck på valfri knapp för att komma tillbaka till menyn. . .");
                        Console.ReadKey(true);
                        break;
                    }

            }
        }
    }
}
