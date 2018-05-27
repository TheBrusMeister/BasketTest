using ShoppingBasket.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShoppingBasket.Entities
{
    public class GiftVoucher
    {
        private double voucherValue;
        private string voucherCode;

        public GiftVoucher(double valueOfVoucher)
        {
            voucherCode = StringHelper.GenerateVoucherCode();
            voucherValue = valueOfVoucher;
        }

        public string GetVoucherCode()
        {
            return voucherCode;
        }

        public void SetVoucherCode(string value)
        {
            voucherCode = value;
        }

        public double GetVoucherValue()
        {
            return voucherValue;
        }

        public void SetVoucherValue(double value)
        {
            voucherValue = value;
        }
    }
}
