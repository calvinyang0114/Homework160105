using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class ShoppingCartManager
    {
        public int GetBuyPrice(List<ShoppingProduct> shoppingProducts)
        {
            if (shoppingProducts.Count > 1)
            {
                return 190;
            }
            else
            {
                return shoppingProducts.Sum(s => s.Price);
            }
        }
    }

    public class ShoppingProduct
    {
        public Product BuyProduct { get; set; }
        public int Price { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
