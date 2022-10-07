using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace TheShop
{
    public class Tshirt : Product
    {
        
        public string Material { get;  set;  } //Eventuellt onödiga get set
        public string Size { get; set; }
        public Tshirt(int price, string theme, double rating, string type, string material, string size )
        {
            
            Price = price;
            Theme = theme;
            Rating = rating;
            Material = material;
            Size = size;
            
        }

       
    }
}
