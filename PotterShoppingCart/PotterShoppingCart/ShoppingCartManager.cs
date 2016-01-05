using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class ShoppingCartManager
    {
        public double GetBuyPrice(List<ShoppingProduct> shoppingProducts)
        {
            int distinct = shoppingProducts.Select(s => s.BuyProduct.Id).Distinct().Count();

            int discountCount = 0;
            
            if (distinct < 2)
            {
                discountCount = 0;
            }
            else if (distinct > 5)
            {
                discountCount = 5;
            }
            else
            {
                discountCount = distinct;
            }

            double discountPrice = 0;

            if (discountCount == 2)
            {
                discountPrice = discountCount * 100 * 0.95;                
            }
            else if (discountCount == 3)
            {
                discountPrice = discountCount * 100 * 0.9;
            }
            else if (discountCount == 4)
            {
                discountPrice = discountCount * 100 * 0.8;
            }
            else if (discountCount == 5)
            {
                discountPrice = discountCount * 100 * 0.75;
            }

            int originalCount = shoppingProducts.Count - discountCount;

            return (originalCount * 100) + (discountPrice);
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
