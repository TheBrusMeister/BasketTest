using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingBasket.Entities;
using ShoppingBasket.Entities.enums;
using System.Collections.Generic;

namespace BasketTests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void CustomerCanPurchaseWithoutVoucher()
        {
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.00m, Category.NONE),
                new Product(true, "Jumper", 20.00m, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            basket.Checkout();
            Assert.AreEqual(30.00m, basket.basketPrice);
        }

        [TestMethod]
        public void CustomerCanPurchaseWithOneGiftVoucher()
        {
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50m, Category.NONE),
                new Product(true, "Jumper", 54.65m, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5.00m)
            };
            basket.Checkout(vouchers);
            Assert.AreEqual(60.15m, basket.basketPrice);
        }

        [TestMethod]
        public void CustomerCanPurchaseWithMultipleGiftVouchers()
        {
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50m, Category.NONE),
                new Product(true, "Jumper", 54.65m, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5.00m),
                new GiftVoucher(5.00m)
            };
            basket.Checkout(vouchers);
            Assert.AreEqual(55.15m, basket.basketPrice);
        }

        [TestMethod]
        public void PurchaseWithAThresholdVoucherAndBasketNotApplicable()
        {
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00m, Category.NONE),
                new Product(true, "Jumper", 26.00m, Category.NONE),
                new Product(true, "Head Light", 3.50m, Category.HEADGEAR)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(Category.HEADGEAR, 20, 50);
            basket.Checkout(vouchers, offer);
            Assert.AreEqual(51.00m, basket.basketPrice);
        }
    }
}
