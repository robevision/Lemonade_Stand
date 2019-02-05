using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
    
        public WeatherConditions weatherConditions;
        public Customer customer;
        public Game game;
        public Day()
        {
            weatherConditions = new WeatherConditions();
        }
        public void RunDay(/*List<Customer> customer*/)
        {
            int listOfCustomersTotal=Convert.ToInt32(game.listOfCustomers);
            for (int i = 0; i < listOfCustomersTotal; i++)
            {
                //if(game.listOfCustomers.disposition == true)
                {
                    customer.Buy();
                }

            }
        }

        public Customer Customer
        {
            get => default(LemonadeStand.Customer);
            set
            {
            }
        }

        public WeatherConditions WeatherConditions
        {
            get => default(WeatherConditions);
            set
            {
            }
        }


    }
}