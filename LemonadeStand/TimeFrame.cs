using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class TimeFrame
    {
        private int amountOfDays;
        private int amountOfWeeks;
        private int amountOfMonths;
        private int amountOfYears;
        public Day day;
        public TimeFrame()
        {
            amountOfDays = 0;
            amountOfWeeks = 0;
            amountOfMonths = 0;
            amountOfYears = 0;
        }
        public void RunTime()
        {

            amountOfDays++;
            if (amountOfDays == 7)
            {
                amountOfWeeks++;
                amountOfDays = 0;
            }
            if (amountOfWeeks == 4)
            {
                amountOfMonths++;
                amountOfWeeks = 0;
            }
            if (amountOfMonths == 12)
            {
                amountOfYears++;
                amountOfMonths = 0;
            if (amountOfYears == 10)
                {
                    Console.WriteLine($"You are really committed to this game! Congratulations on your {amountOfYears} year old lemonade stand business!");
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }
        public int DisplayWeek()
        {
            return amountOfWeeks;
        }
    }
}