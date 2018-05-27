using ShoppingBasket.Entities.enums;
using ShoppingBasket.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class OfferVoucher
    {
        private OfferType offerType;
        private Category offerCategory;
        private string offerCode;
        private int offerThreshold;
        int offerValue;
       
        public OfferVoucher(int valueOfOffer, int threshold)
        {
            offerType = OfferType.Basket;
            offerThreshold = threshold;
            offerValue = valueOfOffer;
            offerCode = StringHelper.GenerateVoucherCode();
        }

        public OfferVoucher(Category offerCat, int valueOfOffer, int threshold)
        {
            offerType = OfferType.Category;
            offerCategory = offerCat;
            offerValue = valueOfOffer;
            offerThreshold = threshold;
            offerCode = StringHelper.GenerateVoucherCode();
        }

        public Category GetOfferCategory()
        {
            return offerCategory;
        }

        public void SetOfferCategory(Category value)
        {
            offerCategory = value;
        }

        public string GetOfferCode()
        {
            return offerCode;
        }

        public void SetOfferCode(string value)
        {
            offerCode = value;
        }

        public int GetOfferThreshold()
        {
            return offerThreshold;
        }

        public void SetOfferThreshold(int value)
        {
            offerThreshold = value;
        }

        public int GetOfferValue()
        {
            return offerValue;
        }

        public void SetOfferValue(int value)
        {
            offerValue = value;
        }

        public OfferType GetOfferType()
        {
            return offerType;
        }

        public void SetOfferType(OfferType value)
        {
            offerType = value;
        }
    }
}
