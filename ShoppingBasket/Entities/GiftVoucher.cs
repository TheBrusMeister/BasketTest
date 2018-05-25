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
            voucherCode = StringHelper.GenerateUniqueStringToLength(3) + "-" + StringHelper.GenerateUniqueStringToLength(3);
            voucherValue = valueOfVoucher;
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
