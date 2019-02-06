using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Wallet
    {
        public double money;
        private double beginningBalance = 0;
        private double weeklyBalance;
        public Wallet()
        {
            money = 10;
        }
        public double DisplayMoney()
        {
            return money;
        }
        public double GetWeeklyBalance()
        {
          weeklyBalance = money - beginningBalance;
            return weeklyBalance;
        }
        public void CalculateBeginningBalance()
        {
            beginningBalance = money - weeklyBalance;
        }
    }
}