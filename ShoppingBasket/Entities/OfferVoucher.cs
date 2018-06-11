using ShoppingBasket.Entities.enums;
using ShoppingBasket.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class OfferVoucher
    {
 
        public Category offerCategory { get;}
        public string offerCode { get; }
        public OfferType offerType { get; }
        public int offerThreshold { get; }
        public int offerValue { get; }
       
        public OfferVoucher(int valueOfOffer, int threshold)
        {
            offerType = OfferType.Basket;
            offerThreshold = threshold;
            offerValue = valueOfOffer;
            offerCode = StringHelper.GenerateVoucherCode();
        }

        public OfferVoucher(Category offerCat, int valueOfOffer, int threshold) : this(valueOfOffer, threshold)
        {
            offerType = OfferType.Category;
            offerCategory = offerCat;           
        }
    }
}
