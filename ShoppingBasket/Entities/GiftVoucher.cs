using ShoppingBasket.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShoppingBasket.Entities
{
    public class GiftVoucher
    {
        public decimal voucherValue { get; }
        public string voucherCode { get; }

        public GiftVoucher(decimal valueOfVoucher)
        {
            voucherCode = StringHelper.GenerateVoucherCode();
            voucherValue = valueOfVoucher;
        }
    }
}
