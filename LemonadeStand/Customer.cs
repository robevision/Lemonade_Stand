using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Customer
    {
        private bool disposition;
        private int money;
        private int accessibility;
        List<string> customer;
        List<string> firstName = new List<string>()
        {
            "Billy", "Jose", "Geraldo","Bob", "Frank","Edgar","Molly", "Meredith", "Adam", "Larry", "George", "Sally","Susan","Marquise","Calvin","Mike","Maggie", "Margaret", "Elizabeth","John","Matt"
        };
        List<string> lastName = new List<string>()
        {
            "Smith","Sutton","Jones","Warpinski","Stark","Matthews","James","Certon","Yiannopolis","Hering","Varney","Jacobson","Justice","Tolken","Bezier","Messier","King"
        };
    public Customer()
        {
            GetName();
            GetMoneyAmount();
            GetDisposition();

        }
    public void GetName()
        {
            customer.Add (firstName[MainMenu.RollDie(0, 40)]);
            customer.Add(lastName[MainMenu.RollDie(0, 40)]);
        }
        public void GetMoneyAmount()
        {
            money = MainMenu.RollDie(0, 100) * MainMenu.RollDie(0, 100);
            string textOfMoney = Convert.ToString(money);
            customer.Add(textOfMoney);
        }
        public void GetDisposition()
        {

        }
    }
    
}