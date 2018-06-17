using ShoppingBasket.Entities.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class Product
    {
        public bool isDicountable { get; }
        public string productName { get; }
        public decimal basePrice { get; }
        public Category productCategory { get; }

        public Product(bool canDiscount, string nameOfProduct, decimal price, Category category)
        {
            isDicountable = canDiscount;
            productName = nameOfProduct;
            basePrice = price;
            productCategory = category;
        }
    }
}
