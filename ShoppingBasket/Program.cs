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
                new Product(true, "Hat", 10.50m, Category.NONE),
                new Product(true, "Jumper", 54.65m, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> voucher = new List<GiftVoucher>
            {
                new GiftVoucher(5.00m)
            };
            basket.Checkout(voucher);
        }

        static void Basket2()
        {
            Console.WriteLine("Basket 2");
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00m, Category.NONE),
                new Product(true, "Jumper", 26.00m, Category.NONE)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(Category.HEADGEAR, 20, 50);
            basket.Checkout(vouchers , offer);
        }

        static void Basket3()
        {
            Console.WriteLine("Basket 3");
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00m, Category.NONE),
                new Product(true, "Jumper", 26.00m, Category.NONE),
                new Product(true, "Head Light", 3.50m, Category.HEADGEAR)
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(Category.HEADGEAR, 5, 50);
            basket.Checkout(vouchers, offer);
        }

        static void Basket4()
        {
            Console.WriteLine("Basket 4");
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00m, Category.NONE),
                new Product(true, "Jumper", 26.00m, Category.NONE),
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5)
            };
            OfferVoucher offer = new OfferVoucher(5, 50);
            basket.Checkout(vouchers, offer);
        }

        static void Basket5()
        {
            Console.WriteLine("Basket 5");
            List<Product> basketProducts = new List<Product>
            {
                new Product(true, "Hat", 25.00m, Category.NONE),
                new Product(false, "Gift Voucher", 30.00m, Category.NONE),
            };
            Basket basket = new Basket(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>();
            OfferVoucher offer = new OfferVoucher(5, 50);
            basket.Checkout(vouchers, offer);
        }

        static void Main()
        {
            Basket1();
            Basket2();
            Basket3();
            Basket4();
            Basket5();
        }
    }
}
