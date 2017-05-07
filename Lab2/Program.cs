using CreditLibrary;
﻿using BusinessCard;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Money.Money money = new Money.Money();
            money.GetMoney();
            CreditCard creditCard = new CreditCard();
            creditCard.getCredit();
            BusinessCardMain businessCard = new BusinessCardMain();
            businessCard.UseBusinessCard();
        }
    }
}
