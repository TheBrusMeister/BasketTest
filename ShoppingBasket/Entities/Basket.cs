using ShoppingBasket.Entities.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities
{
    public class Basket
    {
        public List<Product> basketContents { get; }
        public decimal basketPrice { get; set; }
        public decimal basketMinusVouchers { get; set; }
        string outcomeText;

        public Basket(List<Product> products)
        {
            basketContents = products;
            basketPrice = CalculateBasketPrice();
        }

        private decimal CalculateBasketPrice()
        {
            decimal calculateBasketPrice = 0;
            basketContents.ForEach((item) => calculateBasketPrice += item.basePrice);

            return calculateBasketPrice;
        }

        public void Checkout(List<GiftVoucher> giftVouchers)
        {
            decimal discountAmount = 0;

            giftVouchers.ForEach((voucher) => discountAmount += voucher.voucherValue);
            basketPrice = basketPrice - discountAmount;
            giftVouchers.ForEach((voucher) =>
            {
                Console.WriteLine("1 x £" + voucher.voucherValue + " Gift Voucher " + voucher.voucherCode + " applied");
            });
            Console.WriteLine("Total: £" + basketPrice);
        }

        public void Checkout(List<GiftVoucher> giftVouchers, OfferVoucher offerVoucher)
        {
            basketPrice = CalculateBasketPrice();
            OfferVoucherCalculation(offerVoucher);
            if (giftVouchers.Count > 0) {
                GiftVoucherCalculation(giftVouchers);
            }
        }

        public void Checkout()
        {
            basketPrice = CalculateBasketPrice();
            Console.WriteLine("Total: £" + basketPrice);
        }

        private void GiftVoucherCalculation(List<GiftVoucher> giftVouchers)
        {
            decimal discountAmount = 0;

            if (giftVouchers.Count == 0)
            {
                
            }
            else
            {
                giftVouchers.ForEach((voucher) => discountAmount += voucher.voucherValue);
                basketPrice = basketPrice - discountAmount;
                giftVouchers.ForEach((voucher) =>
                {
                    Console.WriteLine("1 x £" + voucher.voucherValue+ " Gift Voucher " + voucher.voucherCode + " applied");
                });
                Console.WriteLine("Total: £" + basketPrice);
            }
        }

        private decimal GetDiscountableProductsPrice()
        {
            decimal basketDiscountablePrice = 0;
            basketContents.ForEach(pr =>
            {
                if (pr.isDicountable)
                {
                    basketDiscountablePrice += pr.basePrice;
                }      
            });
            return basketDiscountablePrice;
        }

        private void CalculateSpendToDiscount(decimal discountableTotal, OfferVoucher voucher)
        {
            decimal spendToOfferValid = voucher.offerThreshold - discountableTotal + 0.01m;
            Console.WriteLine("You have not reached the spend threshold for voucher " + voucher.offerCode
                + ". Spend Another £" + spendToOfferValid + " to receive £" + voucher.offerValue + " discount from your basket total.");
            Console.WriteLine("Total: £" + basketPrice);
        }

        private void OfferVoucherCalculation(OfferVoucher offerVoucher)
        {
            decimal discountablePrice = GetDiscountableProductsPrice();

            if (offerVoucher.offerType.Equals(OfferType.Basket))
            {
                if (discountablePrice >= offerVoucher.offerThreshold)
                {
                    basketPrice = basketPrice - offerVoucher.offerValue;
                    outcomeText = "1 x £" + offerVoucher.offerValue + " off baskets over "
                                + "£" + offerVoucher.offerThreshold + " Offer Voucher "
                                + offerVoucher.offerCode + " applied";
                    Console.WriteLine(outcomeText);
                }
                else
                {
                    CalculateSpendToDiscount(discountablePrice, offerVoucher);
                }
            }
            else
            {
                if (basketPrice >= offerVoucher.offerThreshold)
                {
                    decimal discountedPrice = basketPrice;

                    for (int i = 0; i < basketContents.Count; i++)
                    {
                        if (basketContents[i].productCategory.categoryName.Equals(offerVoucher.offerCategory.categoryName))
                        {
                            discountedPrice = basketPrice - basketContents[i].basePrice;
                            outcomeText = "1 x £" + offerVoucher.offerValue + " off baskets over "
                                + "£" + offerVoucher.offerThreshold + " Offer Voucher "
                                + offerVoucher.offerCode + " applied";
                            Console.WriteLine(outcomeText);
                            Console.WriteLine("Total: £" + discountedPrice);
                            break;
                        }
                    }
                    if (discountedPrice.Equals(basketPrice) )
                    {
                        outcomeText = "There are no products in your basket applicable to voucher Voucher " + offerVoucher.offerCode;
                        Console.WriteLine(outcomeText);
                    } else
                    {
                        basketPrice = discountedPrice;
                    }            
                }
            }
        }

    }
}
