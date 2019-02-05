using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public List<Customer> listOfCustomers;
        public int customerAmount;
        public WeatherConditions weatherConditions;
        public Customer customer;
        public Game game;
        public Day()
        {
            weatherConditions = new WeatherConditions();
            GenerateCustomerAmount(weatherConditions);
        }
        public void RunDay(/*List<Customer> customer*/)
        {
            int listOfCustomersTotal=Convert.ToInt32(listOfCustomers);
            for (int i = 0; i < listOfCustomersTotal; i++)
            {
                //if(game.listOfCustomers.disposition == true)
                {
                    customer.Buy();
                    Console.WriteLine($"You sold {customer.purchase} cups of lemonade for the day.");
                    System.Threading.Thread.Sleep(2000);
                }

            }
        }
        public void DisplayAllOfTodaysCustomers()
        {
            for (int i = 0; i < customerAmount; i++)
            {
                customer = new Customer();
                listOfCustomers.Add(customer);
                Console.WriteLine(listOfCustomers);
            }
        }
        public void GenerateCustomerAmount(WeatherConditions weather)
        {
            if (weather.greatWeather == true)
            {
                customerAmount = 6000;
            }
            if (weather.goodWeather == true)
            {
                customerAmount = 1000;
            }
            if (weather.badWeather == true)
            {
                customerAmount = 300;
            }
            if (weather.terribleWeather == true)
            {
                customerAmount = 100;
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