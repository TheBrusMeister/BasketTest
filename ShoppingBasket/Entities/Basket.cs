using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class Basket
    {
        internal List<Product> basketContents;
        private double basketPrice;

        public double GetBasketPrice()
        {
            return basketPrice;
        }

        public void SetBasketPrice(double value)
        {
            basketPrice = value;
        }

        internal List<Product> GetBasketContents()
        {
            return basketContents;
        }

        internal void SetBasketContents(List<Product> value)
        {
            basketContents = value;
        }

        public void Checkout(GiftVoucher giftVoucher)
        {

        }
    }
}
