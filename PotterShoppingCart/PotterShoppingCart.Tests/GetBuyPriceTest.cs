﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class GetBuyPriceTest
    {
        [TestMethod]
        public void GetBuyPrice_first_episode_one_book_should_be_100()
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
    }
}
