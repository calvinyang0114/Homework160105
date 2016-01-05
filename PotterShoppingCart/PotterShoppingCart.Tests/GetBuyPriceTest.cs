using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class GetBuyPriceTest
    {
        [TestMethod]
        public void GetBuyPrice_first_episode_1_should_be_100()
        {
            double expected = 100;
            List<ShoppingProduct> shoppingProducts = new List<ShoppingProduct>
            {
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 1, ProductName = "harry potter episode 1"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            double actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_1_and_second_episode_1_should_be_190()
        {
            double expected = 190;
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
            double actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_1_and_second_episode_1_and_third_episode_1_should_be_270()
        {
            double expected = 270;
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
            double actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_1_and_second_episode_1_and_third_episode_1_and_fourth_episode_1_should_be_320()
        {
            double expected = 320;
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
            double actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_1_and_second_episode_1_and_third_episode_1_and_fourth_episode_1_and_fifth_episode_1_should_be_375()
        {
            double expected = 375;
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
                },new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 5, ProductName = "harry potter episode 5"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            double actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_1_and_second_episode_1_and_third_episode_2_should_be_370()
        {
            double expected = 370;

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
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 3, ProductName = "harry potter episode 3"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            double actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBuyPrice_first_episode_1_and_second_episode_2_and_third_episode_2_should_be_460()
        {
            double expected = 460;

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
                    BuyProduct = new Product{Id = 2, ProductName = "harry potter episode 2"},
                    Price = 100
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 3, ProductName = "harry potter episode 3"},
                    Price = 100
                },
                new ShoppingProduct
                {
                    BuyProduct = new Product{Id = 3, ProductName = "harry potter episode 3"},
                    Price = 100
                }
            };


            ShoppingCartManager manager = new ShoppingCartManager();
            double actual = manager.GetBuyPrice(shoppingProducts);

            Assert.AreEqual(expected, actual);
        }
    }
}
