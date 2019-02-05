using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        private bool disposition;
        public int purchase;
        private int money;
        string firstName;
        string lastName;
        string amount;
        private bool accessibility;
        int temperaturePreference;
        
        Player player;
        Recipe recipe;
        private List<Customer> customer;
        public List<Customer> listOfCustomers;
        private List<string> firstNames = new List<string>()
        {
            "Billy", "Jose", "Geraldo","Bob", "Frank","Edgar","Molly", "Meredith", "Adam", "Larry", "George", "Sally","Susan","Marquise","Calvin","Mike","Maggie", "Margaret", "Elizabeth","John","Matt"
        };
        private List<string> lastNames = new List<string>()
        {
            "Smith","Sutton","Jones","Warpinski","Stark","Matthews","James","Certon","Yiannopolis","Hering","Varney","Jacobson","Justice","Tolken","Bezier","Messier","King"
        };
        public Customer()
        {
            disposition = true;
            GetTemperaturePreference();
            GetName();
            GetMoneyAmount();
            GetDisposition();
            //listOfCustomers.Add(customer);
            //DisplayCustomer();
        }
        
        public void GetTemperaturePreference()
        {
            if (MainMenu.RollDie(0, 50) > 1)
            {
                temperaturePreference = (MainMenu.RollDie(60, 100));
            }
            else
            {
             temperaturePreference = (MainMenu.RollDie(0, 100));
            }
            
        }
        public void GetAccessibility(WeatherConditions weather)
        {

            if (temperaturePreference >= weather.temperature)
            {
                accessibility = true;
            }
            else
            {
                accessibility = false;
            }
           
        }
        
        public void GetName()
        {
          firstName = (firstNames[MainMenu.RollDie(0, 20)]);
          lastName = (lastNames[MainMenu.RollDie(0, 16)]);
        }
        public void GetMoneyAmount()
        {
            money = MainMenu.RollDie(0, 20) + MainMenu.RollDie(0, 20);
            string textOfMoney = Convert.ToString(money);
            amount = (textOfMoney);
        }
        public void GetDisposition()
        {
            if (accessibility == true)
            {
                if (money >= player.cupPrice)
                {
                    if (player.cupPrice >= recipe.recipePrice)
                    {
                        int chance = MainMenu.RollDie(0, 60);
                        if (chance == 1)
                        {
                            disposition = true;
                        }
                        else
                        {
                            disposition = false;
                        }
                      
                    }
                    if (player.cupPrice < recipe.recipePrice)
                    {
                        int chance = MainMenu.RollDie(0, 1);
                        if (chance == 1)
                        {
                            disposition = true;
                        }
                        else
                        {
                            disposition = false;
                        }
                    }
                }
            }
           //if (amount >= cup price...
        }
        public void DisplayCustomer()
        {
            Console.WriteLine($"{firstName} {lastName} with ${amount}");
        }
        public void Buy()
        {
            purchase++;
        }
    }

    }