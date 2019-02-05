﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //HAS A
        int gameMode;
        int die;
        TimeFrame timeFrame;
        Player player;
        MarketPlace marketPlace;
        string playLength;
        int playLengthNumber;
        int amountOfDays;
        Day day;
        Customer customer;
        List<Day> daysOfWeek;

        public Game()
        {
            daysOfWeek = new List<Day>();
            player = new Player();
            marketPlace = new MarketPlace();
            RunGame();
        }
      public void GetPlayLength()
        {
            Console.WriteLine("How many days would you like to play for?");
            playLength = Console.ReadLine();
            playLengthNumber = Convert.ToInt32(playLength);
        }
       public void ConvertToDays()
        {
            for (int index = 0; index < playLengthNumber; index++)
            {
                day = new Day();
                daysOfWeek.Add(day);
            }
        }
        public void DisplayWeeklyWeather()
        {
            try
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"The sky is {daysOfWeek[i].weatherConditions.condition}, it is {daysOfWeek[i].weatherConditions.temperature}°F, with {daysOfWeek[i].weatherConditions.precipitationAmount} {daysOfWeek[i].weatherConditions.precipitation}.");
                    System.Threading.Thread.Sleep(2000);
                }
            }
            catch
            {
                return;
            }
        }
       
        public void RunGame()
        {
            MainMenu.ViewRules();
            GetPlayLength();
            ConvertToDays();
            DisplayWeeklyWeather();
            for (int i = 0; i < playLengthNumber; i++)
            {
                daysOfWeek[i].RunDay(/*List<Customer> listOfCustomers*/);
            }
           // customer.Buy(daysOfWeek[0].weatherConditions);
        }
        public void DisplayDailyWeather()
        {
            Console.WriteLine($"The sky is {daysOfWeek[0].weatherConditions.condition}, it is {daysOfWeek[0].weatherConditions.temperature}°F, with {daysOfWeek[0].weatherConditions.precipitationAmount}{daysOfWeek[0].weatherConditions.precipitation}.");
        }

        public void DisplayActualWeather()
        {
            if(MainMenu.RollDie(0,3) == 0)
            {
               
            }
           
        }
        public void OpenStand()
        {
            
        }
        
        
        public Player Player
        {
            get => default(LemonadeStand.Player);
            
        }

        

        public MarketPlace MarketPlace
        {
            get => default(LemonadeStand.MarketPlace);
            set
            {
            }
        }

        public Day Day
        {
            get => default(Day);
            set
            {
            }
        }
    }
}