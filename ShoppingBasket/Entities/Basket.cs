using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class Basket
    {
        internal List<Product> basketContents;
        private double basketPrice;
        double basketMinusVouchers;

        public double GetBasketMinusVouchers()
        {
            return basketMinusVouchers;
        }

        public void SetBasketMinusVouchers(double value)
        {
            basketMinusVouchers = value;
        }

        public double GetBasketPrice()
        {
            basketPrice = 0;
            basketContents.ForEach((item) => basketPrice += item.GetBasePrice());
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

        public void SetBasketContents(List<Product> value)
        {
            basketContents = value;
        }

        public void Checkout(GiftVoucher giftVoucher)
        {
            basketMinusVouchers = GetBasketPrice() - giftVoucher.GetVoucherValue();
            Console.WriteLine("1 x £" + giftVoucher.GetVoucherValue() + " Gift Voucher " + giftVoucher.GetVoucherCode() + " applied");
            Console.WriteLine("Total: £" + basketMinusVouchers);
        }

        public void Checkout()
        {
            Console.WriteLine("Total: £" + GetBasketPrice());
        }
    }
}
