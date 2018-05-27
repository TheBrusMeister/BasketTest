using ShoppingBasket.Entities.enums;
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
        string outcomeText;

        public double GetBasketMinusVouchers()
        {
            return basketMinusVouchers;
        }

        public void SetBasketMinusVouchers(double value)
        {
            basketMinusVouchers = value;
        }

        private double CalculateBasketPrice()
        {
            double calculateBasketPrice = 0;
            basketContents.ForEach((item) => calculateBasketPrice += item.GetBasePrice());

            return calculateBasketPrice;
        }

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

        public void SetBasketContents(List<Product> value)
        {
            basketContents = value;
        }

        public void Checkout(List<GiftVoucher> giftVouchers)
        {
            double discountAmount = 0;

            basketPrice = CalculateBasketPrice();
            giftVouchers.ForEach((voucher) => discountAmount += voucher.GetVoucherValue());
            basketMinusVouchers = GetBasketPrice() - discountAmount;
            giftVouchers.ForEach((voucher) =>
            {
                Console.WriteLine("1 x £" + voucher.GetVoucherValue() + " Gift Voucher " + voucher.GetVoucherCode() + " applied");
            });
            Console.WriteLine("Total: £" + basketMinusVouchers);
        }

        public void Checkout(List<GiftVoucher> giftVouchers, OfferVoucher offerVoucher)
        {
            basketPrice = CalculateBasketPrice();
            OfferVoucherCalculation(offerVoucher);
            GiftVoucherCalculation(giftVouchers);
        }

        public void Checkout()
        {
            basketPrice = CalculateBasketPrice();
            Console.WriteLine("Total: £" + GetBasketPrice());
        }

        private void GiftVoucherCalculation(List<GiftVoucher> giftVouchers)
        {
            double discountAmount = 0;

            if (giftVouchers.Count == 0)
            {
                
            }
            else
            {
                giftVouchers.ForEach((voucher) => discountAmount += voucher.GetVoucherValue());
                basketPrice = basketPrice - discountAmount;
                giftVouchers.ForEach((voucher) =>
                {
                    Console.WriteLine("1 x £" + voucher.GetVoucherValue() + " Gift Voucher " + voucher.GetVoucherCode() + " applied");
                });
            }
        }

        private void OfferVoucherCalculation(OfferVoucher offerVoucher)
        {
            if (offerVoucher.GetOfferType().Equals(OfferType.Basket))
            {
                if (basketPrice >= offerVoucher.GetOfferValue())
                {
                    basketPrice = basketPrice - offerVoucher.GetOfferValue();
                }
            }
            else
            {
                if (basketPrice >= offerVoucher.GetOfferThreshold())
                {
                    for (int i = 0; i <= basketContents.Count; i++)
                    {
                        
                        if (basketContents[i].GetCategory().GetCategoryName().Equals(offerVoucher.GetOfferCategory().GetCategoryName()))
                        {
                            basketPrice = basketPrice - offerVoucher.GetOfferValue();
                            outcomeText = "1 x £" + offerVoucher.GetOfferValue() + " off baskets over "
                                + "£" + offerVoucher.GetOfferThreshold() + " Offer Voucher "
                                + offerVoucher.GetOfferCode() + " applied";
                            Console.WriteLine(outcomeText);
                            break;
                        }else
                        {
                            outcomeText = "There are no products in your basket applicable to voucher Voucher " + offerVoucher.GetOfferCode();
                            Console.WriteLine(outcomeText);
                            break;
                        }
                    }
                } else
                {
                    outcomeText = "Calculate spend up to threshold here";
                    Console.WriteLine(outcomeText);
                }
            }
        }

    }
}
