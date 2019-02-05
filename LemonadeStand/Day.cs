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
        public Game game;
        public Day()
        {
            weatherConditions = new WeatherConditions();
            GenerateCustomerAmount(weatherConditions);
        }
        public void GetCustomers()
        {
            
            for (int i = 0; i < customerAmount; i++)
            {
                //if(game.listOfCustomers.disposition == true)
                {
                   Customer customer = new Customer();
                   if(customer.disposition == true)
                    {
                        customer.Buy();
                    }
                    listOfCustomers.Add(customer);
                }
                Console.WriteLine($"You sold {listOfCustomers.Count} cups of lemonade for the day.");
                System.Threading.Thread.Sleep(2000);

            }
        }
        public void RunDay()
        {
            //DisplayWeather();
            //GoToMarketPlace();
            //MakeLemonade();
            GetCustomers();
            //GetIncome();
        }
        public void DisplayAllOfTodaysCustomers()
        {
            //foreach (Customer customer in listOfCustomers)
            //{
            //    Console.WriteLine(customer.firstName +...);
            //}
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