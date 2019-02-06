using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    class Sugar : Ingredient
    {
        public Sugar()
        {
            price = 0;
        }
        public override void GetAmount()
        {
            throw new NotImplementedException();
        }
        public override void GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}