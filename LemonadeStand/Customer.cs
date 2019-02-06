using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        public bool disposition;
        public int purchase;
        private int money;
        public string firstName;
        public string lastName;
        string amount;
        private bool accessibility;
        int temperaturePreference;
        Day day;
        Player player;
        Recipe recipe;
        private List<string> customer;
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
            purchase = 0;
            disposition = true;
            GetTemperaturePreference();
            GetName();
            GetMoneyAmount();
        }
        
        public void GetTemperaturePreference()
        {
            if (MainMenu.RollDie(1, 50) > 1)
            {
                temperaturePreference = (MainMenu.RollDie(40, 60));
            }
            else
            {
             temperaturePreference = (MainMenu.RollDie(0, 100));
            }
            
        }
        public void GetAccessibility(WeatherConditions weather)
        {

            if (temperaturePreference <= weather.temperature)
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
        public void GetDisposition(Player player)
        {
            if (accessibility == true)
            {
                if (money >= player.cupPrice)
                {
                    if (player.cupPrice >= 10.50/*recipe.recipePrice*/)
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
                    if (player.cupPrice < 10.50/*recipe.recipePrice*/)
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
            else
            {
                disposition = false;
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