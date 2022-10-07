using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TheShop
{
    public class Generator
    {
        
        private static string[] Theme = new string[]
        {
            "Katter", "Hundar", "Fåglar", "Hästar", "Vargar", "Björnar",
            "Älgar", "Ugglor", "Träd", "Blommor", "Solnedgång", "Räv","Berg",
            "Snöfall","Skyskrapa","Fiskar","Vägskylt", "Varningstriangel", "Grävmaskin",
            "Lastbil", "Sportbil", "Brandbil","Polisbil", "Ambulans","TV-spel",
            "Äpplen", "Bananer", "Ananas", "Jordgubbe",
        };
        private static string[] Size = new string[]
        {
            "XS","S","M","L","XL"
        };
        private static string[] Material = new string[]
        {
            "Bommull", "Ylle","Teddy","Linne","Rent guld"
        };
        private static string[] Type = new string[]
        {
            "Kaffekopp","Tekopp","Vattenflaska","XL-mugg","Espressokopp"
        };
        public static double Rating()
        {
            Random random = new Random(); //Skall skapa ett betyg mellan 1-10 och skicka tillbaka
            int rating = random.Next(1, 10);
            return rating;

        }
        public static int Price()
        {
            Random random = new Random(); //Skall sätta pris från förbestämd lista
            int price = random.Next(1, 10);
            int[] prislista = new int[] { 1, 2, 3, 4, 5, 6, };
            return price;

        }
        public static string Motiv()
        {
            Random random = new Random();
            string tShirt = "";
            tShirt = (Theme[Theme.Length - 1].ToString() + tShirt);
            return tShirt;
        }
        public static string material()
        {
            Random random = new Random();
            string material = "";
            material = (Material[random.Next(0, (Material.Length - 1))].ToString() + material);
            return material;
        }
        public static string Cup()
        {
            Random random = new Random();
            string cup = "";
            cup = (Type[Type.Length - 1].ToString() + cup);
            return cup;
        }

        
         
           

        }
        
        
        
        
      
    }   
