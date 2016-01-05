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
            if (null == shoppingProducts || false == shoppingProducts.Any())
                return 0;

            CalculateDiscount calculateDiscount = GroupDiscountSeries(shoppingProducts);
            return calculateDiscount.GetPrice();
        }


        private CalculateDiscount GroupDiscountSeries(List<ShoppingProduct> shoppingProducts)
        {
            CalculateDiscount collection = new CalculateDiscount();

            foreach (var shoppingProduct in shoppingProducts)
            {
                collection.TryAdd(shoppingProduct);
            }

            return collection;
        }
    }

    public class ShoppingProduct
    {
        public Product BuyProduct { get; set; }
        public int Price { get; set; }
    }

    public class CalculateDiscount
    {
        private List<DiscountProduct> _groupDiscounts;

        public void TryAdd(ShoppingProduct product)
        {
            if(null == _groupDiscounts)
                _groupDiscounts = new List<DiscountProduct>();

            if(false == _groupDiscounts.Any(s => s.TryAdd(product.BuyProduct.Id)))
            {
                _groupDiscounts.Add(new DiscountProduct());
                TryAdd(product);
            }
        }

        public double GetPrice()
        {
            double sum = 0;

            foreach (var discount in _groupDiscounts)
            {
                switch (discount.Ids.Count)
                {
                    case 1:
                        sum += discount.Ids.Count * 100;
                        break;
                    case 2:
                        sum += discount.Ids.Count * 100 * 0.95;
                        break;
                    case 3:
                        sum += discount.Ids.Count * 100 * 0.9;
                        break;
                    case 4:
                        sum += discount.Ids.Count * 100 * 0.8;
                        break;
                    default:
                        sum += discount.Ids.Count * 100 * 0.75;
                        break;
                }
            }

            return sum;
        }
    }

    public class DiscountProduct
    {
        public List<int> Ids { get; set; }

        public bool TryAdd(int id)
        {
            if(Ids == null)
                Ids = new List<int>();

            if (false == Ids.Contains(id))
            {
                Ids.Add(id);
                return true;
            }

            return false;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
