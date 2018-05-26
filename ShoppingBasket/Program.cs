using ShoppingBasket.Entities;
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
                new Product(true, "Hat", 10.50),
                new Product(true, "Jumper", 54.65)
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
                new Product(true, "Hat", 10.50),
                new Product(true, "Jumper", 54.65)
            };
            basket.SetBasketContents(basketProducts);
            List<GiftVoucher> vouchers = new List<GiftVoucher>
            {
                new GiftVoucher(5.00),
                new GiftVoucher(15.00),
            };
            basket.Checkout(vouchers);
        }

        static void Main()
        {
            Basket1();
            Basket2();
        }
    }
}
