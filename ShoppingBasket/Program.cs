using ShoppingBasket.Entities;
using System;
using System.Collections.Generic;

namespace ShoppingBasket
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Basket 1");
            Basket basket = new Basket();
            List<Product> basket1Products = new List<Product>();
            basket1Products.Add(new Product(true, "Hat", 10.50));
            basket1Products.Add(new Product(true, "Jumper", 54.65));
            basket.SetBasketContents(basket1Products);
            GiftVoucher voucher1 = new GiftVoucher(5.00);
            basket.Checkout(voucher1);
        }
    }
}
