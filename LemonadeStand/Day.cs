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
        int lemonadeSales;
        
        public Day()
        {
            weatherConditions = new WeatherConditions();
            GenerateCustomerAmount(weatherConditions);
            listOfCustomers = new List<Customer>();
        }
        public void GetCustomers(Player player)
        {
            
            for (int i = 0; i < customerAmount; i++)
            {
                //if(game.listOfCustomers.disposition == true)
                {
                   Customer customer = new Customer();
                    customer.GetAccessibility(weatherConditions);
                    customer.GetDisposition(player);
                   if(customer.disposition == true)
                    {
                        customer.Buy();
                        listOfCustomers.Add(customer);
                        if (listOfCustomers.Count == player.inventory.pitcher) //cup
                        {
                            for (int index = 0; index < listOfCustomers.Count; index++)
                            {
                              lemonadeSales = player.inventory.pitcher -= listOfCustomers[index].purchase; 
                            }
                            break;
                        }
                        if (listOfCustomers.Count < player.inventory.pitcher) //cup
                        {
                            lemonadeSales = listOfCustomers.Count;
                            player.inventory.pitcher -= listOfCustomers.Count;
                        }
                        else
                        {

                        }
                    }
                    
                }

            }
            Console.WriteLine($"You sold {lemonadeSales} cups of lemonade for the day.");
            player.wallet.money += (lemonadeSales * player.cupPrice);

            DisplayAllOfTodaysCustomers();
            System.Threading.Thread.Sleep(2000);
        }
       
        public void RunDay(MarketPlace marketPlace, Player player)
        {
            DisplayDayWeather();
            marketPlace.DecideToShop(player);
            player.Recipe.SetRecipePrice(player);
            //MakePitcher();
            player.AskForCupPrice();
            GetCustomers(player);
            player.CheckWallet();
        }
        public void DisplayDayWeather()
        {
            Console.WriteLine($"The actual weather is {weatherConditions.condition}, it is {weatherConditions.actualWeather}°F, with {weatherConditions.precipitationAmount} {weatherConditions.precipitation}.");
            System.Threading.Thread.Sleep(2000);
        }
        public void DisplayAllOfTodaysCustomers()
        {
            foreach (Customer customer in listOfCustomers)
            {
                Console.WriteLine($"{customer.firstName} {customer.lastName}");
            }
        }
        public void GenerateCustomerAmount(WeatherConditions weather)
        {
            if (weather.greatWeather == true)
            {
                customerAmount = 25;
            }
            if (weather.goodWeather == true)
            {
                customerAmount = 15;
            }
            if (weather.badWeather == true)
            {
                customerAmount = 5;
            }
            if (weather.terribleWeather == true)
            {
                customerAmount = 2;
            }
            else
            {
                customerAmount = 15;
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