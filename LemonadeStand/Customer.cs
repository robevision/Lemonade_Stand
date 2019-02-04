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
        private int accessibility;
        public List<string> customer;
        public List<Customer> listOfCustomers;
        public List<string> firstNames = new List<string>()
        {
            "Billy", "Jose", "Geraldo","Bob", "Frank","Edgar","Molly", "Meredith", "Adam", "Larry", "George", "Sally","Susan","Marquise","Calvin","Mike","Maggie", "Margaret", "Elizabeth","John","Matt"
        };
        public List<string> lastNames = new List<string>()
        {
            "Smith","Sutton","Jones","Warpinski","Stark","Matthews","James","Certon","Yiannopolis","Hering","Varney","Jacobson","Justice","Tolken","Bezier","Messier","King"
        };
    public Customer()
        {
            //EvaluateAccessibility();
            GetName();
            GetMoneyAmount();
            GetDisposition();
            DisplayCustomer();
        }

        //public void EvaluateAccessibility()
        //{
        //    if (Game.daysOfWeek(i).temperature == )
        //}
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