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
            if (shoppingProducts.Count == 1)
            {
                return shoppingProducts.Sum(s => s.Price);
            }
            if (shoppingProducts.Count == 2)
            {
                return 190;
            }

            if (shoppingProducts.Count == 3)
            {
                return 270;
            }
            if (shoppingProducts.Count == 4)
            {
                return 360;
            }

            return 0;
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
