using ShoppingBasket.Entities;
using ShoppingBasket.Entities.enums;
using System;
using System.Collections.Generic;

namespace ShoppingBasket
{
    class Program
    {
        static void Basket1()
        {
            Console.WriteLine("Basket 1");
            Basket basket = new Basket();
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50, Category.NONE),
                new Product(true, "Jumper", 54.65, Category.NONE)
            };
            basket.SetBasketContents(basketProducts);
            List<GiftVoucher> voucher = new List<GiftVoucher>
            {
                new GiftVoucher(5.00)
            };
            basket.Checkout(voucher);
        }

        static void Basket2()
        {
            Console.WriteLine("Basket 2");
            Basket basket = new Basket();
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50, Category.NONE),
                new Product(true, "Jumper", 54.65, Category.NONE)
            };
            basket.SetBasketContents(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(Category.HEADGEAR,20, 50);
            basket.Checkout(vouchers , offer);
        }

        static void Main()
        {
            Basket1();
            Basket2();
        }
    }
}
