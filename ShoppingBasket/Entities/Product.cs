using ShoppingBasket.Entities.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class Product
    {
        private bool isGiftVoucherProduct;
        private string productName;
        private double basePrice;
        private Category productCategory;

        public Product(bool isGiftVoucher, string nameOfProduct, double price, Category category)
        {
            isGiftVoucherProduct = isGiftVoucher;
            productName = nameOfProduct;
            basePrice = price;
            productCategory = category;
        }

        public double GetBasePrice()
        {
            return basePrice;
        }

        public void SetBasePrice(double value)
        {
            basePrice = value;
        }

        public string GetProductName()
        {
            return productName;
        }

        public void SetProductName(string value)
        {
            productName = value;
        }

        public bool GetIsGiftVoucherProduct1()
        {
            return isGiftVoucherProduct;
        }

        public void SetIsGiftVoucherProduct1(bool value)
        {
            isGiftVoucherProduct = value;
        }

        public Category GetCategory()
        {
            return productCategory;
        }

        public void SetCategory(Category value)
        {
            productCategory = value;
        }
    }
}
