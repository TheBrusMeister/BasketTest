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
                new Product(true, "Hat", 10.00, Category.NONE),
                new Product(true, "Jumper", 20.00, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            basket.Checkout();
            Assert.AreEqual(30.00, basket.basketPrice, 00.1);
        }

        [TestMethod]
        public void CustomerCanPurchaseWithOneGiftVoucher()
        {
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50, Category.NONE),
                new Product(true, "Jumper", 54.65, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5.00)
            };
            basket.Checkout(vouchers);
            Assert.AreEqual(60.15, basket.basketPrice, 00.1);
        }

        [TestMethod]
        public void CustomerCanPurchaseWithMultipleGiftVouchers()
        {
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50, Category.NONE),
                new Product(true, "Jumper", 54.65, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5.00),
                new GiftVoucher(5.00)
            };
            basket.Checkout(vouchers);
            Assert.AreEqual(55.15, basket.basketPrice, 00.1);
        }

        [TestMethod]
        public void PurchaseWithAThresholdVoucherAndBasketNotApplicable()
        {
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00, Category.NONE),
                new Product(true, "Jumper", 26.00, Category.NONE),
                new Product(true, "Head Light", 3.50, Category.HEADGEAR)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(Category.HEADGEAR, 20, 50);
            basket.Checkout(vouchers, offer);
            Assert.AreEqual(51.0, basket.basketPrice, 00.1);
        }
    }
}
