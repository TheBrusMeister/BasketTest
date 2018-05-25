using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    class Product
    {
        private bool isGiftVoucherProduct;
        private string productName;
        private double basePrice;

        public Product(bool isGiftVoucher, string nameOfProduct, double price)
        {
            isGiftVoucherProduct = isGiftVoucher;
            productName = nameOfProduct;
            basePrice = price;
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
            return IsGiftVoucherProduct;
        }

        public void SetIsGiftVoucherProduct1(bool value)
        {
            IsGiftVoucherProduct = value;
        }

    }
}
