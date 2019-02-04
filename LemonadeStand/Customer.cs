﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        private bool disposition;
        private int money;
        string firstName;
        string lastName;
        string amount;
        private bool accessibility;
        int temperaturePreference;
        private List<string> customer;
        private List<Customer> listOfCustomers;
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
            GetTemperaturePreference();
            GetName();
            GetMoneyAmount();
            GetDisposition();
            DisplayCustomer();
        }
        
        public void GetTemperaturePreference()
        {
            if (MainMenu.RollDie(0, 50) > 1)
            {
             temperaturePreference = (MainMenu.RollDie(60,100))
            }
            else
            {
             temperaturePreference = (MainMenu.RollDie(0, 100));
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
           //if (amount >= cup price...
        }
        public void DisplayCustomer()
        {
            Console.WriteLine($"{firstName} {lastName} {amount}");
        }
    }

    }