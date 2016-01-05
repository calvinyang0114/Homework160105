using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class GetBuyPriceTest
    {
        [TestMethod]
        public void GetBuyPrice_first_episode_one_should_be_100()
        {
            int expected = 100;
            List<ShoppingProduct> shoppingProducts = new List<ShoppingProduct>
            {
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 1, ProductName = "harry potter episode 1"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            int actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_one_and_second_episode_one_should_be_190()
        {
            int expected = 190;
            List<ShoppingProduct> shoppingProducts = new List<ShoppingProduct>
            {
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 1, ProductName = "harry potter episode 1"},
                    Price = 100
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 2, ProductName = "harry potter episode 2"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            int actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_one_and_second_episode_one_and_third_episode_one_should_be_270()
        {
            int expected = 270;
            List<ShoppingProduct> shoppingProducts = new List<ShoppingProduct>
            {
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 1, ProductName = "harry potter episode 1"},
                    Price = 100
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 2, ProductName = "harry potter episode 2"},
                    Price = 100
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 3, ProductName = "harry potter episode 3"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            int actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_one_and_second_episode_one_and_third_episode_one_and_fourth_episode_one_should_be_320()
        {
            int expected = 320;
            List<ShoppingProduct> shoppingProducts = new List<ShoppingProduct>
            {
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 1, ProductName = "harry potter episode 1"},
                    Price = 100
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 2, ProductName = "harry potter episode 2"},
                    Price = 100
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 3, ProductName = "harry potter episode 3"},
                    Price = 100
                },new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 4, ProductName = "harry potter episode 4"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            int actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }
    }
}
