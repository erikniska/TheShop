using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheShop
{
    public class Cup : Product
    {
        
        public string Type { get; set; }

        public Cup(int price, string theme, double rating, string type)
        {
            Price = price;
            Theme = theme;
            Rating = rating;
            Type = type;

         
        }
         //Eventuellt onödiga get set

    }
}
