using ShoppingBasket.Entities.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class Product
    {
        public bool isGiftVoucherProduct { get; }
        public string productName { get; }
        public double basePrice { get; }
        public Category productCategory { get; }

        public Product(bool isGiftVoucher, string nameOfProduct, double price, Category category)
        {
            isGiftVoucherProduct = isGiftVoucher;
            productName = nameOfProduct;
            basePrice = price;
            productCategory = category;
        }
    }
}
