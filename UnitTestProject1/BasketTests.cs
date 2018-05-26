using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingBasket.Entities;
using System.Collections.Generic;

namespace BasketTests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void CustomerCanPurchaseWithoutVoucher()
        {
            Basket basket = new Basket();
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.00),
                new Product(true, "Jumper", 20.00)
            };
            basket.SetBasketContents(basketProducts);
            basket.Checkout();
            Assert.AreEqual(30.00, basket.GetBasketPrice() , 00.1 );
        }

        [TestMethod]
        public void CustomerCanPurchaseWithOneGiftVoucher()
        {
            Basket basket = new Basket();
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50),
                new Product(true, "Jumper", 54.65)
            };
            basket.SetBasketContents(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5.00)
            };
            basket.Checkout(vouchers);
            Assert.AreEqual(60.15, basket.GetBasketMinusVouchers() , 00.1 );
        }

        [TestMethod]
        public void CustomerCanPurchaseWithMultipleGiftVouchers()
        {
            Basket basket = new Basket();
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50),
                new Product(true, "Jumper", 54.65)
            };
            basket.SetBasketContents(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5.00),
                new GiftVoucher(5.00)
            };
            basket.Checkout(vouchers);
            Assert.AreEqual(55.15, basket.GetBasketMinusVouchers(), 00.1);
        }

        [TestMethod]
        public void CustomerCanPurchaseWithAThresholdVoucher()
        {
            Assert.Fail();
        }
    }
}
