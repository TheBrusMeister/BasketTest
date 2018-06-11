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
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 10.50, Category.NONE),
                new Product(true, "Jumper", 54.65, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> voucher = new List<GiftVoucher>
            {
                new GiftVoucher(5.00)
            };
            basket.Checkout(voucher);
        }

        static void Basket2()
        {
            Console.WriteLine("Basket 2");
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00, Category.NONE),
                new Product(true, "Jumper", 26.00, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(Category.HEADGEAR,20, 50);
            basket.Checkout(vouchers , offer);
        }

        static void Basket3()
        {
            Console.WriteLine("Basket 3");
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00, Category.NONE),
                new Product(true, "Jumper", 26.00, Category.NONE),
                new Product(true, "Head Light", 3.50, Category.HEADGEAR)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(Category.HEADGEAR, 5, 50);
            basket.Checkout(vouchers, offer);
        }

        static void Main()
        {
            Basket1();
            Basket2();
            Basket3();
        }
    }
}
